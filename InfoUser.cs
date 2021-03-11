using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ppe1
{
    public class InfoUser
    {
        string _connexionString = "server = localhost; user id = root;database=cppe";
        private int _id;
        private int _role;
        private string _nom;
        private string _prenom;
        private string _password;

        public int Id
        {
            get => _id;
            set
            {
                if (value > 0)
                {
                    _id = value;
                }
            }
        }
        public int Role
        {
            get => _role;
            set
            {
                if ((value > 0) && (value < 13))
                {
                    _role= value;
                }
            }
        }
        public string Nom
        {
            get => _nom;
            set
            {
                if(value is string)
                    _nom = value;
            }
        }
        public string Prenom
        {
            get => _prenom;
            set
            {
                if (value is string)
                    _prenom = value;
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                if (value is string)
                    _password = value;
            }
        }

        public string Save(string choix)
        {
            if (choix == "modification")
            {
                return "On va faire la modification de " + _nom + " " + _prenom;
            }
            else if (choix == "nouveau")
            {
                return "On va crée la personne " + _nom + " " + _prenom;
            }
            else
            {
                return "gros bug, bien joué le hackeur";
            }
            return "j'ai bien reussi à appeler " + _nom + " " + _prenom;
        }


        public string Save(string choix, string newNom, string newPrenom, string newPassword, int newRole, int hisId)
        {
            if (choix == "modification")
            {
                MySqlConnection conn = new MySqlConnection(_connexionString);
                try
                {
                    conn.Open();
                    string safePassword = SHA.petitsha(newPassword);
                    string sql = "";
                    string sqlGetPassword = "SELECT password FROM `user` WHERE id =" + hisId;
                    string bddPassword = "";
                    MySqlCommand cmd1 = new MySqlCommand(sqlGetPassword, conn);
                    MySqlDataReader rdr = cmd1.ExecuteReader();//Curseur

                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            bddPassword = rdr.GetString(0);
                        }
                    
                            if (bddPassword == newPassword)
                        {
                            sql = "UPDATE `user` SET `nom`= \"" + newNom + "\",`prenom`=\"" + newPrenom + "\",`role`=" + newRole + " WHERE id =" + hisId;
                        }
                        else
                        {
                            sql = "UPDATE `user` SET `nom`= \"" + newNom + "\",`prenom`=\"" + newPrenom + "\",`password`=\"" + safePassword + "\",`role`=" + newRole + " WHERE id =" + hisId;
                        }
                        rdr.Close();
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex);
                }

                return "La modification de " + _nom + " " + _prenom + " a bien été effectué ";
            }
            else if (choix == "nouveau")
            {
                return "On va crée la personne " + _nom + " " + _prenom;
            }
            else
            {
                return "gros bug, bien joué le hackeur";
            }
            return "j'ai bien reussi à appeler " + _nom + " " + _prenom;
        }
    }
}
