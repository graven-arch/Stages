using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Note.Classes
{
    class Employe
    {
        public int Id_employe { get; set; }
        public string Nom_employe { get; set; }
        public string Prenom_employe { get; set; }
        public string Email_employe { get; set; }
        public string Nature_employe { get; set; }
        public string Motdepasse { get; set; }
        public string statut { get; set; }
        public string Departement_actuel { get; set; }
       // public Demande_Note demande { get; set; }
        public ICollection<Demande_Note> Demande_Notes { get; set; }
        public ICollection<Departement> Departements { get; set; }
        public ICollection<Note_Service> Note_Services { get; set; }
        //public ICollection<Note_Service> NoteServices{ get; set; }
        public Compte Compte { get; set; }
        public ICollection<Donner_Avis> Donner_Avis { get; set; }
        public ICollection<Modifier> Modifiers { get; set; }
        public ICollection<Appartenir> Appartenirs { get; set; }
        public ICollection<Acceder> Acceders { get; set; }
    }
}
