using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppe1
{
    public class InfoUser
    {
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
    }
}
