using R504_TP03_Factory_Commandes.Core.Client;

Client client;
client = new ClientComptant();
client.NouvelleCommande(2000.0);
client.NouvelleCommande(10000.0);
client = new ClientCredit();
client.NouvelleCommande(2000.0);
client.NouvelleCommande(10000.0);