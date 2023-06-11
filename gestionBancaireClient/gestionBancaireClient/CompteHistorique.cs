using gestionBancaireClient.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionBancaireClient
{
    public partial class CompteHistorique : Form
    {
        public CompteHistorique(string compteId)
        {
            InitializeComponent();
            idCmbBox.Text = compteId;
            this.setMovement(compteId);
        }

        private void CompteHistorique_Load(object sender, EventArgs e)
        {
            var responce = RestHelper.GetAll();
            foreach (var compte in responce)
            {
                idCmbBox.Items.Add(compte.Id.ToString());
            }
        }

        private void idCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = idCmbBox.Text.ToString();
            this.setMovement(id);
        }

        private void operationsBtn_Click(object sender, EventArgs e)
        {
            CompteOperation compteOperations = new CompteOperation();
            compteOperations.Show();
            this.Hide();
        }

        private void setMovement(string compteId)
        {
            var responce = RestHelper.GetAccountMovements();
            List<dynamic> movements = new List<dynamic>();
            foreach (var movement in responce)
            {
                if (movement.compte.Id.ToString() == compteId)
                {
                    var mov = new
                    {
                        id = movement.Id,
                        montant = movement.Montant,
                        dateMnt = movement.DateMnt,
                        nom = movement.compte.Nom
                    };
                    movements.Add(mov);
                }
            }
            movementGrid.DataSource = movements;
        }
    }
}
