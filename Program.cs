using R504_TP03_Factory_Commandes.Core.Client;

Console.WriteLine("Please choose the type of command:");
Console.WriteLine("1: Cash Command");
Console.WriteLine("2: Credit Command");

string choice = Console.ReadLine();
Client client;

switch (choice)
{
    case "1":
        client = new ClientComptant();
        break;
    case "2":
        client = new ClientCredit();
        break;
    default:
        Console.WriteLine("Invalid choice.");
        return;
}

client.NouvelleCommande();