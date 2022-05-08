using Gestion_Note.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Note
{
    class AjoutDemande
    {
        private BdContext db = new BdContext();
        private Demande_Note D;
        public bool AjouterDemande(string Objectif_demande, DateTime Date_demande, DateTime Date_publicationD, DateTime Date_effet)
        {
            D = new Demande_Note();
            D.Objectif_demande = Objectif_demande;
            D.Date_demande = Date_demande;
            D.Date_publicationD = Date_publicationD;
            D.Date_effet = Date_effet;
            if (db.Demande_Notes.SingleOrDefault(d => d.Objectif_demande==Objectif_demande && D.Date_demande == Date_demande) == null)
            {
                db.Demande_Notes.Add(D);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ModifierDemande(int Id_demande, string Objectif_demande, DateTime Date_demande, DateTime Date_publicationD, DateTime Date_effet)
        {
            D = new Demande_Note();
            D = db.Demande_Notes.SingleOrDefault(de => de.Id_demande == Id_demande);
            if (D != null)
            {
                D = new Demande_Note();
                D.Objectif_demande = Objectif_demande;
                D.Date_demande = Date_demande;
                D.Date_publicationD = Date_publicationD;
                D.Date_effet = Date_effet;
                db.SaveChanges();
            }
        }
        public void SupprimerDemande(int Id_demande, string Objectif_demande, DateTime Date_demande, DateTime Date_publicationD, DateTime Date_effet)
        {
            D = new Demande_Note();
            D = db.Demande_Notes.SingleOrDefault(e => e.Id_demande == Id_demande);
            if (D != null)// Si l'employe existe
            {
                db.Demande_Notes.Remove(D);
                db.SaveChanges();
            }
        }
    }
}
