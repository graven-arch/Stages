using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_Note.Classes;

namespace Gestion_Note.Forms
{
    public partial class FRM_Connection : Form
    {
        private BdContext bd;
        //initialisation d'une clsse de CLSConnection
        ClassesAnterieures.CLSConnection C = new ClassesAnterieures.CLSConnection();
        public FRM_Connection()
        {
            InitializeComponent();
            // initialiser la base de données
            bd = new BdContext();
        }
        // Vérification des champs obligatoires
        string TestConnexion()
        {
            if (txtNom.Text == ""|| txtNom.Text=="Email")
            {
                return "Entrer votre Email";
            }
            if (txtMotdepasse.Text == "" || txtMotdepasse.Text == "Mot de Passe")
            {
                return "Entrer votre mot de passe";
            }
            if(cbMulti.Text=="")
            {
                return "Quel est votre statut dans l'Institut?";
            }
            if (txtNom.Text != "" || txtNom.Text == "Email")
            {
                try
                {
                    new MailAddress(txtNom.Text);
                }
                catch (Exception)
                {
                    return "Email invalide!!";
                }
            }
            return null;
            
        }

        private void lblcon_Click(object sender, EventArgs e)
        {

        }

        private void FRM_Connection_Load(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNom_Enter(object sender, EventArgs e)
        {
            //Pour vider le textbox
            if (txtNom.Text =="Email")
            {
                txtNom.Text ="";
                txtNom.ForeColor = Color.White;
            }
        }

        private void txtMotdepasse_Enter(object sender, EventArgs e)
        {
            //Pour vider le textbox
            if (txtMotdepasse.Text == "Mot de Passe")
            {
                txtMotdepasse.Text = "";
                txtMotdepasse.UseSystemPasswordChar = false;
                txtMotdepasse.PasswordChar = '*';
                txtMotdepasse.ForeColor = Color.White;
            }
        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            if(txtNom.Text=="")
            {
                txtNom.Text = "Email";
                txtNom.ForeColor = Color.Silver;

            }
        }

        private void txtMotdepasse_Leave(object sender, EventArgs e)
        {
            if (txtMotdepasse.Text == "")
            {
                txtMotdepasse.Text = "";
                txtMotdepasse.ForeColor = Color.Silver;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(TestConnexion()==null)
            {
               // if (C.Connexion(bd,txtNom.Text,txtMotdepasse.Text,cbMulti.Text)==true && cbMulti.Text=="Employé")//Compte existant 
                    if (C.Connexion(bd, txtNom.Text, txtMotdepasse.Text,cbMulti.Text/*, cbMulti.Text*/) == true && cbMulti.Text == "Employé")
                    {
                    
                    MessageBox.Show("Connexion réussie","Connexion",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    Menu1 menu = new Menu1();
                    menu.btnNote.Visible = false;
                    menu.btnEmploye.Visible = false;
                    menu.ShowDialog();
                }
                else if (C.Connexion(bd, txtNom.Text, txtMotdepasse.Text, cbMulti.Text) == true && cbMulti.Text == "Directeur")
                {
                    MessageBox.Show("Connexion réussie", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Menu1 menu = new Menu1();
                    menu.btnEmploye.Visible = false;
                    menu.ShowDialog();
                }
                else if (C.Connexion(bd, txtNom.Text, txtMotdepasse.Text, cbMulti.Text) == true && cbMulti.Text == "Administrateur")
                {
                    MessageBox.Show("Connexion réussie", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Menu1 menu = new Menu1();
                    menu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Connexion échouée", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // MessageBox.Show("Valide");
            }
            else
            {
                MessageBox.Show(TestConnexion(), "Obligatoire",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtMotdepasse_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
