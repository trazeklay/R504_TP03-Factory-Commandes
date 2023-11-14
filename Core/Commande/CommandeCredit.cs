using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R504_TP03_Factory_Commandes.Core.Commande
{
    public class CommandeCredit : Commande
    {
        public override bool Valide()
        {
            // Logic to validate the credit order
            return true;
        }

        public override void Paye()
        {
            // Logic to pay with credit
            Console.WriteLine("The credit order has been paid.");
        }
    }
}
