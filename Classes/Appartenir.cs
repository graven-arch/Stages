using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Note.Classes
{
    class Appartenir
    {
        public DateTime Date_debut { get; set; }
        public DateTime Date_fin { get; set; }
        public int Id_employe { get; set; }
        public Employe Employe { get; set; }
        public int Id_departement { get; set; }
        public Departement Departement { get; set; }
    }
}
