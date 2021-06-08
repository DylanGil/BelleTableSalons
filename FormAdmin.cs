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
using Dapper;

namespace ppe1
{
    public partial class FormAdmin : Form
    {
        string _connexionString = ConnectSQL.GiveLocalConnection();
       /* int role;
        int id;
        string nom;
        string prenom;*/
        InfoUser infoUser;
        public FormAdmin()
        {
            InitializeComponent();
        }
        public FormAdmin(InfoUser infoUserr)
        {
            InitializeComponent();
            infoUser = infoUserr;
            //dataGridLog
            this.dtLog.ColumnCount = 6;
            dtLog.Columns[4].Width = 150;
            dtLog.Columns[5].Width = 150;
            dtLog.Columns[0].Name = "IDLog";
            dtLog.Columns[1].Name = "Role";
            dtLog.Columns[2].Name = "Nom";
            dtLog.Columns[3].Name = "Prenom";
            dtLog.Columns[4].Name = "DateDebut";
            dtLog.Columns[5].Name = "DateFin";

            //dataGridFailConnection
            this.dgEchec.ColumnCount = 3;
            dgEchec.Columns[2].Width = 150;
            dgEchec.Columns[0].Name = "IDechec";
            dgEchec.Columns[1].Name = "Nom";
            dgEchec.Columns[2].Name = "Date";

            //dataGridRemarques
            this.dgRemarques.ColumnCount = 4;
            dgRemarques.Columns[0].Width = 150;
            dgRemarques.Columns[2].Width = 250;
            dgRemarques.Columns[3].Width = 150;
            dgRemarques.Columns[0].Name = "Demandeurs";
            dgRemarques.Columns[1].Name = "Type";
            dgRemarques.Columns[2].Name = "Commentaire";
            dgRemarques.Columns[3].Name = "Date";

            //dataGridSalons
            this.dtSalons.ColumnCount = 4;
            dtSalons.Columns[1].Width = 200;
            dtSalons.Columns[2].Width = 150;
            dtSalons.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd";
            dtSalons.Columns[0].Name = "Id";
            dtSalons.Columns[1].Name = "Libelle";
            dtSalons.Columns[2].Name = "Date";
            dtSalons.Columns[3].Name = "Lieu";

            checkUser();
            checkLog();
            checkEchec();
            checkRemarques();
            checkSalons();
            //checkLogGraph();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bonjour " + infoUser.Nom + " " + infoUser.Prenom + "\nVous êtes un : Admin\nVotre ID est : " + infoUser.Id);
        }

        private void checkUser()
        {
            MySqlConnection conn = new MySqlConnection(_connexionString);
            try
            {
                conn.Open();
                string sql = "SELECT * FROM user ORDER BY role DESC";
                var ListConnexion = new List<InfoUser>();
                ListConnexion = conn.Query<InfoUser>(sql).ToList();
                dtUser.DataSource = ListConnexion;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void checkLog()
        {
            MySqlConnection conn = new MySqlConnection(_connexionString);
            try
            {
                conn.Open();
                string sql = "SELECT * FROM log ORDER BY datedebut DESC";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();//Curseur

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        dtLog.Rows.Add(rdr[0], rdr[4], rdr[2], rdr[3], rdr[5], rdr[6]);
                    }
                }
                else
                {
                    MessageBox.Show("Les logs sont vides");
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void checkEchec()
        {
            MySqlConnection conn = new MySqlConnection(_connexionString);
            try
            {
                conn.Open();
                string sql = "SELECT * FROM echec ORDER BY date DESC";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();//Curseur

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        dgEchec.Rows.Add(rdr[0], rdr[1], rdr[3]);
                    }
                }
                else
                {
                    MessageBox.Show("Les logs d'echec sont vides");
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void checkRemarques()
        {
            MySqlConnection conn = new MySqlConnection(_connexionString);
            try
            {
                conn.Open();
                string sql = "SELECT * FROM remarques ORDER BY date DESC";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();//Curseur

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        dgRemarques.Rows.Add(rdr[4], rdr[1], rdr[3], rdr[2]);
                    }
                }
                else
                {
                    MessageBox.Show("Il n'y a pas de remarques");
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        /* private void checkLogGraph()
         {
             MySqlConnection conn = new MySqlConnection(_connexionString);
             try
             {
                 conn.Open();
                 string sqlTestt = "SELECT COUNT(*) FROM `log` WHERE datedebut >= DATE_SUB(DATE(NOW()), INTERVAL 1 DAY)";
                 MySqlCommand cmd = new MySqlCommand(sqlTestt, conn);
                 Int32 count = Convert.ToInt32(cmd.ExecuteScalar());

                 string today = DateTime.Now.ToString("yyyy/MM/dd");
                 string jMoinsUn = DateTime.Now.AddDays(-1).ToString("yyyy/MM/dd");
                 string jMoinsDeux = DateTime.Now.AddDays(-2).ToString("yyyy/MM/dd");
                 string jMoinsTrois = DateTime.Now.AddDays(-3).ToString("yyyy/MM/dd");
                 string jMoinsQuatre = DateTime.Now.AddDays(-4).ToString("yyyy/MM/dd");
                 this.chart1.Series["connexion"].Points.AddXY(today, count);
                 this.chart1.Series["connexion"].Points.AddXY(jMoinsUn, 20);
                 this.chart1.Series["connexion"].Points.AddXY(jMoinsDeux, 50);
                 this.chart1.Series["connexion"].Points.AddXY(jMoinsTrois, 55);
                 this.chart1.Series["connexion"].Points.AddXY(jMoinsQuatre, 27);
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString());
             }
         }*/

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ShowDialog();
            checkUser();
        }

        private void buttonAddSalon_Click(object sender, EventArgs e)
        {
            AddSalon addSalon = new AddSalon();
            addSalon.ShowDialog();
            checkSalons();

        }
        private void dtUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //  string nom = dtLog.CurrentRow.Cells[2].Value.ToString();

            foreach (DataGridViewRow row in dtUser.SelectedRows)
            {
                InfoUser clickedUser = row.DataBoundItem as InfoUser;
                ChangeUser changeUser = new ChangeUser(clickedUser);
                changeUser.ShowDialog();
                checkUser();
            }
        }

        private void dtSalons_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
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
