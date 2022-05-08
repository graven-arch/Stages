//using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Microsoft.Reporting.WinForms;

namespace Gestion_Note.Forms
{
    public partial class UC_Note : UserControl
    {
        private static UC_Note Note;
        private BdContext dbN;
        public static UC_Note InstanceNote
        {
            get
            {
                if (Note == null)
                {
                    Note = new UC_Note();
                }
                return Note;
            }

        }
        public UC_Note()
        {
            InitializeComponent();
            dbN = new BdContext();

            txtRecherche.Enabled = false;
        }
        public void ActualiserDatagrid()
        {
            dbN = new BdContext();
            var list = (from n in dbN.Note_Services select new {n.Id_note, n.Etape_note, n.Titre_note, n.Libelle_note, n.Id_departement, n.Remarque_note, n.Date_publicationN, n.Id_employe,n.Employe.Nom_employe,n.Departement.Nom_departement }).ToList();
            dgvNote.Rows.Clear();
           //Ici Modifs dans bloc note
            foreach (var N in list/*dbN.Note_Services*/)
            {
                //ajout des lignes dans le datagridview
                dgvNote.Rows.Add(false, N.Id_note, N.Etape_note, N.Titre_note,N.Libelle_note, N.Nom_departement, N.Remarque_note, N.Date_publicationN, N.Nom_employe);
            }
        }
        public string SelectVerif()
        {
            int NbreSelect = 0;
            for (int i = 0; i < dgvNote.Rows.Count; i++)
            {
                if ((bool)dgvNote.Rows[i].Cells[0].Value == true)//si la ligne est selectionnée
                {
                    NbreSelect++;
                }

            }
            if (NbreSelect == 0)
            {
                return "Sélectonner la note que vous voulez modifier";
            }
            if (NbreSelect > 1)
            {
                return "Sélectonner une seule note";
            }
            return null;
        }

        private void UC_Note_Load(object sender, EventArgs e)
        {
                ActualiserDatagrid();

        }

        private void btnAjouterN_Click(object sender, EventArgs e)
        {
            /* if (!pnlAficher.Controls.Contains(UC_Note.InstanceNote))
            {
                pnlAficher.Controls.Add(UC_Note.InstanceNote);
                UC_Note.InstanceNote.Dock = DockStyle.Fill;
                UC_Note.InstanceNote.BringToFront();
            }
            else
            {
                UC_Note.InstanceNote.BringToFront();
            }*/
            FRM_Note fRM_Note = new FRM_Note(this);
            fRM_Note.ShowDialog();
        }
        //public int IdSelect;

        private void btnModifierN_Click(object sender, EventArgs e)
        {
            Forms.FRM_Note ModifierNote = new Forms.FRM_Note(this);
            if (SelectVerif() == null)
            {
                for (int i = 0; i < dgvNote.Rows.Count; i++)
                {
                    if ((bool)dgvNote.Rows[i].Cells[0].Value == true)//si la ligne est vraiment selectionnée afficher le formiulaire de modification avec les infos
                    {
                        ModifierNote.IdSelect = (int)dgvNote.Rows[i].Cells[1].Value;
                        ModifierNote.cbEtape.Text = dgvNote.Rows[i].Cells[2].Value.ToString();
                        ModifierNote.txtTitreN.Text = dgvNote.Rows[i].Cells[3].Value.ToString();
                        ModifierNote.txtLibelleN.Text = dgvNote.Rows[i].Cells[4].Value.ToString();
                        ModifierNote.CbdeptNote.Text = dgvNote.Rows[i].Cells[5].Value.ToString();
                        ModifierNote.txtRemarqueN.Text = dgvNote.Rows[i].Cells[6].Value.ToString();
                        ModifierNote.CbdeptNote.Text = dgvNote.Rows[i].Cells[7].Value.ToString();
                        ModifierNote.txtIdemploye.Text = dgvNote.Rows[i].Cells[8].Value.ToString();
                    }
                }
                ModifierNote.lblAjoutNote.Text = "Modifier Note";
                ModifierNote.btnActualiserN.Visible = false;
                ModifierNote.ShowDialog();
            }
            else
            {
                MessageBox.Show(SelectVerif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dgvNote_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            dbN = new BdContext();
            var listNote= dbN.Note_Services.ToList();// 
            if (txtRecherche.Text != "")
            {
                switch (cbRecherche.Text)
                {
                    case "Titre":
                        listNote= listNote.Where(n => n.Titre_note.IndexOf(txtRecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                       
                        break;
                    case "Etape":
                        listNote = listNote.Where(n => n.Etape_note.IndexOf(txtRecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Remarque":
                        listNote = listNote.Where(n => n.Remarque_note.IndexOf(txtRecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    
                }
            }
            //vider le datagridview
            dgvNote.Rows.Clear();
            // ajouter la liste au datagridview
            foreach (var N in listNote)
            {
                dgvNote.Rows.Add(false,N.Id_note,N.Etape_note,N.Titre_note,N.Departement,N.Remarque_note,N.Date_publicationN,N.Employe);

            }
        }

        private void txtRecherche_Enter(object sender, EventArgs e)
        {
            if (txtRecherche.Text == "Recherche")
            {
                txtRecherche.Text = "";
                txtRecherche.ForeColor = Color.Black;
            }
        }

        private void btnSupprimerN_Click(object sender, EventArgs e)
        {
            AjoutNote SuppresionN= new AjoutNote();
            int select = 0;
            for (int i = 0; i < dgvNote.Rows.Count; i++)
            {
                if ((bool)dgvNote.Rows[i].Cells[0].Value == true)
                {
                    select++;//Pour voir le nombre de lignes sélectionnées
                }
            }
            if (select==0)/*SelectVerif()=="Selectionner Note"*/// Vérifier si la note est sélectionnée
            {
                MessageBox.Show(SelectVerif(), "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult R = MessageBox.Show("Voulez-vous vraiment supprimer cette note?", "Suppresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    for (int i = 0; i < dgvNote.Rows.Count; i++)
                    {
                        if ((bool)dgvNote.Rows[i].Cells[0].Value == true)
                        {
                            //AjoutNote SuppresionN = new AjoutNote();
                            int idselect = (int)dgvNote.Rows[i].Cells[1].Value;//sélectionner la ligne cochée
                            SuppresionN.SupprimerNote(idselect);
                        }
                    }
                    ActualiserDatagrid();
                    MessageBox.Show("Note supprimée avec succès", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Suppresion annulée", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
           /* AjoutNote SuppresionN = new AjoutNote();
            int select = 0;
            for (int i = 0; i < dgvNote.Rows.Count; i++)
            {
                if ((bool)dgvNote.Rows[i].Cells[0].Value == true)
                {
                    select++;//Pour voir le nombre de lignes sélectionnées
                }
            }
            if (select == 0)
            {
                MessageBox.Show("Aucune note sélectionnée", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult R = MessageBox.Show("Voulez-vous vraiment supprimer cette note?", "Suppresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    for (int i = 0; i < dgvNote.Rows.Count; i++)
                    {
                        if ((bool)dgvNote.Rows[i].Cells[0].Value == true)//Pour la suppresion
                        {
                            SuppresionN.SupprimerNote(int.Parse(dgvNote.Rows[i].Cells[1].Value.ToString()),
                            dgvNote.Rows[i].Cells[2].Value.ToString(),
                             dgvNote.Rows[i].Cells[3].Value.ToString(),
                            dgvNote.Rows[i].Cells[4].Value.ToString(),
                            dgvNote.Rows[i].Cells[5].Value.ToString(),
                             dgvNote.Rows[i].Cells[6].Value.ToString(),
                             dgvNote.Rows[i].Cells[7].Value.ToString(),
                             dgvNote.Rows[i].Cells[8].Value.ToString());
                        }
                    }
                    ActualiserDatagrid();//Pour actualiser le datagridview
                    MessageBox.Show("Suppresion avec succès", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Suppresion annulée", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }*/
        }

        private void cbRecherche_SelectedIndexChanged(object sender, EventArgs e)
        {
            //activer le textbox recherche lorsque un champ serait choisi
            txtRecherche.Enabled = true;
            // vider le textBox
            txtRecherche.Text = "";
        }

        private void btnImpNote_Click(object sender, EventArgs e)
        {
            dbN = new BdContext();
            int idselect=0;
            //string NomDepart= null;
            //string NomEmp = null;
            //string NumNote = null;
            //string Date = null;
            RAPPORTS.FRM_RAPPORT fRM_RAPPORT = new RAPPORTS.FRM_RAPPORT();
            Classes.Note_Service N = new Classes.Note_Service();
            if(SelectVerif()!=null)
            {
                MessageBox.Show(SelectVerif(), "Imprimer Note", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);//Vérifier si l'utilisateur a coché plusieurs notes

            }
            else
            {
                for (int i = 0; i < dgvNote.Rows.Count; i++)
                {
                    if ((bool)dgvNote.Rows[i].Cells[0].Value == true)// si la ligne est cochée
                    {
                        idselect = (int) dgvNote.Rows[i].Cells[1].Value;//id de la ligne est sélectionnée
                       // NomDepart = dgvNote.Rows[i].Cells[4].ToString();
                       // NomEmp = dgvNote.Rows[i].Cells[7].ToString();
                        //NumNote = dgvNote.Rows[i].Cells[1].ToString();
                        //Date = dgvNote.Rows[i].Cells[6].ToString();
                    }
                }
                //
                N = dbN.Note_Services.SingleOrDefault(n => n.Id_note == idselect);
                if(N!=null)
                {
                    //Donner le rapport
                    fRM_RAPPORT.rpvnote.LocalReport.ReportEmbeddedResource = "Gestion_Note.RAPPORTS.RPT_Note.rdlc";//chemin de rapport
                    // using microsoft reporting winform
                    ReportParameter RPDepartement = new ReportParameter("RPDepartement", N.Id_departement.ToString());// Nom du département
                    ReportParameter RPObjectif = new ReportParameter("RPObjectif", N.Titre_note);
                    ReportParameter RPIdentifiant = new ReportParameter("RPIdentifiant",N.Id_note.ToString());
                    ReportParameter RPLibelle = new ReportParameter("RPLibelle", N.Libelle_note);
                    ReportParameter RPEmploye = new ReportParameter("RPEmploye", N.Id_employe.ToString());
                    ReportParameter RPDatePublication = new ReportParameter("RPDatePublication", N.Date_publicationN.ToString());
                    fRM_RAPPORT.rpvnote.LocalReport.SetParameters(new ReportParameter[] { RPDepartement, RPObjectif, RPIdentifiant, RPLibelle, RPEmploye, RPDatePublication });
                    fRM_RAPPORT.rpvnote.RefreshReport();
                    fRM_RAPPORT.ShowDialog();// afficher le rapport
                }
            }
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
           
            /*using (SaveFileDialog SFD = new SaveFileDialog() { Filter = "Word Document|*.docx", ValidateNames = true }) //Filtrer les fichiers Word
            {
                Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                Document D = app.Documents.Add();
                Document d = (Document)app.ActiveDocument;
                app.Visible = false;
                
            }*/
        }

        private void btnImptt_Click(object sender, EventArgs e)
        {
            try
            {
                RAPPORTS.FRM_RAPPORT RapportNotes = new RAPPORTS.FRM_RAPPORT();
                dbN = new BdContext();
                var listeNotes = dbN.Note_Services.ToList();
                RapportNotes.rpvnote.LocalReport.ReportEmbeddedResource = "Gestion_Note.RAPPORTS.RPT_NoteS.rdlc";
                //Ajouter le datasource
                RapportNotes.rpvnote.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", listeNotes));//Liste des notes
                ReportParameter Date = new ReportParameter("Date", DateTime.Now.ToString());
                RapportNotes.rpvnote.LocalReport.SetParameters(new ReportParameter[] { Date });
                RapportNotes.rpvnote.RefreshReport();
                RapportNotes.ShowDialog();// afficher le rapport
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
    }
}
