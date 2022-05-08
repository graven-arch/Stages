using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Note.Classes
{
    class Acceder
    {

        public DateTime Date_acces { get; set; }
        public int Id_employe { get; set; }
        public Employe Employe { get; set; }
        // public Employe Employe { get; set; }
        public int Id_demande { get; set; }
        public Demande_Note Demande_Note { get; set; }

    }
}
