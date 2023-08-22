using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBanque_1._0._0.modules
{
    public class Compte
    {
        private int idCompte {
            set;get;
        }

        private string nameCompte { set;get; }

        private string descriptionCompte { set;get; }

        private int compteId { set;get;}

        private int compteType { set;get; }

        private int solde { set; get;
        }

        private Client Client;

        public Compte(Client client)
        {
            this.compteId = 0;
            this.compteType = 0;
            this.solde = 0;
            this.Client = client;
        }



    }
}
