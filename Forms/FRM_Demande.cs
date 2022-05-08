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
    public partial class FRM_Demande : Form
    {
        private UserControl UcDemande;
        

        public FRM_Demande(UserControl userD)
        {
            InitializeComponent();
            this.UcDemande = userD;
        }

        string testobligatoire()
        {
            if (txtObjectif.Text == "" )
            {
                return "Veuillez entrer l'objectif de la demande";
            }
            
            return null;
        }
        public int IdSelect;
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (testobligatoire() != null)
            {
                MessageBox.Show(testobligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(lblAjouterModifierD.Text == "Ajouter Demande")
            {
                AjoutDemande demande = new AjoutDemande();
                if (demande.AjouterDemande(txtObjectif.Text, DateTime.Parse(dtpDateDemande.Text), DateTime.Parse(dtpDatePublicationDe.Text), DateTime.Parse(dtpDatePriseEffetDe.Text)) == true)
                {
                    MessageBox.Show("Demande ajoutée avec succès", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (UcDemande as UC_Demande).ActualiserDatagrid();
                }
                else
                {
                    MessageBox.Show("Demande déjà existante", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                AjoutDemande demande = new AjoutDemande();
                UC_Demande ucDemande = new UC_Demande();
                DialogResult R = MessageBox.Show("Voulez vous vraiment modifier cette demande ?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    demande.ModifierDemande(IdSelect, txtObjectif.Text, DateTime.Parse(dtpDateDemande.Text), DateTime.Parse(dtpDatePublicationDe.Text), DateTime.Parse(dtpDatePriseEffetDe.Text));
                    (UcDemande as UC_Demande).ActualiserDatagrid();//actualiser le datagrid
                    MessageBox.Show("Demande modifiée avec succès", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Modification annulée", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtpDateDemande_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FRM_Demande_Load(object sender, EventArgs e)
        {

        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            
        }
    }
}
