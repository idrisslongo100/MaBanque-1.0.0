using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBanque_1._0._0.modules
{
     class Etudant
    {


        private int idtudiant;
        private string nom;
        private string prenom;
        private string matricule;
        private string age;

        private string getMatricule()
        {
            return this.matricule;
        }

        private string getAge()
        {
            return this.age;

        }

        public string getNom()
        {
            return this.nom;
        }
        public string getPrenom()
        {
            return this.prenom;
        }
   
    }
}
