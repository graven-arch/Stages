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
    public partial class FRM_Note : Form
    {
        private UserControl UcNote;
        private BdContext db;
        
        public FRM_Note(UserControl User)
        {
            InitializeComponent();
            db= new BdContext();
            this.UcNote = User ;
            // affichage des départements dans le combobox
            CbdeptNote.DataSource = db.Departements.ToList();
            // Pour filtrer seulement que les noms des départements
            CbdeptNote.DisplayMember = "Nom_departement";
            CbdeptNote.ValueMember = "Id_departement";
            
        }
        //Champs obligatoires
        string testobligatoire()
        {
            if(cbEtape.Text=="")
            {
                return "Choisir l'Etape de la note";
            }
            if (txtTitreN.Text == "")
            {
                return "Renseigner le titre de la note";
            }
            if (txtLibelleN.Text == "")
            {
                return "Renseigner le libellé de la note";
            }
            /* if (txtRemarqueN.Text == "")
            {
                return "Choisir l'Etape de la note";
            }*/
            if (CbdeptNote.Text == "")
            {
                return "Choisir le département concerné";
            }
            if (dtpDatepublication.Text == "")
            {
                return "Choisir la date de publication de la note";
            }
            return null;
        }

        private void FRM_Note_Load(object sender, EventArgs e)
        {

        }
        public int IdSelect;
        private void btnAjouterN_Click(object sender, EventArgs e)
        {
            if (testobligatoire()!=null)
            {
                MessageBox.Show( testobligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error /*"Note ajoutée avec succès", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk*/);
               // (UcEmploye as UC_Employe).ActualiserDatagrid();
            }
            else if (lblAjoutNote.Text == "Ajouter Note")
            {
                //AjoutNote Noteservice = new AjoutNote();
               
                {
                    AjoutNote Noteservice = new AjoutNote();
                    if(Noteservice.AjouterNote(cbEtape.Text, txtTitreN.Text, txtLibelleN.Text, txtRemarqueN.Text,Convert.ToInt32(CbdeptNote.SelectedValue), DateTime.Parse(dtpDatepublication.Text), int.Parse(txtIdemploye.Text)/*txtIdemploye.Text*/) == true)
                    {
                        MessageBox.Show("Note ajoutée avec succès", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (UcNote as UC_Note).ActualiserDatagrid();
                    }
                    else
                    {
                        MessageBox.Show("Note déjà existante", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                AjoutNote note = new AjoutNote();
                UC_Note ucNote = new UC_Note();
                DialogResult R = MessageBox.Show("Voulez vous vraiment modifier cette note?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    note.ModifierNote(IdSelect, cbEtape.Text, txtTitreN.Text, txtLibelleN.Text, txtRemarqueN.Text, Convert.ToInt32(CbdeptNote.SelectedValue), DateTime.Parse(dtpDatepublication.Text), int.Parse(txtIdemploye.Text));
                    (UcNote as UC_Note).ActualiserDatagrid();//actualiser le datagrid
                    MessageBox.Show("Note modifiée avec succès", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Modification annulée", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void CbdeptNote_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnActualiserN_Click(object sender, EventArgs e)
        {

        }

        private void txtLibelleN_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
