using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Note.Classes
{
    class Profile
    {
        public int Id_profile { get; set; }
        public string Nom_profile { get; set; }
        public Compte Compte { get; set; }
        public int Login { get; set; }
    }
}
