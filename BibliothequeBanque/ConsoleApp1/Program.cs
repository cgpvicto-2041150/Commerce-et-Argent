using BibliothequeBanque;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompteBancaire compte = new CompteBancaire("Steve", "1234");
            double solde = compte.Solde;
            compte.Deposer(5);
            Console.WriteLine(compte.Solde);
        }
    }
}
