using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R504_TP03_Factory_Commandes.Core.Commande;

namespace R504_TP03_Factory_Commandes.Core.Client
{
    public class ClientComptant : Client
    {
        protected override Commande.Commande CreeCommande()
        {
            return new CommandeComptant();
        }
    }
}
