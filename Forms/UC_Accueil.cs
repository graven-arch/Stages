using Gestion_Note.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Note.Forms
{
    public partial class UC_Accueil : UserControl
    {
        private static UC_Accueil Accueil;
        private BdContext db;
        public static UC_Accueil InstanceAccueil
        {
            get
            {
                if (Accueil == null)
                {
                    Accueil = new UC_Accueil();
                }
                return Accueil;
            }

        }
        public UC_Accueil()
        {
            InitializeComponent();
            db = new BdContext();
        }

        private void UC_Accueil_Load(object sender, EventArgs e)
        {

        }
    }
}
