using Gestion_Note.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Note
{
    class AjoutEmploye
    {
        private BdContext db = new BdContext();
        private Employe E;
        public bool AjouterEmploye(string Nom, string Prenom, string Email, string Nature, string Departement_actuel)
        {
            E = new Employe();
            E.Nom_employe = Nom;
            E.Prenom_employe = Prenom;
            E.Email_employe = Email;
            E.Nature_employe = Nature;
            E.Departement_actuel = Departement_actuel;
            if (db.Employes.SingleOrDefault(e => e.Nom_employe == Nom && E.Prenom_employe == Prenom) == null)
            {
                db.Employes.Add(E);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ModifierEmploye(int Id_employe, string Nom, string Prenom, string Email, string Nature, string Departement_actuel)
        {
            E = new Employe();
            E = db.Employes.SingleOrDefault(e => e.Id_employe == Id_employe);
            if(E!=null)
            {
                E.Nom_employe = Nom;
                E.Prenom_employe = Prenom;
                E.Email_employe = Email;
                E.Nature_employe = Nature;
                E.Departement_actuel = Departement_actuel;
                db.SaveChanges();
            }
        }
        public void SupprimerEmploye(int Id_employe, string Nom, string Prenom, string Email, string Nature, string Departement_actuel)
        {
            E = new Employe();
            E = db.Employes.SingleOrDefault(e => e.Id_employe == Id_employe);
            if (E != null)// Si l'employe existe
            {
                db.Employes.Remove(E);
                db.SaveChanges();
            }
        }
    }
    
}
