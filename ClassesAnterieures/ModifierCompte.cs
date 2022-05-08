using Gestion_Note.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Note.ClassesAnterieures
{
    
    class ModifierCompte
    {
        private BdContext db = new BdContext();
        private Compte C;
        public void Modifiercompte(int Login, string Pswd_initial )
        {
            C = new Compte();
            C = db.Comptes.SingleOrDefault(c => c.Login == Login);
            if (C != null)
            {
                C.Pswd_initial = Pswd_initial;
                db.SaveChanges();
            }
        }
    }
}
