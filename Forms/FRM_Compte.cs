using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Note.Forms
{
    public partial class FRM_Compte : Form
    {
        BdContext db = new BdContext();
        public FRM_Compte()
        {
            InitializeComponent();
            db = new BdContext();
        }
        public int IdSelect;
        private void btnActualiser_Click(object sender, EventArgs e)
        {
            /*ClassesAnterieures.ModifierCompte Compte = new ClassesAnterieures.ModifierCompte();
            UC_Connexion Uc_Connexion = new UC_Connexion();
            DialogResult R = MessageBox.Show("Voulez vous vraiment modifier Votre Compte?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (R == DialogResult.Yes)
            {
                Compte.Modifiercompte(IdSelect,txtMotdepasse.Text);
                
                MessageBox.Show("Compte modifié avec succès", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Modification annulée", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            SqlConnection con = new SqlConnection();
            SqlCommand com = new SqlCommand();
            //Classes.Compte C = new Classes.Compte();
            con.ConnectionString =" Data Source = DESKTOP - 9LUM4BH\SQLEXPRESS; Initial Catalog = GestionNote; Integrated Security = SSPI" providerName="System.Data.SqlClient" name="BdConnection"";
            com.CommandText = " update table Compte set password = '" + txtMotdepasse + "'  where id=" +  + "";
            com.Connection = con;
            con.Open();
            com.ExecuteReader();
            MessageBox.Show("Modification reussi", "ooooooo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();*/
        }

        private void FRM_Compte_Load(object sender, EventArgs e)
        {

        }
    }
}
