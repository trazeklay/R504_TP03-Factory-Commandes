using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R504_TP03_Factory_Commandes.Core.Client
{
    public class ClientCredit : Client
    {
        protected override Commande.Commande CreeCommande()
        {
            return new Commande.CommandeCredit();
        }
    }
}
