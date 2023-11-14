using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R504_TP03_Factory_Commandes.Core.Commande
{
    public abstract class Commande
    {
        public abstract bool Valide();
        public abstract void Paye(double montant);
    }
}
