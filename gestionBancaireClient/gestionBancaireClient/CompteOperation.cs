using System;
using System.Windows.Forms;

namespace gestionBancaireClient
{
    public partial class CompteOperation : Form
    {
        public CompteOperation()
        {
            InitializeComponent();
        }

        private void CompteOperation_Load(object sender, EventArgs e)
        {
            var responce = RestHelper.GetAll();
            foreach (var compte in responce)
            {
                idCmbBox.Items.Add(compte.Id.ToString());
            }
            debitRb.Checked = true;
        }

        private void idCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var responce = RestHelper.GetOne(idCmbBox.Text.ToString()).Nom;
            nomLbl.Text = responce.ToString();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {

            if (idCmbBox.Text != null && montantTxtBox.Text != null)
            {
                var montant = float.Parse(montantTxtBox.Text);
                if (virementRb.Checked)
                {
                    if (benefTxtBox.Text != null)
                    {
                        RestHelper.virementCompte(idCmbBox.Text.ToString(), benefTxtBox.Text.ToString(), montant);
                    }
                }
                else if (creditRb.Checked)
                {
                    RestHelper.creditCompte(idCmbBox.Text.ToString(), montant);
                }
                else
                {
                    RestHelper.debitCompte(idCmbBox.Text.ToString(), montant);
                }
                CompteHistorique compteHistorique = new CompteHistorique(idCmbBox.Text.ToString());
                compteHistorique.Show();
                this.Hide();
            }
        }

        private void virementRb_CheckedChanged(object sender, EventArgs e)
        {
            if (virementRb.Checked)
            {
                benefTxtBox.Enabled = true;
            }
            else
            {
                benefTxtBox.Enabled = false;
            }
        }
    }
}
