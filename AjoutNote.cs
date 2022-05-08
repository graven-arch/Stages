using Gestion_Note.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Note
{
    class AjoutNote
    {
        private BdContext db = new BdContext();
        private Note_Service N;
        public bool AjouterNote(/*int Id_note,*/ string Etape, string Titre, string Libelle, string Remarque,int Id_departement, DateTime DatePublication, int Id_employe)

        {
            N = new Note_Service();
            //N.Id_note = Id_note;
            N.Etape_note = Etape;
            N.Titre_note = Titre;
            N.Libelle_note = Libelle;
            N.Id_departement=Id_departement;
            N.Remarque_note = Remarque;
            N.Date_publicationN = DatePublication;
            N.Id_employe = Id_employe;
            if (db.Note_Services.SingleOrDefault(n => n.Titre_note==Titre  /*E.Prenom_employe == Prenom*/) == null)
            {
                db.Note_Services.Add(N);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        
    
        }
        public void ModifierNote(int Id_note, string Etape, string Titre, string Libelle, string Remarque, int Id_departement, DateTime DatePublication, int Id_employe)
        {
            N = new Note_Service();
            N = db.Note_Services.SingleOrDefault(n => n.Id_note == Id_note);
            if (N != null)
            {
                N.Etape_note = Etape;
                N.Titre_note = Titre;
                N.Libelle_note = Libelle;
                N.Id_departement = Id_departement;
                N.Remarque_note = Remarque;
                N.Date_publicationN = DatePublication;
                N.Id_employe = Id_employe;
                db.SaveChanges();
            }
        }
        public void SupprimerNote(int Id_note)
        {
            N = new Note_Service();
            N = db.Note_Services.SingleOrDefault(e => e.Id_note == Id_note);
            if (N != null)// Si la note existe
            {
                db.Note_Services.Remove(N);
                db.SaveChanges();
            }
        }
    }
}
