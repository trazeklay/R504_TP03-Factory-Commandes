using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R504_TP03_Factory_Commandes.Core.Commande
{
    public class CommandeComptant : Commande
    {
        public override bool Valide()
        {
            // Logic to validate the cash order
            return true;
        }

        public override void Paye()
        {
            // Logic to pay with cash
            Console.WriteLine("The cash order has been paid.");
        }
    }
}
