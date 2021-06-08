﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ppe1
{
    public partial class AddUser : Form
    {
        InfoUser infoUser = new InfoUser();
        public AddUser()
        {
            InitializeComponent();
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int rbSelected = 0;
            if (rbAdmin.Checked == true)
                rbSelected = 2;
            if (rbOperateur.Checked == true)
                rbSelected = 1;
            if (rbInvite.Checked == true)
                rbSelected = 0;

            if (tbNom.Text == "" || tbPrenom.Text == "" || tbEmail.Text == "" || tbDpt.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Veuiller renseigner tout les champs");
            }
            else
            {
                MessageBox.Show(infoUser.Save("creation", tbNom.Text, tbPrenom.Text, tbPassword.Text, rbSelected, 0, tbEmail.Text, tbDpt.Text));
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
