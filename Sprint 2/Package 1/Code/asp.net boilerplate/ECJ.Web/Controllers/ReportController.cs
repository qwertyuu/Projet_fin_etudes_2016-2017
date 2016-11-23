using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECJ.Web.Controllers
{
    public class ReportController : Controller
    {
        DBProvider db = new DBProvider();
        // GET: Report
        public ActionResult Index()
        {
            ReportDocument rd = new ReportDocument();
            rd.Load(Server.MapPath("/CrystalReport1.rpt"));
            
            rd.SetDataSource(db.ToutSousEvenement().Select(sse => new
            {
                noSousEvenement = sse.noSousEvenement,
                nom = sse.nom,
                description = sse.description,
                noEvenement = sse.noEvenement
            }).ToList());
            //Response.Buffer = false;
            //Response.ClearContent();
            //Response.ClearHeaders();
            Stream s = rd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
            //s.Seek(0, SeekOrigin.Begin);
            var cd = new System.Net.Mime.ContentDisposition
            {
                // for example foo.bak
                FileName = "salut_bob.pdf",

                // always prompt the user for downloading, set to true if you want 
                // the browser to try to show the file inline
                Inline = true,
            };

            Response.AppendHeader("Content-Disposition", cd.ToString());
            return File(s, "application/pdf");
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