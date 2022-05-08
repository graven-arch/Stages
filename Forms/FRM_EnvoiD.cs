using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Note.Forms
{
    public partial class FRM_EnvoiD : Form
    {
        public FRM_EnvoiD()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Publication_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxFichier.Text = "";
        }

        private void btnchoix_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string x = null;
            var items = x;
            items = openFileDialog1.FileName;
            textBoxFichier.Text = items;
                
                
        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxFichier.Text == "")
                {
                    MessageBox.Show("Choisir la demande à envoyer", "Choix", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txtDestinataire.Text != "" || txtDestinataire.Text == "Email")
                {
                    try
                    {
                        new MailAddress(txtDestinataire.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Email invalide!!");
                    }
                }
                if (textBoxFichier.Text != "")
                {
                    SmtpClient cl = new SmtpClient("smtp.gmail.com");
                    cl.Port=587;
                    cl.EnableSsl = true;
                    //cl.Timeout = 10000;
                    cl.DeliveryMethod = SmtpDeliveryMethod.Network;
                    cl.UseDefaultCredentials = false;
                    cl.Credentials = new NetworkCredential("benedictamansokiline@gmail.com", "SOS#google");
                    MailMessage Fichier = new MailMessage();
                    Fichier.To.Add(txtDestinataire.Text);
                    Fichier.From = new MailAddress("benedictamansokiline@gmail.com");
                    Fichier.Subject = lblObjet.Text;
                    //Fichier.Body = textBoxFichier.Text;
                    Attachment data = new Attachment(textBoxFichier.Text);
                    Fichier.Attachments.Add(data);
                    cl.Send(Fichier);
                    MessageBox.Show("Fichier envoyé");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void txtDestinataire_Enter(object sender, EventArgs e)
        {
            if (txtDestinataire.Text == "Email")
            {
                txtDestinataire.Text = "";
                txtDestinataire.ForeColor = Color.White;
            }
        }
    }
}
