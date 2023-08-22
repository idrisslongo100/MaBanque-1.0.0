
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaBanque_1;
using MaBanque_1._0._0.modules;

namespace MaBanque_1._0._0
{
    internal class TransactionServeur : MarshalByRefObject, InterfaceTransaction
    {
        public List<modules.Transaction> Listetransaction()
        {
            throw new NotImplementedException();
        }

        public string TransactionEtudiant(string matricule)
        {
            string message = "hello word";
            return message;
            
        }
    }
}
