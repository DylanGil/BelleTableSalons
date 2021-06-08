﻿using System;
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
    public partial class AddSalon : Form
    {
        string addOrEdit = "";
        string idSalon = "";
        string libelleSalon = "";
        string _connexionString = ConnectSQL.GiveLocalConnection();
        public AddSalon()
        {
            //creation d'un salon
            InitializeComponent();
            addOrEdit = "add";
            tabPages.Visible = false;
            addParticipantButton.Visible = false;
        }

        public AddSalon(string idSalonn, string libelleSalonn, DateTime dateSalon, string lieuSalon)
        {
            //modification d'un salon
            InitializeComponent();
            addButton.Text = "Modifier";
            addOrEdit = "edit";
            idSalon = idSalonn;
            libelleSalon = libelleSalonn;
            tbLibelle.Text = libelleSalon;
            tbLieu.Text = lieuSalon;
            tbDateSalon.Value = dateSalon;

            this.dtParticipants.ColumnCount = 5;
            dtParticipants.Columns[1].Width = 200;
            dtParticipants.Columns[2].Width = 150;
            dtParticipants.Columns[0].Name = "Id";
            dtParticipants.Columns[1].Name = "Nom";
            dtParticipants.Columns[2].Name = "Prenom";
            dtParticipants.Columns[3].Name = "Departement";
            dtParticipants.Columns[4].Name = "Email";

            checkParticipants();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(_connexionString);
            if(tbLibelle.Text=="" || tbLieu.Text == "")
            {
                MessageBox.Show("Veuiller renseigner tout les champs");
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql = "";
                    if (addOrEdit == "add")
                    {
                        sql = "INSERT INTO `salons` (`libelle`, `date`, `lieu`) VALUES ('" + tbLibelle.Text + "', '" + tbDateSalon.Value.ToString("yyyy-MM-dd") + "', '" + tbLieu.Text + "');";
                    }
                    else if(addOrEdit == "edit")
                    {
                        sql = "UPDATE `salons` SET `libelle` = '" + tbLibelle.Text + "', `date` = '" + tbDateSalon.Value.ToString("yyyy-MM-dd") + "', `lieu` = '" + tbLieu.Text + "' WHERE `id` = " + idSalon +";";
                    
                    }
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Création/Modification éffectué");
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex);
                }

                this.DialogResult = DialogResult.OK;
            }
        }

        private void checkParticipants()
        {
            MySqlConnection conn = new MySqlConnection(_connexionString);
            try
            {
                conn.Open();
                string sql = "SELECT * FROM participants WHERE idsalon = " + idSalon + " ORDER BY nom ASC";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();//Curseur

                if (rdr.HasRows)
                {
                    dtParticipants.Rows.Clear();
                    while (rdr.Read())
                    {
                        dtParticipants.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4]);
                    }
                }
                else
                {
                    MessageBox.Show("Il n'y a pas de participants à ce salon");
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dtParticipants_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

            if (e.RowIndex > -1)
            {
                string idParticipant = this.dtParticipants.CurrentRow.Cells[0].Value.ToString();
                string nom = this.dtParticipants.CurrentRow.Cells[1].Value.ToString();
                string prenom = this.dtParticipants.CurrentRow.Cells[2].Value.ToString();
                string departement = this.dtParticipants.CurrentRow.Cells[3].Value.ToString();
                string email = this.dtParticipants.CurrentRow.Cells[4].Value.ToString();

                AddParticipant unParticipant = new AddParticipant(idParticipant, nom, prenom, departement, email, idSalon, libelleSalon);
                unParticipant.ShowDialog();
                checkParticipants();
            }
        }

        private void addParticipantButton_Click(object sender, EventArgs e)
        {
            AddParticipant unParticipant = new AddParticipant(idSalon);
            unParticipant.ShowDialog();
            checkParticipants();
        }
    }
}
