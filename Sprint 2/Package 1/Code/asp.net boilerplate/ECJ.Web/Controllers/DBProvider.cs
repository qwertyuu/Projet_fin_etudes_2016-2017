using ECJ.Web.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Data.SqlClient;
using System.Web;
using System.Collections;

namespace ECJ.Web.Controllers
{
    public class DBProvider
    {
        private static PE2_OfficielEntities db;
        public DBProvider()
        {
            if (db == null)
            {
                db = new PE2_OfficielEntities();
            }
        }

        internal void LireMemo(int v)
        {
            db.tblMemo.Find(v).statut = true;
            db.SaveChanges();
        }

        internal void CreerMemo(int expediteur, int destinataire, string message, string lien)
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

        internal void SupprimerMemo(int v)
        {
            db.tblMemo.Find(v).dateSupprime = DateTime.Now;
            db.SaveChanges();
        }

        internal List<tblMemo> MemosUtilisateur(long userId)
        {
            return db.tblMemo.Where(m => m.destinataire == userId && m.dateSupprime == null).ToList();
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
        internal tblActivite ReturnActivite(int id)
        {
            return db.tblActivite.Find(id);
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

        internal void ToggleEtatActivite(int id)
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

        internal void SupprimerActivite(int id)
        {
            var a = db.tblActivite.Find(id);
            a.dateSupprime = DateTime.Now;
            db.SaveChanges();
        }

        internal AbpRoles SelectRole(int roleId)
        {
            return db.AbpRoles.Find(roleId);
        }

        internal List<ECJ.Web.Models.AbpUsers> ToutUtilisateurs()
        {
            return db.AbpUsers.Where(u => u.Id != 1).ToList();
        }

        internal void UpdateActivite(tblActivite tblActivite)
        {
            db.Entry(db.tblActivite.Find(tblActivite.noActivite)).CurrentValues.SetValues(tblActivite);
            db.SaveChanges();
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

        internal IEnumerable ToutSousEvenement()
        {
            return db.tblSousEvenement.Where(se => se.dateSupprime == null);
        }

        internal IEnumerable ToutEvenement()
        {
            return db.tblEvenement.Where(e => e.dateSupprime == null);
        }


        //Requête sur la table tblAppelOffre
        public List<tblSoumission> RetunSoumission(int? id)
        {
            if (id != null)
            {
               return (from soumi in db.tblSoumission
                        join ao in db.tblAppelOffre
                        on soumi.noAppelOffre equals ao.noAppelOffre
                        where ao.noAppelOffre == id
                        where soumi.dateSupprime == null
                        where ao.dateSupprime == null
                        select soumi).ToList();
            }
            else
            {
                return (from soumi in db.tblSoumission
                        where soumi.dateSupprime == null
                        select soumi).ToList();

            }

        }

        internal void InsertServiceRequis(int id, int serviceAAjouter)
        {
            db.tblSousEvenement.Find(id).tblService.Add(db.tblService.Find(serviceAAjouter));
            db.SaveChanges();
        }

        internal void SupprimerServiceRequis(int id, int serviceASupprimer)
        {
            db.tblSousEvenement.Find(id).tblService.Remove(db.tblService.Find(serviceASupprimer));
            db.SaveChanges();
        }

        internal void LierForfait(int id, int forfaitALier)
        {
            db.tblSousEvenement.Find(id).tblForfait.Add(db.tblForfait.Find(forfaitALier));
            db.SaveChanges();
        }

        internal void DelierForfait(int id, int forfaitASupprimer)
        {
            db.tblSousEvenement.Find(id).tblForfait.Remove(db.tblForfait.Find(forfaitASupprimer));
            db.SaveChanges();
        }

        internal List<tblService> ToutService()
        {
            return db.tblService.Where(s => s.dateSupprime == null).ToList();
        }

        internal void LierSalle(int id, int salle_id)
        {
            db.tblSousEvenement.Find(id).tblSalle = db.tblSalle.Find(salle_id);
            db.SaveChanges();
        }

        internal List<tblForfait> ToutForfait()
        {
            return db.tblForfait.Where(f => f.dateSupprime == null).ToList();
        }
        internal List<tblForfait> ToutForfaitLieeEvent(int id)
        {
            return db.tblForfait.Where(f => f.dateSupprime == null).ToList();
        }

        internal void DelierSalle(int id)
        {
            db.tblSousEvenement.Find(id).tblSalle = null;
            db.SaveChanges();
        }

        internal List<tblEngagement> ToutEngagement()
        {
            return db.tblEngagement.Where(e => e.dateSupprime == null).ToList();
        }

        internal void LierEngagement(int id, int engagement_id)
        {
            db.tblSousEvenement.Find(id).tblEngagement.Add(db.tblEngagement.Find(engagement_id));
            db.SaveChanges();
        }

        internal List<tblSalle> ToutSalle()
        {
            return db.tblSalle.Where(s => s.dateSupprime == null).ToList();
        }

        internal void DelierEngagement(int id, int engagement_id)
        {
            db.tblSousEvenement.Find(id).tblEngagement.Remove(db.tblEngagement.Find(engagement_id));
            db.SaveChanges();
        }

        public List<tblAgencePublicite> ReturnAgence(int? id)
        {
            if (id != null)
            {
               return  (from ag in db.tblAgencePublicite
                       join soumi in db.tblSoumission 
                       on ag.noAgencePub equals soumi.noAgencePub
                       where soumi.noAppelOffre == id
                       where soumi.dateSupprime == null
                       where ag.dateSupprime == null
                       select ag).ToList();

            }
            else
            {
               return (from ag in db.tblAgencePublicite
                       where ag.dateSupprime == null
                                       select ag).ToList();
            }

        }

        internal void SupprimerSousEvenement(int id)
        {
            db.tblSousEvenement.Find(id).dateSupprime = DateTime.Now;
            db.SaveChanges();
        }

        internal void UpdateSousEvenement(tblSousEvenement tblSousEvenement)
        {
            db.Entry(db.tblEvenement.Find(tblSousEvenement.noSousEvenement)).CurrentValues.SetValues(tblSousEvenement);
            db.SaveChanges();
        }

        public void InsertSoumission(tblSoumission soumi)
        {
            db.tblSoumission.Add(soumi);
            db.SaveChanges();
        }

        public void InsertActivite(tblActivite _acti)
        {
            db.tblActivite.Add(_acti);
            db.SaveChanges();
        }
        public void InsertSousEvenement(tblSousEvenement _sousEvenement)
        {
            db.tblSousEvenement.Add(_sousEvenement);
            db.SaveChanges();
        }

        public tblSousEvenement FindSousEvenement(int id)
        {
            return db.tblSousEvenement.Find(id);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public tblSoumission SleclectSoumi(int noApp, int noAgence)
        {
            return db.tblSoumission.Where(s => s.noAgencePub == noAgence && s.noAppelOffre == noApp).FirstOrDefault();
        }
        public void ConnectionServer(SqlConnection conn)
        {
            conn.ConnectionString = "Data Source=10.10.8.42;Initial Catalog=PE2_Officiel;Integrated Security=False;User ID=P2016_Equipe2;Password=Rasipike2";
            conn.Open();
        }

        public tblAppelOffre SelectAppelParSoumi(int ? idSoumi)
        {
            return (from a in db.tblAppelOffre
                   join s in db.tblSoumission
                   on a.noAppelOffre equals s.noAppelOffre
                   where s.noSoumission == idSoumi
                   select a).FirstOrDefault();
        }

        public tblStatutAppelOffre ReturnStatut(string nom)
        {
            return db.tblStatutAppelOffre.Where(s => s.nom == nom).FirstOrDefault();
        }

        public tblSoumission ReturnUneSoumi(int ?id )
        {
            return db.tblSoumission.Find(id);
        }
        public tblSalle ReturnSalle(int id)
        {
            return db.tblSalle.Where(s => s.noSalle == id).FirstOrDefault();
        }
        public tblCalculateur ReturnCalculateur(int id)
        {
            return db.tblCalculateur.Where(s => s.noSousEvenement == id).FirstOrDefault();
        }
    }
}