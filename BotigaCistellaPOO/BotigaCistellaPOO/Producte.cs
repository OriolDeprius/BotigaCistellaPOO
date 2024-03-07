namespace BotigaCistellaPOO
{
    internal class Producte
    {
        //atributs
        private string nom; //nom del producte
        private double preu_sense_iva; //preu inicial
        private double iva; //percentatge d'iva
        private int quantitat; //quantitat de productes en stock

        //constructors
        /// <summary>
        /// Creem el cosntructor buit amb l'iva per defecte de 21% i la quantitat a 0.
        /// </summary>
        /// <param name="iva"></param>
        /// <param name="quantitat"></param>
        public Producte()
        {
            iva = 21;
            quantitat = 0;
        }
        /// <summary>
        /// Creem el constructor amb el nom i el preu inicial del producte.
        /// També aprofitem el constructor biut per asignarli el iva i la quantiat de productes.
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="preu_incial"></param>
        public Producte(string nom, double preu_incial) : this()
        {
            this.nom = nom;
            preu_sense_iva = preu_incial;
        }
        /// <summary>
        /// Creem el constructor complet amb nom, preu inicial, iva i quantatas.
        /// Aprofitem els constructors anteriors per asignarli el nom i el preu inicial.
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="preu_sense_iva"></param>
        /// <param name="iva"></param>
        /// <param name="quantitat"></param>
        public Producte(string nom, double preu_sense_iva, double iva, int quantitat) : this(nom, preu_sense_iva)
        {
            this.iva = iva;
            this.quantitat = quantitat;
        }

        //propietats
        /// <summary>
        /// Creem les propietats per cada un dels atributs.
        /// Comprovem que el nom no estigui buit i que el preu, l'iva i la quatitat siguin positius.
        /// </summary>
        public string Nom
        {
            get { return nom; }
            set
            {
                do
                {
                    nom = value;
                }
                while (value == "");
            }
        }
        public double Preu_sense_iva
        {
            get { return preu_sense_iva; }
            set
            {
                do
                {
                    preu_sense_iva = value;
                }
                while (value < 0);
            }
        }
        public double Iva
        {
            get { return iva; }
            set
            {
                do
                {
                    iva = value;
                }
                while (value < 0);
            }
        }
        public int Quantitat
        {
            get { return quantitat; }
            set
            {
                do
                {
                    quantitat = value;
                }
                while (value < 0);
            }
        }

        //metodes publics
        public double Preu()
        {
            return preu_sense_iva + (preu_sense_iva * iva / 100);
        }
        public string ToString()
        {
            return "Nom: " + nom + "\nPreu: " + Preu() + "\nQuantitat: " + quantitat;
        }
    }
}
