﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R504_TP03_Factory_Commandes.Core.Commande;

namespace R504_TP03_Factory_Commandes.Core.Client
{
    public abstract class Client
    {
        protected abstract Commande.Commande CreeCommande();

        public void NouvelleCommande()
        {
            Commande.Commande commande = CreeCommande();
            if (commande.Valide())
            {
                commande.Paye();
            }
        }
    }
}