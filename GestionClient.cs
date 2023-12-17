using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numtema_Gestion_Client
{
    public partial class GestionClient : Form
    {
        public GestionClient()
        {
            InitializeComponent();
        }

        //Chargement de la Page
        private void GestionClient_Load(object sender, EventArgs e)
        {
            cmbClients.Items.Clear();
            NumtemaGestionClientEntities context = new NumtemaGestionClientEntities();
            cmbClients.Items.AddRange(context.TypeClient.ToArray());
            cmbClients.DisplayMember = "Nom";
            dgvListeClients.DataSource = context.Client
                .Select(x => new
                {
                    Nom = x.Nom,
                    Prénom = x.Prénom,
                    Ville = x.Ville,
                    Num_Telephone = x.Numéro_de_Téléphone,
                    E_Mail = x.EMail,
                    Date_Enregistrement = x.Date_d_enregistrement,
                    Nombre_Relances = x.Nombre_de_Relance,
                    Type_Client = context.TypeClient
                          .Where(tc => tc.ID_TypeClient == x.ID_TypeClient)
                          .Select(tc => tc.Nom)
                          .FirstOrDefault(),
                    Description = x.Description
                })
                .ToList();
        }

        //Effacer juste les données Personnelles
        private void btnEffacerInfoPerso_Click(object sender, EventArgs e)
        {
            txtNom.Text = txtPrenom.Text = txtVille.Text = txtNumTelephone.Text = txtEmail.Text = "";
        }

        //Effacer juste les données complémentaires
        private void btnEffacerComplements_Click(object sender, EventArgs e)
        {
            txtDescription.Text = "";
            cmbClients.SelectedIndex = -1;
            dtpDateEnregistrement.Value = DateTime.Now;
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


        private void btnAjout_Click(object sender, EventArgs e)
        {
            string unserInput = txtEmail.Text.Trim();


            if(txtNom.Text == "" || txtPrenom.Text == "" 
                || txtVille.Text == "" || txtNumTelephone.Text == "" 
                || txtEmail.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("Tous les Champs de Saisie du Formulaire sont Obligatoires!!!", "Formulaire Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(cmbClients.SelectedIndex == -1)
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
                        MessageBox.Show("Cette Adresse E-Mail existe déja!!!", "Enregistrement Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Client c = new Client();
                        c.Nom = txtNom.Text;
                        c.Prénom = txtPrenom.Text;
                        c.Ville = txtVille.Text;
                        c.Numéro_de_Téléphone = txtNumTelephone.Text;
                        c.EMail = txtEmail.Text;
                        c.Description = txtDescription.Text;
                        c.Nombre_de_Relance = 0;
                        c.Date_d_enregistrement = dtpDateEnregistrement.Value;
                        c.ID_TypeClient = ((TypeClient)cmbClients.SelectedItem).ID_TypeClient;
                        context.Client.Add(c);
                        context.SaveChanges();
                        MessageBox.Show("Le Client a été ajouté avec Succes!!!", "Enregistrement Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        viderChamp();
                        GestionClient_Load(sender, e);
                    }
                   
                }    
            }

        }

        //empecher linsertion dun caractere dans le champ telephone
        private void txtNumTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Empêche l'affichage du caractère entré s'il n'est pas un chiffre
            }
        }
    }
}
