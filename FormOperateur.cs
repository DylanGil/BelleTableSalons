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
    public partial class FormOperateur : Form
    {
        string _connexionString = ConnectSQL.GiveLocalConnection();
        int niveau;
        int id;
        string nom;
        string prenom;
        InfoUser infoUser;
        public FormOperateur()
        {
            InitializeComponent();
        }
        public FormOperateur(InfoUser infoUserr)
        {
            InitializeComponent();
            infoUser = infoUserr;

            //dataGridSalons
            this.dtSalons.ColumnCount = 4; //5
            dtSalons.Columns[1].Width = 200;
            dtSalons.Columns[2].Width = 150;
            dtSalons.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd";
            dtSalons.Columns[0].Name = "Id";
            dtSalons.Columns[1].Name = "Libelle";
            dtSalons.Columns[2].Name = "Date";
            dtSalons.Columns[3].Name = "Lieu";
            //dtSalons.Columns[4].Name = "NbParticipants"; // A FAIRE
            checkSalons();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bonjour " + infoUser.Nom + " " + infoUser.Prenom + "\nVous êtes un : Opérateur\nVotre ID est : " + infoUser.Id);
        }
        private void checkSalons()
        {

            MySqlConnection conn = new MySqlConnection(_connexionString);
            try
            {
                dtSalons.Rows.Clear();
                conn.Open();
                string sql = "SELECT * FROM salons ORDER BY date ASC";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();//Curseur

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        dtSalons.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3]);
                    }
                }
                else
                {
                    MessageBox.Show("Il n'y a pas de salons de prévu");
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void dtSalons_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string idSalon = this.dtSalons.CurrentRow.Cells[0].Value.ToString();
                string libelleSalon = this.dtSalons.CurrentRow.Cells[1].Value.ToString();
                DateTime dateSalon = Convert.ToDateTime(this.dtSalons.CurrentRow.Cells[2].Value.ToString());
                string lieuSalon = this.dtSalons.CurrentRow.Cells[3].Value.ToString();
                AddSalon addSalon = new AddSalon(idSalon, libelleSalon, dateSalon, lieuSalon);
                addSalon.ShowDialog();
                checkSalons();
            }
        }
    }
}
