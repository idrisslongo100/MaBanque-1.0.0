using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBanque_1._0._0.modules
{
    public interface InterfaceTransaction
    {
        public List<Transaction> Listetransaction();
        public string TransactionEtudiant(string matricule);
    }
}
