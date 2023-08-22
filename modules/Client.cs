using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBanque_1._0._0.modules
{
    public class Client
    {
        private int idCl;
        private string nom;
        private string prenom;
        private string telephone;
        private string adresse;
        private string genre;

        public Client()
        {

        }

        public int getIdClient()
        {
            return this.idCl;
        }

        public string getnom()
        {
            return this.nom;
        }

        public string getPrenom()
        {
            return this.prenom;
        }

        public string getTelphone()
        {
            return this.telephone;
        }

        public string getAdresse()
        {
            return this.adresse;
        }

        public string getGenre()
        {
            return this.genre;
        }





    }
}
