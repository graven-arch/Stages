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
    public partial class UC_Employe : UserControl
    {
        private static UC_Employe Employe;
        private BdContext db; 
        public static UC_Employe InstanceEmploye
        {
            get
            {
                if (Employe == null)
                {
                    Employe = new UC_Employe();
                }
                return Employe;
            }

        }
        public UC_Employe()
        {
            InitializeComponent();
            db = new BdContext();
            txtRecherche.Enabled = false;
        }
        public void ActualiserDatagrid()
        {
            db = new BdContext();
            dgvEmploye.Rows.Clear();
            foreach(var E in db.Employes)
            {
                //ajout des lignes dans le datagridview
                dgvEmploye.Rows.Add(false, E.Id_employe, E.Nom_employe, E.Prenom_employe, E.Email_employe, E.Nature_employe,E.Departement_actuel);
            }
        }
        // Vérifier le nombre de lignes sélectionnées
        public string SelectVerif()
        {
            int NbreSelect = 0;
            for(int i=0;i<dgvEmploye.Rows.Count;i++)
            {
                if ((bool)dgvEmploye.Rows[i].Cells[0].Value==true)//si la ligne est selectionnée
                  {
                    NbreSelect++;
                  }
                        
            }
            if(NbreSelect==0)
            {
                return "Sélectonner l'employé que vous voulez modifier";
            }
            if (NbreSelect >1)
            {
                return "Sélectonner un seul Employé";
            }
            return null;
        }

        private void UC_Employe_Load(object sender, EventArgs e)
        {
            /* dgvEmploye.Rows.Add();
             dgvEmploye.Rows[0].Cells[1].Value = "SOSSOU";
             dgvEmploye.Rows[0].Cells[2].Value = "Samuel";
             dgvEmploye.Rows[0].Cells[3].Value = "sossous@gmail.com";
             dgvEmploye.Rows[0].Cells[4].Value = "Caissier";
             dgvEmploye.Rows[0].Cells[5].Value = "Finances";*/
            ActualiserDatagrid();
        }

        private void btnAjouterE_Click(object sender, EventArgs e)
        {
            FRM_Employe fRM_Employe = new FRM_Employe(this);
            fRM_Employe.ShowDialog();
        }

        private void txtRecherche_Enter(object sender, EventArgs e)
        {
            if (txtRecherche.Text == "Recherche")
            {
                txtRecherche.Text = "";
                txtRecherche.ForeColor = Color.Black;
            }
        }

        private void dgvEmploye_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //public int IdSelect;

        private void btnModifierE_Click(object sender, EventArgs e)
        {
            Forms.FRM_Employe ModifierEmploye = new Forms.FRM_Employe(this);
            if(SelectVerif()==null)
            {
                for(int i = 0; i < dgvEmploye.Rows.Count; i++)
                {
                    if ((bool)dgvEmploye.Rows[i].Cells[0].Value == true)//si la ligne est vraiment selectionnée afficher le formiulaire de modification avec les infos
                    {
                        ModifierEmploye.IdSelect = (int)dgvEmploye.Rows[i].Cells[1].Value;
                        ModifierEmploye.txtNom.Text = dgvEmploye.Rows[i].Cells[2].Value.ToString();
                        ModifierEmploye.txtPrenomE.Text = dgvEmploye.Rows[i].Cells[3].Value.ToString();
                        ModifierEmploye.txtEmailE.Text = dgvEmploye.Rows[i].Cells[4].Value.ToString();
                        ModifierEmploye.txtNatureE.Text = dgvEmploye.Rows[i].Cells[5].Value.ToString();
                        ModifierEmploye.txtDeptE.Text = dgvEmploye.Rows[i].Cells[6].Value.ToString();
                    }
                }
                ModifierEmploye.lblAjouterModifier.Text = "Modifier Employe";
                ModifierEmploye.btnActualiser.Visible = false;
                ModifierEmploye.ShowDialog();
            }
            else
            {
                MessageBox.Show(SelectVerif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            db = new BdContext();
            var listEmploye = db.Employes.ToList();// Liste des employes recherchés
            if(txtRecherche.Text!="")
            {
                switch(cbRecherche.Text)
                {
                    case "Nom":listEmploye = listEmploye.Where(n => n.Nom_employe.IndexOf(txtRecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        // StringComparison.CurrentCultureIgnoreCase== peut importe si la lettre écrite en premier est en majuscule ou en miniscule
                        //-1== existe dans la bdd
                        break;
                    case "Prenom":
                        listEmploye = listEmploye.Where(n => n.Prenom_employe.IndexOf(txtRecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Email":
                        listEmploye = listEmploye.Where(n => n.Email_employe.IndexOf(txtRecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Nature":
                        listEmploye = listEmploye.Where(n => n.Nature_employe.IndexOf(txtRecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Departement":
                        listEmploye = listEmploye.Where(n => n.Departement_actuel.IndexOf(txtRecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                }
            }
            //vider le datagridview
            dgvEmploye.Rows.Clear();
            // ajouter la liste au datagridview
            foreach( var L in listEmploye)
            {
                dgvEmploye.Rows.Add(false, L.Id_employe, L.Nom_employe, L.Prenom_employe, L.Email_employe, L.Nature_employe, L.Departement_actuel);

            }
        }

        private void btnSupprimerE_Click(object sender, EventArgs e)
        {
            AjoutEmploye SuppresionE = new AjoutEmploye();
            int select = 0;
            for (int i = 0; i < dgvEmploye.Rows.Count; i++)
            {
                if ((bool)dgvEmploye.Rows[i].Cells[0].Value == true)
                {
                    select++;//Pour voir le nombre de lignes sélectionnées
                }
            }
            if (select==0)
            {
                MessageBox.Show("Aucun Employé sélectionné", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult R= MessageBox.Show("Voulez-vous vraiment supprimer cet Employé?", "Suppresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(R==DialogResult.Yes)
                {
                    for (int i = 0; i < dgvEmploye.Rows.Count; i++)
                    {
                        if ((bool)dgvEmploye.Rows[i].Cells[0].Value == true)//Pour la suppresion
                        {
                            SuppresionE.SupprimerEmploye(int.Parse(dgvEmploye.Rows[i].Cells[1].Value.ToString()),
                                dgvEmploye.Rows[i].Cells[2].Value.ToString(),
                                dgvEmploye.Rows[i].Cells[3].Value.ToString(),
                                dgvEmploye.Rows[i].Cells[4].Value.ToString(),
                                dgvEmploye.Rows[i].Cells[5].Value.ToString(),
                                dgvEmploye.Rows[i].Cells[6].Value.ToString());
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

        private void cbRecherche_SelectedIndexChanged(object sender, EventArgs e)
        {
            //activer le textbox recherche lorsque un champ serait choisi
            txtRecherche.Enabled = true;
            // vider le textBox
            txtRecherche.Text = "";
        }

        private void btnImprimerE_Click(object sender, EventArgs e)
        {
            try
            {
                RAPPORTS.FRM_RAPPORT RapportEmployes = new RAPPORTS.FRM_RAPPORT();
                db = new BdContext();
                var listeEmployes = db.Employes.ToList();
                RapportEmployes.rpvnote.LocalReport.ReportEmbeddedResource = "Gestion_Note.RAPPORTS.RPT_EmployeS.rdlc";
                //Ajouter le datasource
                RapportEmployes.rpvnote.LocalReport.DataSources.Add(new ReportDataSource("DataSetEmploye", listeEmployes));//Liste des notes
                ReportParameter Date = new ReportParameter("Date", DateTime.Now.ToString());
                RapportEmployes.rpvnote.LocalReport.SetParameters(new ReportParameter[] { Date });
                RapportEmployes.rpvnote.RefreshReport();
                RapportEmployes.ShowDialog();// afficher le rapport
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
