using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
            cmbRechercheClient.Items.Clear();
            NumtemaGestionClientEntities context = new NumtemaGestionClientEntities();
            cmbClients.Items.AddRange(context.TypeClient.ToArray());
            cmbClients.DisplayMember = "Nom";
            cmbRechercheClient.Items.AddRange(context.TypeClient.ToArray());
            cmbRechercheClient.DisplayMember = "Nom";
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

        //supprimer un client
        private void btnEffacer_Click(object sender, EventArgs e)
        {
            if (dgvListeClients.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Voulez Vous Vraiment Supprimer Ce Client ?",
                    "Attention", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    using (NumtemaGestionClientEntities context = new NumtemaGestionClientEntities())
                    {
                        foreach (DataGridViewRow row in dgvListeClients.SelectedRows)
                        {
                            string email = row.Cells[4].Value.ToString();
                            Client c = context.Client.Where(x => x.EMail == email)
                                .FirstOrDefault();
                            context.Client.Remove(c);
                            context.SaveChanges();
                            GestionClient_Load(sender, e);
                        }

                    }
                }


            }
        }

       

        /* private void selectionClient(DataGridView dgv, EventArgs e)
         {
             if (dgv.SelectedCells.Count > 0) // Vérifie s'il y a des cellules sélectionnées
             {
                 int pos = dgv.SelectedCells[0].RowIndex;
                 string email = dgv.Rows[pos].Cells[4].Value.ToString();

                 using (NumtemaGestionClientEntities context = new NumtemaGestionClientEntities())
                 {
                     Client c = context.Client.Where(x => x.EMail == email).FirstOrDefault();
                     if (c != null)
                     {
                         // Remplir les champs avec les valeurs du client sélectionné
                         txtNom.Text = c.Nom;
                         txtPrenom.Text = c.Prénom.ToString();
                         txtVille.Text = c.Ville.ToString();
                         cmbClients.SelectedItem = c.TypeClient;
                         cmbClients.Text = c.TypeClient.Nom;
                         txtNumTelephone.Text = c.Numéro_de_Téléphone.ToString();
                         txtEmail.Text = c.EMail.ToString();
                         txtDescription.Text = c.Description.ToString();
                         dtpDateEnregistrement.Value = c.Date_d_enregistrement.Value;
                     }
                 }
             }
         }


         private void btnEditer_Click(object sender, EventArgs e)
         {
             selectionClient(dgvListeClients, EventArgs.Empty);
         } */

        private void btnEditer_Click(object sender, EventArgs e)
        {
            if (dgvListeClients.SelectedCells.Count > 0)
            {
                int pos = dgvListeClients.SelectedCells[0].RowIndex;
                string email = dgvListeClients.Rows[pos].Cells[4].Value.ToString();

                using (NumtemaGestionClientEntities context = new NumtemaGestionClientEntities())
                {
                    Client clientToEdit = context.Client.FirstOrDefault(x => x.EMail == email);
                    if (clientToEdit != null)
                    {
                        EditClient editForm = new EditClient(); // Création d'une instance du formulaire enfant
                        editForm.FillFields(clientToEdit); // Appel d'une méthode dans le formulaire enfant pour remplir les champs
                         
                        DialogResult result = editForm.ShowDialog();// Affichage du formulaire enfant

                        if (result == DialogResult.OK) // Vérifie si le formulaire enfant a été fermé avec OK
                        {
                            GestionClient_Load(sender, e);
                        }
                    }

                }
            }
        }

        //voir les details d'un client
        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (dgvListeClients.SelectedCells.Count > 0)
            {
                int pos = dgvListeClients.SelectedCells[0].RowIndex;
                string email = dgvListeClients.Rows[pos].Cells[4].Value.ToString();

                using (NumtemaGestionClientEntities context = new NumtemaGestionClientEntities())
                {
                    Client clientToEdit = context.Client.FirstOrDefault(x => x.EMail == email);
                    if (clientToEdit != null)
                    {
                        DetailClient detailForm = new DetailClient(); // Création d'une instance du formulaire enfant
                        detailForm.FillFields(clientToEdit); // Appel d'une méthode dans le formulaire enfant pour remplir les champs
                        detailForm.ShowDialog();
                    }

                }
            }

        }


        //fermer le formulaire enfant gestion client
        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (cmbRechercheClient.SelectedIndex != -1)
            {
                TypeClient t = (TypeClient)cmbRechercheClient.SelectedItem;
                using (NumtemaGestionClientEntities context = new NumtemaGestionClientEntities())
                {
                    dgvListeClients.DataSource = context.Client
                                    .Where(x => x.TypeClient.Nom == t.Nom)
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
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            DateTime t = dtpRechercheClient.Value.Date;
            using (NumtemaGestionClientEntities context = new NumtemaGestionClientEntities())
            {
                var matchingClients = context.Client
                                .Where(x => DbFunctions.TruncateTime(x.Date_d_enregistrement) == t)
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
                if (matchingClients.Count > 0)
                {
                    dgvListeClients.DataSource = matchingClients;
                }
                else
                {
                    MessageBox.Show("Aucun client ne correspond à cette Date.", "Recherche Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Effacez éventuellement le DataGridView pour montrer qu'aucun résultat n'a été trouvé
                }
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            string nom = txtRechercheNom.Text.Trim().ToLower();
            using (NumtemaGestionClientEntities context = new NumtemaGestionClientEntities())
            {
                var matchingClients = context.Client
                                .Where(x => x.Nom.ToLower() == nom)
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
                if (matchingClients.Count > 0)
                {
                    dgvListeClients.DataSource = matchingClients;
                }
                else
                {
                    MessageBox.Show("Aucun client ne correspond à ce nom. Veuillez s'il Vous plait verifier le Nom exact!", "Recherche Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Effacez éventuellement le DataGridView pour montrer qu'aucun résultat n'a été trouvé
                }
            }
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            NumtemaGestionClientEntities context = new NumtemaGestionClientEntities();
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
    }
}
