using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace ppe1
{
    public partial class AddParticipant : Form
    {
        string libelleSalon = "";
        string idSalon = "";
        string idParticipant = "";
        string _connexionString = ConnectSQL.GiveLocalConnection();
        public AddParticipant(string idSalonn)
        {
            InitializeComponent();
            idSalon = idSalonn;
        }
        public AddParticipant(string idParticipantt, string nom, string prenom, string departement, string email, string idSalonn, string libelleSalonn)
        {
            InitializeComponent();
            buttonPDF.Visible = true;
            pbBadge.Visible = true;
            addButton.Text = "Modifier";
            buttonSuppParticipant.Visible = true;
            idParticipant = idParticipantt;
            tbNom.Text = nom;
            tbPrenom.Text = prenom;
            tbDpt.Text = departement;
            tbEmail.Text = email;
            libelleSalon = libelleSalonn;
            idSalon = idSalonn;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            { 
                MySqlConnection conn = new MySqlConnection(_connexionString);
                conn.Open();
                string sql = "";
                string createOrEdit = "";
                if (addButton.Text == "Ajouter")
                {
                    sql = "INSERT INTO participants (nom, prenom, departement, email, idsalon) VALUES (\'" + tbNom.Text + "\',\'" + tbPrenom.Text + "\',\'" + tbDpt.Text + "\',\'" + tbEmail.Text + "\',\'" + idSalon + "\')";
                    createOrEdit = "Création";
                }
                else if (addButton.Text == "Modifier")
                {
                    sql = "UPDATE `participants` SET `nom` = '" + tbNom.Text + "', `prenom` = '" + tbPrenom.Text + "', `departement` = '" + tbDpt.Text + "', `email` = '" + tbEmail.Text + "', `idsalon` = '" + idSalon + "' WHERE `id` = " + idParticipant + ";";
                    createOrEdit = "Modification";

                }
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                //string createOrEdit = (addButton.Text == "Ajouter") ? "Création" : "Modification";
                MessageBox.Show(createOrEdit + " éffectué");
                this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonPDF_Click(object sender, EventArgs e)
        {
            CreatePDF.generatePDFAll(tbNom.Text, tbPrenom.Text, tbDpt.Text, tbEmail.Text, libelleSalon);
        }

        private void buttonSuppParticipant_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(_connexionString);
                conn.Open();
                string sql = "";
                sql = "DELETE FROM participants WHERE id = " + idParticipant;
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Suppresion éffectué");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
