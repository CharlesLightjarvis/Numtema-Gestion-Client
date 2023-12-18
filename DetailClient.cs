using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numtema_Gestion_Client
{
    public partial class DetailClient : Form
    {
        public DetailClient()
        {
            InitializeComponent();
        }

        public void FillFields(Client client)
        {
            if (client != null)
            {
                lblNom.Text = client.Nom.ToString();
                lblPrenom.Text = client.Prénom.ToString();
                lblVille.Text = client.Ville.ToString();
                lblTypeClient.Text = client.TypeClient.Nom.ToString();
                lblNumTelephone.Text = client.Numéro_de_Téléphone.ToString();
                lblEmail.Text = client.EMail.ToString();
                txtDescription.Text = client.Description.ToString();
                lblDateEnregistrement.Text = client.Date_d_enregistrement.Value.ToString();
            }
        }

      
    }
}
