using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Reporting.WebForms;

namespace ECJ.Web.Controllers
{
    public class ReportController : Controller
    {
        DBProvider db = new DBProvider();
        // GET: Report
        public ActionResult Index()
        {
            var reportQuery = (from k in db.ToutEvenement()
                               select new
                               {
                                   k.nom,
                                   k.dateDebut,
                                   k.datefin,
                                   k.url
                               }).ToList();

            LocalReport u = new LocalReport();
            u.ReportPath = "Report2.rdlc";
            u.DataSources.Clear();
            ReportDataSource datasource = new ReportDataSource("DataSet1", reportQuery);
            u.DataSources.Add(datasource);


            LocalReport r = new LocalReport();
            r.ReportPath = "Report1.rdlc";
            r.DataSources.Clear();

            var d = (db.ToutSousEvenement().Where(sse => sse.noEvenement == int.Parse(r.GetParameters().First(param => param.Name == "noEvenement").Values[0])));
            ReportDataSource datasource2 = new ReportDataSource("DataSet1", d);
            r.DataSources.Add(datasource2);
            //ReportParameter p = new ReportParameter("DeptID", deptID.ToString());
            //u.SetParameters(new[] { p });

            var cd = new System.Net.Mime.ContentDisposition
            {
                // for example foo.bak
                FileName = "salut_bob.pdf",

                // always prompt the user for downloading, set to true if you want 
                // the browser to try to show the file inline
                Inline = true,
            };
            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;

            byte[] bytes = u.Render(
                "PDF", null, out mimeType, out encoding, out filenameExtension,
                out streamids, out warnings);
            

            Response.AppendHeader("Content-Disposition", cd.ToString());
            return File(bytes, "application/pdf");
        }

    }
    public static class Ext
    {
        public static DataSet ToDataSet<T>(this IList<T> list)
        {
            Type elementType = typeof(T);
            DataSet ds = new DataSet();
            DataTable t = new DataTable();
            ds.Tables.Add(t);

            //add a column to table for each public property on T
            foreach (var propInfo in elementType.GetProperties())
            {
                Type ColType = Nullable.GetUnderlyingType(propInfo.PropertyType) ?? propInfo.PropertyType;

                t.Columns.Add(propInfo.Name, ColType);
            }

            //go through each property on T and add each value to the table
            foreach (T item in list)
            {
                DataRow row = t.NewRow();

                foreach (var propInfo in elementType.GetProperties())
                {
                    row[propInfo.Name] = propInfo.GetValue(item, null) ?? DBNull.Value;
                }

                t.Rows.Add(row);
            }

            return ds;
        }
    }
}