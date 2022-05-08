using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Note.Classes
{
    class Note_Service
    {
        public int Id_note { get; set; }
        public string Titre_note { get; set; }
        public string Libelle_note { get; set; }
        public string Etape_note { get; set; }
        public string Remarque_note { get; set; }
        public DateTime Date_publicationN { get; set; }
        public int Id_employe { get; set; }
        public ICollection<Employe> Employes { get; set; }
        //public ICollection<Note_Service> NoteServices { get; set; }
        public int Id_departement { get; set; }
        public Departement Departement{ get; set; }
        public Employe Employe { get; set; }
        public ICollection<Donner_Avis> Donner_Avis { get; set; }
        public ICollection<Modifier> Modifiers { get; set; }
    }
}
