using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Dapper;

namespace ppe1
{
    public partial class FormAide : Form
    {
        InfoUser infoUser;
        public FormAide()
        {
            InitializeComponent();
        }

        public FormAide(InfoUser infoUserr)
        {
            InitializeComponent();
            this.infoUser = infoUserr;
        }
        

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string _connexionString = "server = localhost; user id = root;database=cppe";
            string RadioButtonType = "";
            MySqlConnection conn = new MySqlConnection(_connexionString);
            conn.Open();
            try
            {
                   if(rbDysfonctionnement.Checked == true)
                   {
                       RadioButtonType = "Dysfonctionnement";
                   }
                   else{
                       RadioButtonType = "Evolution";
                   }

                var procedure = "insertRemarque";
                var values = new { asNom = infoUser.Nom, asType = RadioButtonType, asCommentaire = rtbCommentaire.Text };
                conn.Query(procedure, values, commandType: CommandType.StoredProcedure);




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
