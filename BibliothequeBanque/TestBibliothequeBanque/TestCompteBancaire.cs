using BibliothequeBanque;

namespace TestBibliothequeBanque
{
    [TestClass]
    public sealed class TestCompteBancaire
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arranger
            CompteBancaire compte = new CompteBancaire();
            double montant = 500.0d;
            //Agir sur les données
            double solde = compte.Deposer(montant);
            //Affirmer que ...
            Assert.AreEqual(montant, solde, $"le solde n'est pas de {montant} après le dépôt");
            Assert.AreEqual(montant, compte.Solde, $"le solde n'est pas de {montant} après le dépôt");
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arranger
            CompteBancaire compte = new CompteBancaire();
            double montant = 500.0d;
            //Agir sur les données
            double solde = compte.Deposer(montant);
            //Affirmer que ...
            Assert.AreEqual(montant, solde, $"le solde n'est pas de {montant} après le dépôt");
            Assert.AreEqual(montant, compte.Solde, $"le solde n'est pas de {montant} après le dépôt");
        }
    }
}
