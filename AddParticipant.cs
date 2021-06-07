using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppe1
{
    public partial class AddParticipant : Form
    {
        public AddParticipant()
        {
            InitializeComponent();
        }
        public AddParticipant(string nom, string prenom, string departement, string email)
        {
            InitializeComponent();
            tbNom.Text = nom;
            tbPrenom.Text = prenom;
            tbDpt.Text = departement;
            tbEmail.Text = email;
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void buttonPDF_Click(object sender, EventArgs e)
        {
            CreatePDF.generatePDFAll(tbNom.Text, tbPrenom.Text, tbDpt.Text, tbEmail.Text);
        }
    }
}
