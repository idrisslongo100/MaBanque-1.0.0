using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBanque_1._0._0.modules
{
    public class Transaction
    {
        private int idtrans;
        private string nom;
        private string prenom;
        private string date;
        private string typetrans;
        private string libelle;
        private int montant;
        private int idClient;

        public Transaction(string nom, string prenom, string date,string typeTransaction, string libelle,int montant , Client client)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.date = date;
            this.typetrans = typeTransaction;
            this.libelle = libelle;
            this.montant = montant;
            this.idClient = client.getIdClient();

        }


    }
}
