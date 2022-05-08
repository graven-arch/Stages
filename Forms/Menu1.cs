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
    public partial class Menu1 : Form
    {
        public Menu1()
        {
            InitializeComponent();

            pnlMenu.Size = new Size(242 ,557) ;
            //pnlConnexion.Visible = false;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            pnlDep.Top = btnAccueil.Top;
            //UC_Accueil uC_Accueil = new UC_Accueil();
            //uC_Accueil.Show() ;
            if (!pnlAfficher.Controls.Contains(UC_Accueil.InstanceAccueil))
            {
                pnlAfficher.Controls.Add(UC_Accueil.InstanceAccueil);
                UC_Accueil.InstanceAccueil.Dock = DockStyle.Fill;
                UC_Accueil.InstanceAccueil.BringToFront();
            }
            else
            {
                UC_Accueil.InstanceAccueil.BringToFront();
            }
            //UC_Accueil uC_Accueil = new UC_Accueil();
            //uC_Accueil.Show() ;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnReduce_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       /* private void btnConnect_Click(object sender, EventArgs e)
        {
            pnlConnexion.Size = new Size(238, 131);
            pnlConnexion.Visible = !pnlConnexion.Visible;
        }*/

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlDep_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEmploye_Click(object sender, EventArgs e)
        {
            pnlDep.Top = btnEmploye.Top;
            // FRM_Employe fRM_Employe = new FRM_Employe();
            //fRM_Employe.ShowDialog();
            if (!pnlAfficher.Controls.Contains(UC_Employe.InstanceEmploye))
            {
                pnlAfficher.Controls.Add(UC_Employe.InstanceEmploye);
                UC_Employe.InstanceEmploye.Dock = DockStyle.Fill;
                UC_Employe.InstanceEmploye.BringToFront();
            }
            else
            {
                UC_Employe.InstanceEmploye.BringToFront();
            }
        }

        private void btnDepart_Click(object sender, EventArgs e)
        {
           pnlDep.Top = btnNoteService.Top;
              if (!pnlAfficher.Controls.Contains(UC_Note.InstanceNote))
             {
                 pnlAfficher.Controls.Add(UC_Note.InstanceNote);
                 UC_Note.InstanceNote.Dock = DockStyle.Fill;
                 UC_Note.InstanceNote.BringToFront();
             }
             else
             {
                 UC_Note.InstanceNote.BringToFront();
             }
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            pnlDep.Top = btnNote.Top;
            if(!pnlAfficher.Controls.Contains(UC_Demande.Instance))
            {
                pnlAfficher.Controls.Add(UC_Demande.Instance);
                UC_Demande.Instance.Dock = DockStyle.Fill;
                UC_Demande.Instance.BringToFront();
            }
            else
            {
                UC_Demande.Instance.BringToFront();
            }
        }

        private void btnCompte_Click(object sender, EventArgs e)
        {
            pnlDep.Top = btnCompte.Top;
            if (!pnlAfficher.Controls.Contains(UC_Connexion.Instance))
            {
                pnlAfficher.Controls.Add(UC_Connexion.Instance);
                UC_Connexion.Instance.Dock = DockStyle.Fill;
                UC_Connexion.Instance.BringToFront();
            }
            else
            {
                UC_Connexion.Instance.BringToFront();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FRM_Connection fRM_Connection = new FRM_Connection();
            fRM_Connection.ShowDialog();
        }

        private void pnlConnexion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDeconnect_Click(object sender, EventArgs e)
        {

        }
    }
}
