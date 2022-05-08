using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Note.Classes
{
    class Operation
    {
        public int Id_operation { get; set; }
        public string Libelle_operation { get; set; }
        public DateTime Date_operation { get; set; }
        public DateTime Heure_operation { get; set; }
        public Compte Compte { get; set; }
        public int Login { get; set; }
    }
}
