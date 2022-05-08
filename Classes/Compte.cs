using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Note.Classes
{
    class Compte
    {
        public int Login { get; set; }
        public string Pswd_initial { get; set; }
        public string Pswd_definitif{ get; set; }
        public DateTime Date_expiration { get; set; }
        public ICollection<Profile> Profiles { get; set; }
        public ICollection<Operation> Operations { get; set; }
        public string Profile_actuel { get; set; }
        public Employe Employe { get; set; }
        //public int Id_profile  { get; set; }
    }
}
