//using Microsoft.Reporting.WinForms;
using Microsoft.Reporting.WinForms;
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
    public partial class UC_Demande : UserControl
    {
        private static UC_Demande NoteService;
        private BdContext db;
        public static UC_Demande Instance
        {
            get
            {
                if (NoteService == null)
                {
                    NoteService = new UC_Demande();
                }
                return NoteService;
            }
                
        }
        public UC_Demande()
        {
            InitializeComponent();
            db = new BdContext();
            txtRecherche.Enabled = false;
        }
        public void ActualiserDatagrid()
        {
            db = new BdContext();
            dgvDemande.Rows.Clear();
            foreach (var D in db.Demande_Notes)
            {
                //ajout des lignes dans le datagridview
                dgvDemande.Rows.Add(false, D.Id_demande, D.Objectif_demande, D.Date_demande, D.Date_publicationD, D.Date_effet) ;
            }
        }
        public string SelectVerif()
        {
            int NbreSelect = 0;
            for (int i = 0; i < dgvDemande.Rows.Count; i++)
            {
                if ((bool)dgvDemande.Rows[i].Cells[0].Value == true)//si la ligne est selectionnée
                {
                    NbreSelect++;
                }

            }
            if (NbreSelect == 0)
            {
                return "Sélectonner une demander";
            }
            if (NbreSelect > 1)
            {
                return "Sélectonner une seule demande";
            }
            return null;
        }

        private void txtRecherche_Enter(object sender, EventArgs e)
        {
            if(txtRecherche.Text=="Recherche")
            {
                txtRecherche.Text = "";
                txtRecherche.ForeColor = Color.Black;
            }
        }

        private void dgvNote_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_NoteService_Load(object sender, EventArgs e)
        {
            // exemple d'ajout de note
            ActualiserDatagrid();

        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            db = new BdContext();
            var listDemande = db.Demande_Notes.ToList();// Liste des demandes recherchées
            if (txtRecherche.Text != "")
            {
                switch (cbRecherche.Text)
                {
                    case "Objectif":
                        listDemande = listDemande.Where(n => n.Objectif_demande.IndexOf(txtRecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                     
                        break;
                   
                }
            }
            //vider le datagridview
            dgvDemande.Rows.Clear();
            // ajouter la liste au datagridview
            foreach (var D in listDemande)
            {
                dgvDemande.Rows.Add(false, D.Objectif_demande,D.Date_demande,D.Date_publicationD,D.Date_effet);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_EnvoiD fRM_D = new FRM_EnvoiD();
            fRM_D.ShowDialog();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FRM_Demande fRM_Demande = new FRM_Demande(this);
            fRM_Demande.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //activer le textbox recherche lorsque un champ serait choisi
            txtRecherche.Enabled = true;
            // vider le textBox
            txtRecherche.Text = "";
        }
        //public int IdSelect;

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Forms.FRM_Demande ModifierDemande = new Forms.FRM_Demande(this);
            if (SelectVerif() == null)
            {
                for (int i = 0; i < dgvDemande.Rows.Count; i++)
                {
                    if ((bool)dgvDemande.Rows[i].Cells[0].Value == true)//si la ligne est vraiment selectionnée afficher le formiulaire de modification avec les infos
                    {
                        ModifierDemande.IdSelect = (int)dgvDemande.Rows[i].Cells[1].Value;
                        ModifierDemande.txtObjectif.Text = dgvDemande.Rows[i].Cells[2].Value.ToString();
                        ModifierDemande.dtpDateDemande.Text = dgvDemande.Rows[i].Cells[3].Value.ToString();
                        ModifierDemande.dtpDatePriseEffetDe.Text = dgvDemande.Rows[i].Cells[4].Value.ToString();
                        ModifierDemande.dtpDatePublicationDe.Text = dgvDemande.Rows[i].Cells[5].Value.ToString();
                       
                    }
                }
                ModifierDemande.lblAjouterModifierD.Text = "Modifier Demande";
                ModifierDemande.btnActualiser.Visible = false;
                ModifierDemande.ShowDialog();
            }
            else
            {
                MessageBox.Show(SelectVerif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            AjoutDemande SuppresionD = new AjoutDemande();
            int select = 0;
            for (int i = 0; i < dgvDemande.Rows.Count; i++)
            {
                if ((bool)dgvDemande.Rows[i].Cells[0].Value == true)
                {
                    select++;//Pour voir le nombre de lignes sélectionnées
                }
            }
            if (select == 0)
            {
                MessageBox.Show("Aucune Demande sélectionnée", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult R = MessageBox.Show("Voulez-vous vraiment supprimer cette Demande?", "Suppresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    for (int i = 0; i < dgvDemande.Rows.Count; i++)
                    {
                        if ((bool)dgvDemande.Rows[i].Cells[0].Value == true)//Pour la suppresion
                        {
                            SuppresionD.SupprimerDemande(int.Parse(dgvDemande.Rows[i].Cells[1].Value.ToString()),
                                 dgvDemande.Rows[i].Cells[2].Value.ToString(),
                                 DateTime.Parse(dgvDemande.Rows[i].Cells[3].Value.ToString()),
                                 DateTime.Parse(dgvDemande.Rows[i].Cells[4].Value.ToString()),
                                 DateTime.Parse(dgvDemande.Rows[i].Cells[5].Value.ToString()));
                        }
                    }
                    ActualiserDatagrid();//Pour actualiser le datagridview
                    MessageBox.Show("Suppresion avec succès", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Suppresion annulée", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSauvegarger_Click(object sender, EventArgs e)
        {
            db = new BdContext();
            int idselect = 0;
           
            //string Dated = null;
            RAPPORTS.FRM_RAPPORT R_Demande = new RAPPORTS.FRM_RAPPORT();
            Classes.Demande_Note D = new Classes.Demande_Note();
            if (SelectVerif() != null)
            {
                MessageBox.Show(SelectVerif(), "Imprimer Demande", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);//Vérifier si l'utilisateur a coché plusieurs notes

            }
            else
            {
                for (int i = 0; i < dgvDemande.Rows.Count; i++)
                {
                    if ((bool)dgvDemande.Rows[i].Cells[0].Value == true)// si la ligne est cochée
                    {
                        idselect = (int)dgvDemande.Rows[i].Cells[1].Value;//id de la ligne est sélectionnée
                   
                        //Datee =dgvDemande.Rows[i].Cells[5].ToString();
                        // Dated =dgvDemande.Rows[i].Cells[6].ToString();

                    }
                }
                //
                D = db.Demande_Notes.SingleOrDefault(d => d.Id_demande == idselect);
                if (D != null)
                {
                    
                    //Donner le rapport
                    R_Demande.rpvnote.LocalReport.ReportEmbeddedResource = "Gestion_Note.RAPPORTS.RPT_Demande.rdlc";//chemin de rapport
                    // using microsoft reporting winform
                    ReportParameter DateD = new ReportParameter("DateD",D.Date_publicationD.ToString());// Nom du département
                    ReportParameter DateP = new ReportParameter("DateP", D.Date_publicationD.ToString());
                    ReportParameter DateE = new ReportParameter("DateE", D.Date_effet.ToString());
                    ReportParameter Objectif = new ReportParameter("Objectif", D.Objectif_demande);
                   
                    ReportParameter Identifiant = new ReportParameter("Id", D.Id_demande.ToString());

                    //ReportDataSource dataSource = new ReportDataSource("DataSet1");

                    R_Demande.rpvnote.LocalReport.SetParameters(new ReportParameter[] { DateD, Objectif,DateP,DateE,Identifiant });
                    R_Demande.rpvnote.RefreshReport();
                    R_Demande.ShowDialog();// afficher le rapport
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                RAPPORTS.FRM_RAPPORT RapportD = new RAPPORTS.FRM_RAPPORT();
                db = new BdContext();
                var listeD = db.Demande_Notes.ToList();
                RapportD.rpvnote.LocalReport.ReportEmbeddedResource = "Gestion_Note.RAPPORTS.RPT_DemandeS.rdlc";
                //Ajouter le datasource
                RapportD.rpvnote.LocalReport.DataSources.Add(new ReportDataSource("DataSetDemande", listeD));//Liste des notes
                ReportParameter Date = new ReportParameter("Date", DateTime.Now.ToString());
                RapportD.rpvnote.LocalReport.SetParameters(new ReportParameter[] { Date });
                RapportD.rpvnote.RefreshReport();
                RapportD.ShowDialog();// afficher le rapport
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
