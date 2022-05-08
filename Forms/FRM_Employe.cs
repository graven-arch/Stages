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

namespace Gestion_Note.Forms
{
    public partial class FRM_Employe : Form
    {
        private UserControl UcEmploye;
        public FRM_Employe( UserControl userE)
        {
            InitializeComponent();
            this.UcEmploye = userE;
        }

       

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void FRM_Employe_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtNom_Enter(object sender, EventArgs e)
        {
            if (txtNom.Text == "Nom Employe" )
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.White;
            }
        }

        /*private void txtPrenomE_Enter(object sender, EventArgs e)
        {
            if (txtPrenomE.Text =="Prenom Employe")
            {
                txtPrenomE.Text = "";
                txtPrenomE.ForeColor = Color.White;
            }
        }*/

        private void txtEmailE_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNatureE_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtNatureE_Enter(object sender, EventArgs e)
        {
            if (txtNatureE.Text == "Nature Employe")
            {
                txtNatureE.Text = "";
                txtNatureE.ForeColor = Color.White;
            }
        }

        private void txtEmailE_Enter(object sender, EventArgs e)
        {
            if (txtEmailE.Text == "Email Employe")
            {
                txtEmailE.Text = "";
                txtEmailE.ForeColor = Color.White;
            }
        }

        private void txtDeptE_Enter(object sender, EventArgs e)
        {
            if (txtDeptE.Text == "Departement Employe")
            {
                txtDeptE.Text = "";
                txtDeptE.ForeColor = Color.White;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtDeptE_FontChanged(object sender, EventArgs e)
        {

        }

        private void txtPrenomE_Enter(object sender, EventArgs e)
        {
            if (txtPrenomE.Text == "Prenom Employe")
            {
                txtPrenomE.Text = "";
                txtPrenomE.ForeColor = Color.White;
            }
        }
        string testobligatoire()
        {
            if (txtNom.Text == "" || txtNom.Text=="Nom Employe")
            {
                return "Veuillez entrer le nom";
            }
            if (txtPrenomE.Text == "" || txtPrenomE.Text == "Prenom Employe")
            {
                return "Veuillez entrer le prénom";
            }
            if (txtEmailE.Text == "" || txtEmailE.Text == "Email Employe")
            {
                return "Veuillez renseigner l'Email";
            }
            /* if (txtRemarqueN.Text == "")
            {
                return "Choisir l'Etape de la note";
            }*/
            if (txtNatureE.Text == "" || txtNatureE.Text == "Nature Employe")
            {
                return "Veuillez renseigner le titre de l'employé";
            }
            if (txtDeptE.Text == "" || txtDeptE.Text == "Departement Employe")
            {
                return "Veuillez renseigner le département actuel de l'employé";
            }
            if (txtEmailE.Text !="" || txtEmailE.Text == "Email Employe")
            {
                try
                {
                    new MailAddress(txtEmailE.Text);
                }
                catch (Exception )
                {
                    return "Email invalide!!";
                }
            }

                return null;
        }
        public int IdSelect;

        private void btnAjouter_Click(object sender, EventArgs e)
        {
           
            if (testobligatoire()!=null)
            {
                MessageBox.Show(testobligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (lblAjouterModifier.Text == "Ajouter Employe")
            {
                AjoutEmploye employe = new AjoutEmploye();
                if (employe.AjouterEmploye(txtNom.Text, txtPrenomE.Text, txtEmailE.Text, txtNatureE.Text, txtDeptE.Text) == true)
                {
                    MessageBox.Show("Employe ajouté avec succès", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (UcEmploye as UC_Employe).ActualiserDatagrid();
                }
                else

                {
                    MessageBox.Show("Employe déjà existant", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                AjoutEmploye employe = new AjoutEmploye();
                UC_Employe ucEmploye = new UC_Employe();
                DialogResult R = MessageBox.Show("Voulezvous vraiment modifier cet Employé?", "Modification", MessageBoxButtons.YesNo,MessageBoxIcon.Question) ;
                if(R==DialogResult.Yes)
                {
                    employe.ModifierEmploye(IdSelect, txtNom.Text, txtPrenomE.Text, txtEmailE.Text, txtNatureE.Text, txtDeptE.Text);
                    (UcEmploye as UC_Employe).ActualiserDatagrid();//actualiser le datagrid
                    MessageBox.Show("Employé modifié avec succès", "Modification",MessageBoxButtons.OK,MessageBoxIcon.Asterisk) ;
                }
                else
                {
                    MessageBox.Show("Modification annulée", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            txtNom.Text = "Nom Employe"; txtNom.ForeColor = Color.White;
            txtPrenomE.Text = "Prenom Employe"; txtPrenomE.ForeColor = Color.White;
            txtEmailE.Text = "Nom Employe"; txtEmailE.ForeColor = Color.White;
            txtNatureE.Text = "Nom Employe"; txtNatureE.ForeColor = Color.White;
            txtDeptE.Text = "Nom Employe"; txtDeptE.ForeColor = Color.White;
        } 
    }
}
