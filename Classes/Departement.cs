using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Note.Classes
{
    class Departement
    {
        public int Id_departement { get; set; }
        public string Nom_departement { get; set; }
        public ICollection<Employe> Employes { get; set; }
        public ICollection<Appartenir> Appartenirs { get; set; }
        public ICollection<Note_Service>Note_Services{ get; set; }
    }
}
