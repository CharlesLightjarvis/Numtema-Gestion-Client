using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numtema_Gestion_Client
{
    public partial class EditClient : Form
    {
        public EditClient()
        {
            InitializeComponent();
        }

        private void EditClient_Load(object sender, EventArgs e)
        {
            cmbClients.Items.Clear();
            NumtemaGestionClientEntities context = new NumtemaGestionClientEntities();
            cmbClients.Items.AddRange(context.TypeClient.ToArray());
            cmbClients.DisplayMember = "Nom";
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEffacerInfoPerso_Click(object sender, EventArgs e)
        {
            txtNom.Text = txtPrenom.Text = txtVille.Text = txtNumTelephone.Text = txtEmail.Text = "";
        }

        private void btnEffacerComplements_Click(object sender, EventArgs e)
        {
            txtDescription.Text = "";
            cmbClients.SelectedIndex = -1;
            dtpDateEnregistrement.Value = DateTime.Now;
        }

        public void FillFields(Client client)
        {
            if (client != null)
            {
                txtNom.Text = client.Nom;
                txtPrenom.Text = client.Prénom.ToString();
                txtVille.Text = client.Ville.ToString();
                cmbClients.SelectedItem = client.TypeClient;
                cmbClients.Text = client.TypeClient.Nom;
                txtNumTelephone.Text = client.Numéro_de_Téléphone.ToString();
                txtEmail.Text = client.EMail.ToString();
                txtDescription.Text = client.Description.ToString();
                dtpDateEnregistrement.Value = client.Date_d_enregistrement.Value;
            }
        }

        private void txtNumTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Empêche l'affichage du caractère entré s'il n'est pas un chiffre
            }
        }

        //validation Email
        private bool IsValidEmail(string email)
        {
            // Expression régulière pour valider l'email
            string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }

        private void viderChamp()
        {
            txtNom.Text = txtPrenom.Text = txtVille.Text = txtNumTelephone.Text = txtEmail.Text = txtDescription.Text = "";
            cmbClients.SelectedIndex = -1;
            dtpDateEnregistrement.Value = DateTime.Now;
        }

        private void btnMAJ_Click(object sender, EventArgs e)
        {
            string unserInput = txtEmail.Text.Trim();


            if (txtNom.Text == "" || txtPrenom.Text == ""
                || txtVille.Text == "" || txtNumTelephone.Text == ""
                || txtEmail.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("Tous les Champs de Saisie du Formulaire sont Obligatoires!!!", "Formulaire Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbClients.SelectedIndex == -1)
            {
                MessageBox.Show("Vous devez Choisir un Type de Client!!!", "Formulaire Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!IsValidEmail(unserInput))
            {
                MessageBox.Show("Veuillez Saisir une Adresse E-Mail Valide!!!", "Formulaire Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (NumtemaGestionClientEntities context = new NumtemaGestionClientEntities())
                {
                    if (context.Client.Where(x => x.EMail == txtEmail.Text)
                        .Count() > 0)
                    {
                        Client c = context.Client.Where(x=> x.EMail
                        ==  txtEmail.Text).FirstOrDefault();
                        c.Nom = txtNom.Text;
                        c.Prénom = txtPrenom.Text;
                        c.Ville = txtVille.Text;
                        c.Numéro_de_Téléphone = txtNumTelephone.Text;
                        c.EMail = txtEmail.Text;
                        c.Description = txtDescription.Text;
                        c.Date_d_enregistrement = dtpDateEnregistrement.Value;
                        c.ID_TypeClient = ((TypeClient)cmbClients.SelectedItem).ID_TypeClient;
                        context.SaveChanges();
                        MessageBox.Show("Le Client a été Modifié avec Succes!!!", "Modification Client", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.DialogResult = DialogResult.OK;
                        viderChamp();
                    }
                }
            }
        }

      
    }
}
