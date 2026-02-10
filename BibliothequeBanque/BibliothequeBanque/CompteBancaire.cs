namespace BibliothequeBanque
{

    /// <summary>
    /// Représente un compte bancaire
    /// </summary>
    public class CompteBancaire
    {
        private double _solde;
        private string _titulaire;
        private string _noCompte;

        /// <summary>
        /// Constructeur avec solde
        /// </summary>
        /// <param name="solde">solde plus grand ou égal a 0</param>
        /// <param name="titulaire">Nom du titulaire</param>
        /// <param name="noCompte">numéro du compte</param>
        public CompteBancaire(double solde, string titulaire, string noCompte)
        {
            Solde = solde;
            Titulaire = titulaire;
            NoCompte = noCompte;
        }

        /// <summary>
        /// Constructeur sans solde donc initialise à 0
        /// </summary>
        /// <param name="titulaire">nom du titulaire</param>
        /// <param name="noCompte">numéro du compte</param>
        public CompteBancaire(string titulaire, string noCompte)
        {
            Solde = 0;
            Titulaire = titulaire;
            NoCompte = noCompte;
        }

        /// <summary>
        /// Propriété pour le solde du compte
        /// </summary>
        public double Solde 
        { 
            get => _solde; 
            private set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("solde négatif");
                }
                _solde = value;
            } 
        }

        /// <summary>
        /// Propriété pour le titulaire du compte
        /// </summary>
        public string Titulaire 
        { 
           get => _titulaire;
           set => _titulaire = value;
        }

        /// <summary>
        /// Propriété pour le numéro du compte
        /// </summary>
        public string NoCompte 
        { 
            get => _noCompte; 
            set => _noCompte = value;
        }

        /// <summary>
        /// Méthode pour déposer de l'argent
        /// </summary>
        /// <param name="montant">Plus grand que 0</param>
        /// <returns>Le solde du compte</returns>
        /// <exception cref="ArgumentOutOfRangeException">Exception lance lorsque le montant à retirer est négatif</exception>
        public double Deposer(double montant)
        {
            //verif sanitaire
            if (montant < 0)
            {
                throw new ArgumentOutOfRangeException("Le montant déposé est négatif");
            }

            Solde += montant;
            return Solde;
        }

        /// <summary>
        /// Méthode pour retirer de l'argent d'un compte
        /// </summary>
        /// <param name="montant">Montant à retirer</param>
        /// <returns>Le solde</returns>
        /// <exception cref="ArgumentOutOfRangeException">Exception lance lorsque le montant à retirer est négatif</exception>
        /// <exception cref="InvalidOperationException">Exception lance lorsque le compte après le retrait tombe au négatif</exception>
        public double Retirer(double montant)
        {
            if (montant < 0)
                throw new ArgumentOutOfRangeException("Le montant à retirer est négatif");

            if(Solde - montant < 0)
                throw new InvalidOperationException("Le montant à retirer va mener à un solde négatif");

            Solde -= montant;
            return Solde;
        }

    }

}
