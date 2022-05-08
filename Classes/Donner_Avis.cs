using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Note.Classes
{
    class Donner_Avis
    {
        public DateTime Date_avis { get; set; }
        public string Nature_avis { get; set; }
        public int Id_note { get; set; }
        public Note_Service Note_Service { get; set; }
        public int Id_employe { get; set; }
        public Employe Employe { get; set; }
    }
}
