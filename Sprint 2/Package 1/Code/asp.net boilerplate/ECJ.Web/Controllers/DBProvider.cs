using ECJ.Web.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Data.SqlClient;
using System.Web;
using System.Collections;
using System.Net.Mail;
using System.Data;
using System.Data.Entity;

namespace ECJ.Web.Controllers
{
    public class DBProvider
    {
        private static PE2_OfficielEntities db;
        public DBProvider()
        {
            ResetDB();
        }

        internal void LireMemo(int v)
        {
            try
            {
                db.tblMemo.Find(v).statut = true;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        internal bool UtilisateurExiste(string uname, string exclu_id)
        {
            try
            {
                if(exclu_id == null)
                {
                    return db.AbpUsers.Where(u => !u.IsDeleted).Any(u => u.UserName == uname);
                }
                else
                {
                    var exclu_id_int = int.Parse(exclu_id);
                    return db.AbpUsers.Where(u => !u.IsDeleted && u.Id != exclu_id_int).Any(u => u.UserName == uname);
                }
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return true;
        }

        internal void ResetDB()
        {
            try
            {
                db = null;
                db = new PE2_OfficielEntities();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        internal bool CourrielExiste(string email, string exclu_id)
        {
            try
            {
                if(exclu_id == null)
                {
                    return db.AbpUsers.Where(u => !u.IsDeleted).Any(u => u.EmailAddress == email);
                }
                else
                {
                    var exclu_id_int = int.Parse(exclu_id);
                    return db.AbpUsers.Where(u => !u.IsDeleted && u.Id != exclu_id_int).Any(u => u.EmailAddress == email);
                }
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return true;
        }

        public List<tblCommanditaire> CommanditaireList()
        {
            try
            {
                return db.tblCommanditaire.Where(c => c.dateSupprime == null).ToList();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new List<tblCommanditaire>();
        }

        public List<tblDon> DonList()
        {
            try
            {
                return db.tblDon.ToList();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new List<tblDon>();
        }

        public tblCommanditaire returnCommanditaire(int id)
        {
            try
            {
                return db.tblCommanditaire.Find(id);
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new tblCommanditaire();
        }

        public tblDon returnDon(int id)
        {
            try
            {
                return db.tblDon.Find(id);
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new tblDon();
        }

        public void CreerMemo(int expediteur, int destinataire, string message, string lien)
        {
            try
            {
                db.tblMemo.Add(new tblMemo()
                {
                    expediteur = expediteur,
                    destinataire = destinataire,
                    info = message,
                    lien = lien,
                    dateEnvoi = DateTime.Now
                });
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        public void AjouterDon(tblDon tblDon)
        {
            try
            {
                db.tblDon.Add(tblDon);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        public tblEvenement ReturnEvenement(int id)
        {
            try
            {
                return db.tblEvenement.Find(id);
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new tblEvenement();
        }
        public List<vueSomEvenement> ToutSomEvenement()
        {
            try
            {
                return db.vueSomEvenement.ToList();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new List<vueSomEvenement>();
        }

        public void SupprimerMemo(int v)
        {
            try
            {
                db.tblMemo.Find(v).dateSupprime = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }
        internal AbpUsers ReturnUtilisateur(long id)
        {
            try
            {
                return db.AbpUsers.Find(id);
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new AbpUsers();
        }

        internal AbpUsers ReturnUtilisateur(string nom)
        {
            try
            {
                List<AbpUsers> list = ToutUtilisateurs();
                long id = 0;
                foreach(var i in list)
                {
                    if(i.UserName == nom)
                    {
                        id = i.Id;
                    }
                }
                if(id==0)
                {
                    return new AbpUsers();
                }
                return db.AbpUsers.Find(id);
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new AbpUsers();
        }
        internal void InsertUser(AbpUsers abpUser)
        {
            try
            {
                db.AbpUsers.Add(abpUser);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        internal void SupprimerCommanditaire(int id)
        {
            try
            {
                var elementASupprimer = returnCommanditaire(id);
                elementASupprimer.dateSupprime = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        public List<tblMemo> MemosUtilisateur(long userId)
        {
            try
            {
                return db.tblMemo.Where(m => m.destinataire == userId && m.dateSupprime == null).ToList();

            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new List<tblMemo>();
        }

        public void AjouterCommanditaire(tblCommanditaire comm)
        {
            try
            {
                db.tblCommanditaire.Add(comm);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        public tblCommanditaire ReturnCommLogo(tblCommanditaire comm)
        {
            try
            {
                return db.tblCommanditaire.Find(comm.noCommanditaire);
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new tblCommanditaire();
        }

        public void EnregistrerCommanditaire(tblCommanditaire comm)
        {
            try
            {
                db.Entry(db.tblCommanditaire.Find(comm.noCommanditaire)).CurrentValues.SetValues(comm);
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        public void ModifCommanditaire(tblCommanditaire comm)
        {
            try
            {
                db.Entry(comm).State = EntityState.Modified;
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }



        #region décodeur de type d'image depuis byte[]
        private static Dictionary<byte[], ImageFormat> imageFormatDecoders = new Dictionary<byte[], ImageFormat>()
        {
            { new byte[]{ 0x42, 0x4D }, ImageFormat.Bmp},
            { new byte[]{ 0x47, 0x49, 0x46, 0x38, 0x37, 0x61 }, ImageFormat.Gif },
            { new byte[]{ 0x47, 0x49, 0x46, 0x38, 0x39, 0x61 }, ImageFormat.Gif },
            { new byte[]{ 0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A }, ImageFormat.Png },
            { new byte[]{ 0xff, 0xd8 }, ImageFormat.Jpeg }
        };
        #endregion
        public tblActivite ReturnActivite(int id)
        {
            try
            {
                return db.tblActivite.Find(id);
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new tblActivite();
        }

        public static ImageFormat GetContentType(byte[] imageBytes)
        {
            if (imageBytes != null)
            {
                MemoryStream ms = new MemoryStream(imageBytes);

                using (BinaryReader br = new BinaryReader(ms))
                {
                    int maxMagicBytesLength = imageFormatDecoders.Keys.OrderByDescending(x => x.Length).First().Length;

                    byte[] magicBytes = new byte[maxMagicBytesLength];

                    for (int i = 0; i < maxMagicBytesLength; i += 1)
                    {
                        magicBytes[i] = br.ReadByte();

                        foreach (var kvPair in imageFormatDecoders)
                        {
                            if (StartsWith(magicBytes, kvPair.Key))
                            {
                                return kvPair.Value;
                            }
                        }
                    }

                    return ImageFormat.Png;
                }
            }
            return null;
        }

        internal void UpdateRole(AbpUsers abpUser, int role)
        {
            try
            {
                var u = db.AbpUsers.Find(abpUser.Id);

                if (!u.AbpUserRoles.Any(UR => UR.RoleId == role) && role != 0)
                {
                    for (int i = 0; i < u.AbpUserRoles.Count; i++)
                    {
                        db.Entry(u.AbpUserRoles.ElementAt(i)).State = EntityState.Deleted;
                    }
                    u.AbpUserRoles.Clear();
                    u.AbpUserRoles.Add(new AbpUserRoles() { UserId = abpUser.Id, RoleId = role, CreationTime = DateTime.Now, TenantId = 1 });
                }
                else if(role == 0)
                {
                    for (int i = 0; i < u.AbpUserRoles.Count; i++)
                    {
                        db.Entry(u.AbpUserRoles.ElementAt(i)).State = EntityState.Deleted;
                    }
                    u.AbpUserRoles.Clear();
                }
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        internal void UpdateUser(AbpUsers abpUser)
        {
            try
            {
                db.Entry(db.AbpUsers.Find(abpUser.Id)).CurrentValues.SetValues(abpUser);
                //db.Entry(abpUser).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        public void InsertEvenement(tblEvenement tblEvenement)
        {
            try
            {
                db.tblEvenement.Add(tblEvenement);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        public void ToggleEtatActivite(int id)
        {
            try
            {
                var a = db.tblActivite.Find(id);
                if (a.etat == 0)
                {
                    a.etat = 1;
                }
                else
                {
                    a.etat = 0;
                }
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        public void UpdateCommanditaire(tblCommanditaire tblCommanditaire)
        {
            try
            {
                db.Entry(db.tblCommanditaire.Find(tblCommanditaire.noCommanditaire)).CurrentValues.SetValues(tblCommanditaire);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        public void UpdateEvenement(tblEvenement tblEvenement)
        {
            try
            {
                db.Entry(db.tblEvenement.Find(tblEvenement.noEvenement)).CurrentValues.SetValues(tblEvenement);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        public void SupprimerActivite(int id)
        {
            try
            {
                var a = db.tblActivite.Find(id);
                a.dateSupprime = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        public AbpRoles SelectRole(int roleId)
        {
            try
            {
                return db.AbpRoles.Find(roleId);
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new AbpRoles();
        }

        public List<tblQuestionSecrete> ToutQuestion()
        {
            try
            {
                return db.tblQuestionSecrete.ToList();
            }
            catch(Exception e)
            {
                LayoutController.erreur = e;
            }
            return new List<tblQuestionSecrete>();
        }

        public List<ECJ.Web.Models.AbpUsers> ToutUtilisateurs()
        {
            try
            {
                return db.AbpUsers.Where(u => u.Id != 1).ToList();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new List<AbpUsers>();
        }

        public void SupprimerEvenement(int id)
        {
            try
            {
                var aSupprimer = db.tblEvenement.Find(id);
                aSupprimer.dateSupprime = DateTime.Now;
                foreach (var appelOffre in aSupprimer.tblAppelOffre.Where(ao => ao.dateSupprime == null))
                {
                    appelOffre.noStatut = 4;
                    db.Entry(appelOffre).State = EntityState.Modified;
                    foreach (var soumission in appelOffre.tblSoumission.Where(s => s.dateSupprime == null))
                    {
                        soumission.statut = null;
                        db.Entry(soumission).State = EntityState.Modified;
                    }
                }
                db.Entry(aSupprimer).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        public void supprimerDon(int id)
        {
            try
            {
                db.tblDon.Find(id).dateSupprime = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        public void UpdateActivite(tblActivite tblActivite)
        {
            try
            {
                db.Entry(db.tblActivite.Find(tblActivite.noActivite)).CurrentValues.SetValues(tblActivite);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        private static bool StartsWith(byte[] thisBytes, byte[] thatBytes)
        {
            for (int i = 0; i < thatBytes.Length; i += 1)
            {
                if (thisBytes[i] != thatBytes[i])
                {
                    return false;
                }
            }
            return true;
        }

        public List<tblSousEvenement> ToutSousEvenement()
        {
            try
            {
                return db.tblSousEvenement.Where(se => se.dateSupprime == null && se.tblEvenement.dateSupprime == null).ToList();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new List<tblSousEvenement>();
        }

        public List<tblCommanditaire> ToutCommenditaire()
        {
            try
            {
                return db.tblCommanditaire.Where(c => c.dateSupprime == null).ToList();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new List<tblCommanditaire>();
        }

        public List<tblAppelOffre> ToutAppleOffre()
        {
            try
            {
                return db.tblAppelOffre.Where(a => a.dateSupprime == null).ToList();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new List<tblAppelOffre>();
        }
        public List<tblCommanditaire> CommenEvent(int? noEven)
        {
            if (noEven != null)
            {
                
                    try
                    {
                        return (from c in db.tblCommanditaire
                                join d in db.tblDon
                                on c.noCommanditaire equals d.noCommanditaire
                                join se in db.tblSousEvenement
                                on d.noSousEvenement equals se.noSousEvenement
                                where c.dateSupprime == null
                                where se.dateSupprime == null
                                where d.dateSupprime == null
                                where se.tblEvenement.dateSupprime == null
                                where se.tblEvenement.noEvenement == noEven
                                select c).ToList();
                    }
                    catch (Exception e)
                    {
                        LayoutController.erreur = e;
                    }
                }               
            
            return new List<tblCommanditaire>();
        }

        
        public List<tblCommanditaire> CommenSousEvent(int? noEven)
        {
            if (noEven != null)
            {
                
                    try
                    {
                        return (from c in db.tblCommanditaire
                                join d in db.tblDon
                                on c.noCommanditaire equals d.noCommanditaire
                                where c.dateSupprime == null
                                where d.tblSousEvenement.dateSupprime == null
                                where d.dateSupprime == null
                                where d.tblSousEvenement.noSousEvenement == noEven
                                select c).ToList();
                    }
                    catch (Exception e)
                    {
                        LayoutController.erreur = e;
                    }                

            }


            return new List<tblCommanditaire>();
        }


        public List<tblEvenement> ToutEvenement()
        {
            try
            {
                return db.tblEvenement.Where(e => e.dateSupprime == null).ToList();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new List<tblEvenement>();
        }
        public List<tblDon> ToutDon()
        {
            try
            {
                return db.tblDon.Where(d => d.dateSupprime == null && d.tblCommanditaire.dateSupprime==null).ToList();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new List<tblDon>();
        }


        //Requête sur la table tblAppelOffre
        public List<tblSoumission> RetunSoumission(int? id)
        {
            if (id != null)
            {
                try
                {
                    return (from soumi in db.tblSoumission
                            join ao in db.tblAppelOffre
                            on soumi.noAppelOffre equals ao.noAppelOffre
                            where ao.noAppelOffre == id
                            where soumi.dateSupprime == null
                            where ao.dateSupprime == null
                            select soumi).ToList();
                }
                catch (Exception e)
                {
                    LayoutController.erreur = e;
                }
            }
            else
            {
                try
                {
                    return (from soumi in db.tblSoumission
                            where soumi.dateSupprime == null
                            select soumi).ToList();
                }
                catch (Exception e)
                {
                    LayoutController.erreur = e;
                }

            }
            return new List<tblSoumission>();
        }

        internal List<ECJ.Web.Models.AbpAuditLogs> ToutLogs()
        {
            try
            {
                return db.AbpAuditLogs.ToList();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new List<AbpAuditLogs>();
        }

        public void InsertServiceRequis(int id, int serviceAAjouter)
        {
            try
            {
                db.tblSousEvenement.Find(id).tblService.Add(db.tblService.Find(serviceAAjouter));
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        public void SupprimerServiceRequis(int id, int serviceASupprimer)
        {
            try
            {
                db.tblSousEvenement.Find(id).tblService.Remove(db.tblService.Find(serviceASupprimer));
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        public void LierForfait(int id, int forfaitALier)
        {
            try
            {
                db.tblSousEvenement.Find(id).tblForfait.Add(db.tblForfait.Find(forfaitALier));
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        public void DelierForfait(int id, int forfaitASupprimer)
        {
            try
            {
                var sousEvenement = db.tblSousEvenement.Find(id);
                sousEvenement.tblForfait.Remove(db.tblForfait.Find(forfaitASupprimer));
                db.Entry(sousEvenement).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        public List<tblService> ToutService()
        {
            try
            {
                return db.tblService.Where(s => s.dateSupprime == null).ToList();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new List<tblService>();
        }

        public void LierSalle(int id, int salle_id)
        {
            try
            {
                db.tblSousEvenement.Find(id).tblSalle = db.tblSalle.Find(salle_id);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        public List<tblForfait> ToutForfait()
        {
            try
            {
                return db.tblForfait.Where(f => f.dateSupprime == null).ToList();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new List<tblForfait>();
        }

        internal List<AbpUserRoles> ToutRoleUtilisateur()
        {
            try
            {
                return db.AbpUserRoles.Where(ur => ur.UserId != 1).ToList();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new List<AbpUserRoles>();
        }

        internal List<AbpRoles> ToutRoles()
        {
            try
            {
                return db.AbpRoles.Where(r => r.Id != 1).ToList();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new List<AbpRoles>();
        }

        public List<tblForfait> ToutForfaitLieeEvent(int id)
        {
            try
            {
                return db.tblForfait.Where(f => f.dateSupprime == null).ToList();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new List<tblForfait>();
        }

        public void DelierSalle(int id)
        {
            try
            {
                var sousEvenement = FindSousEvenement(id);
                db.tblSalle.Attach(sousEvenement.tblSalle);
                db.tblSousEvenement.Attach(sousEvenement);
                sousEvenement.noSalle = null;
                sousEvenement.tblSalle = null;
                db.Entry(sousEvenement).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        internal string GetRoleUtilisateur(AbpUsers abpUsers)
        {
            try
            {
                if(abpUsers.AbpUserRoles.Count > 0)
                {
                    return SelectRole(abpUsers.AbpUserRoles.ToList()[0].RoleId).Name;
                }
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return "Employe";
        }

        public List<tblEngagement> ToutEngagement()
        {
            try
            {
                return db.tblEngagement.Where(e => e.dateSupprime == null).ToList();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new List<tblEngagement>();
        }

        public void LierEngagement(int id, int engagement_id)
        {
            try
            {
                db.tblSousEvenement.Find(id).tblEngagement.Add(db.tblEngagement.Find(engagement_id));
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        internal void SupprimerSoumission(tblSoumission s)
        {
            try
            {
                s.dateSupprime = DateTime.Now;
                db.Entry(s).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        public List<tblSalle> ToutSalle()
        {
            try
            {
                return db.tblSalle.Where(s => s.dateSupprime == null).ToList();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new List<tblSalle>();
        }

        public void DelierEngagement(int id, int engagement_id)
        {
            try
            {
                var sousEvenement = db.tblSousEvenement.Find(id);
                sousEvenement.tblEngagement.Remove(db.tblEngagement.Find(engagement_id));
                db.Entry(sousEvenement).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        public List<tblAgencePublicite> ReturnAgence(int? id)
        {
            if (id != null)
            {
                try
                {
                    return (from ag in db.tblAgencePublicite
                            join soumi in db.tblSoumission
                            on ag.noAgencePub equals soumi.noAgencePub
                            where soumi.noAppelOffre == id
                            where soumi.dateSupprime == null
                            where ag.dateSupprime == null
                            select ag).ToList();
                }
                catch (Exception e)
                {
                    LayoutController.erreur = e;
                }

            }
            else
            {
                try
                {
                    return (from ag in db.tblAgencePublicite
                            where ag.dateSupprime == null
                            select ag).ToList();
                }
                catch (Exception e)
                {
                    LayoutController.erreur = e;
                }
            }
            return new List<tblAgencePublicite>();
        }

        public void SupprimerSousEvenement(int id)
        {
            try
            {
                db.tblSousEvenement.Find(id).dateSupprime = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        public void UpdateSousEvenement(tblSousEvenement tblSousEvenement)
        {
            try
            {
                db.Entry(db.tblSousEvenement.Find(tblSousEvenement.noSousEvenement)).CurrentValues.SetValues(tblSousEvenement);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        public void InsertSoumission(tblSoumission soumi)
        {
            try
            {
                db.tblSoumission.Add(soumi);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        public void InsertActivite(tblActivite _acti)
        {
            try
            {
                db.tblActivite.Add(_acti);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }
        public void InsertSousEvenement(tblSousEvenement _sousEvenement)
        {
            try
            {
                db.tblSousEvenement.Add(_sousEvenement);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        public tblSousEvenement FindSousEvenement(int id)
        {
            try
            {
                return db.tblSousEvenement.Find(id);
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new tblSousEvenement();
        }

        public void Save()
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        public tblSoumission SleclectSoumi(int noApp, int noAgence)
        {
            try
            {
                return db.tblSoumission.Where(s => s.noAgencePub == noAgence && s.noAppelOffre == noApp).FirstOrDefault();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new tblSoumission();
        }
        public void ConnectionServer(SqlConnection conn)
        {
            try
            {
                conn.ConnectionString = "Data Source=10.10.8.42;Initial Catalog=PE2_Officiel;Integrated Security=False;User ID=P2016_Equipe2;Password=Rasipike2";
                conn.Open();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        public tblAppelOffre SelectAppelParSoumi(int? idSoumi)
        {
            try
            {
                return (from a in db.tblAppelOffre
                        join s in db.tblSoumission
                        on a.noAppelOffre equals s.noAppelOffre
                        where s.noSoumission == idSoumi
                        select a).FirstOrDefault();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new tblAppelOffre();
        }

        public tblStatutAppelOffre ReturnStatut(string nom)
        {
            try
            {
                return db.tblStatutAppelOffre.Where(s => s.nom == nom).FirstOrDefault();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new tblStatutAppelOffre();
        }

        public tblSoumission ReturnUneSoumi(int? id)
        {
            try
            {
                return db.tblSoumission.Find(id);
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new tblSoumission();
        }
        public tblSalle ReturnSalle(int id)
        {
            try
            {
                return db.tblSalle.Where(s => s.noSalle == id).FirstOrDefault();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new tblSalle();
        }
        public tblCalculateur ReturnCalculateur(int? id)
        {
            try
            {
                return db.tblCalculateur.Where(s => s.noSousEvenement == id).FirstOrDefault();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new tblCalculateur();
        }
        public tblAppelOffre returnAppel(int? id)
        {
            try
            {
                return db.tblAppelOffre.Find(id);
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new tblAppelOffre();
        }
        public List<tblAgencePublicite> ToutAgencePublicite()
        {
            try
            {
                return db.tblAgencePublicite.Where(a => a.dateSupprime == null).ToList();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new List<tblAgencePublicite>();
        }
        public List<tblStatutAppelOffre> ToutStatutAppel()
        {
            try
            {
                return db.tblStatutAppelOffre.ToList();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new List<tblStatutAppelOffre>();
        }

        public List<tblMedia> ToutMedia()
        {
            try
            {
                return db.tblMedia.ToList();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new List<tblMedia>();
        }

        public int ReturnNoStatut(string nomStatut)
        {
            try
            {
                return db.tblStatutAppelOffre.Where(s => s.nom == nomStatut).FirstOrDefault().noStatut;
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return -1;
        }

        public tblStatutAppelOffre ReturnStatAppel(tblAppelOffre appel)
        {
            try
            {
                return (from q in db.tblStatutAppelOffre
                        where q.noStatut == appel.noStatut
                        select q).FirstOrDefault();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new tblStatutAppelOffre();
        }

        public tblEvenement ReturnEvenAppel(tblAppelOffre appel)
        {
            try
            {
                return (from q in db.tblEvenement
                        where q.noEvenement == appel.noEvenement
                        select q).FirstOrDefault();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new tblEvenement();
        }

        public tblMedia ReturnMediaAppel(tblAppelOffre appel)
        {
            try
            {
                return (from q in db.tblMedia
                        where q.noMedia == appel.noMedia
                        select q).FirstOrDefault();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new tblMedia();
        }

        public void UpdateAppelOffre(tblAppelOffre appel)
        {
            try
            {
                db.Entry(db.tblAppelOffre.Find(appel.noAppelOffre)).CurrentValues.SetValues(appel);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        public void UpdateSoumission(tblSoumission soumi)
        {
            try
            {
                db.Entry(db.tblSoumission.Find(soumi.noSoumission)).CurrentValues.SetValues(soumi);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }
        public void AjoutAppelOffre(tblAppelOffre appel)
        {
            try
            {
                db.tblAppelOffre.Add(appel);
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }
        public List<vueSomSalle> ToutVueSalle()
        {
            try
            {
                return db.vueSomSalle.ToList();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new List<vueSomSalle>();
        }
        public void InsertServiceOffert(int id, int serviceAAjouter)
        {
            try
            {
                db.tblSalle.Find(id).tblService.Add(db.tblService.Find(serviceAAjouter));
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }
        public void SupprimerServiceOffert(int id, int serviceASupprimer)
        {
            try
            {
                db.tblSalle.Find(id).tblService.Remove(db.tblService.Find(serviceASupprimer));
                db.SaveChanges();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }

        public tblAgencePublicite ReturnAgenceParSoumi(tblSoumission soumi)
        {
            try
            {
                return (from q in db.tblAgencePublicite
                        where q.noAgencePub == soumi.noAgencePub
                        select q).FirstOrDefault();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new tblAgencePublicite();

        }
        public tblService ReturnService(int id)
        {
            try
            {
                return db.tblService.Find(id);
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }

            return new tblService();
        }

        public List<vueSomAppelOffre> ToutSomAppelOffre()
        {
            try
            {
                return db.vueSomAppelOffre.AsNoTracking().ToList();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new List<vueSomAppelOffre>();
        }
        public List<tblCalculateur> ReturnListCalculateur()
        {
            try
            {
                return db.tblCalculateur.ToList();
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new List<tblCalculateur>();
        }
        public List<tblSalle> ReturnListSalle()
        {
            try
            {
                return db.tblSalle.ToList();
            }

            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new List<tblSalle>();
        }
        public void UpdateCalculateur(tblCalculateur tblCalculateur)
        {
            try
            {
                if (db.tblCalculateur.Where(s => s.noSousEvenement == tblCalculateur.noSousEvenement).ToList().Count() == 0)
                {
                    db.tblCalculateur.Add(tblCalculateur);
                    db.SaveChanges();
                }
                else
                {
                db.Entry(db.tblCalculateur.Find(tblCalculateur.noSousEvenement)).CurrentValues.SetValues(tblCalculateur);
                db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
        }
        public tblSousEvenement ReturnSousEvent(int id)
        {
            try
            {
                return db.tblSousEvenement.Find(id);
            }
            catch (Exception e)
            {
                LayoutController.erreur = e;
            }
            return new tblSousEvenement();
        }
    }
}