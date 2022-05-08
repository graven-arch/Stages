using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Note.Classes
{
    class Demande_Note
    {
        public int Id_demande { get; set; }
        public DateTime Date_demande { get; set; }
        public string Objectif_demande { get; set; }
        public DateTime Date_publicationD { get; set; }
        public DateTime Date_effet { get; set; }
        public string Archiver_demande { get; set; }
        //public int Id_employe { get; set; }
        //public Employe Employe { get; set; }
        public ICollection<Employe> Employes { get; set; }
        public ICollection<Acceder> Acceders { get; set; }
    }
}
