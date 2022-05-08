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
    public partial class UC_Connexion : UserControl
    {
        private static UC_Connexion conn;
        private BdContext db;
        public static UC_Connexion Instance
        {
            get
            {
                if (conn == null)
                {
                    conn = new UC_Connexion();
                }
                return conn;
            }

        }
        public UC_Connexion()
        {
            InitializeComponent();
            db = new BdContext();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void UC_Connexion_Load(object sender, EventArgs e)
        {

        }

        private void pnlAficher_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Forms.FRM_Compte ModifierCompte= new Forms.FRM_Compte();
            ModifierCompte.ShowDialog();
        }
    }
}
