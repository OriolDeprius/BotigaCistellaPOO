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
        /// Constructor buit de producte amb iva per defecte a 21% i quantitat a 0.
        /// </summary>
        public Producte()
        {
            iva = 21;
            quantitat = 0;
        }
        /// <summary>
        /// Creem el constructor amb el nom i el preu inicial del producte.
        /// També aprofitem el constructor biut per asignarli el iva i la quantiat de productes.
        /// </summary>
        /// <param name="nom">parametre tipus string</param>
        /// <param name="preu_incial">parametre tipus double</param>
        public Producte(string nom, double preu_incial) : this()
        {
            this.Nom = nom;
            preu_sense_iva = preu_incial;
        }
        /// <summary>
        /// Creem el constructor complet amb nom, preu inicial, iva i quantatas.
        /// Aprofitem els constructors anteriors per asignarli el nom i el preu inicial.
        /// </summary>
        /// <param name="nom">parametre tipus string</param>
        /// <param name="preu_sense_iva">parametre tipus double</param>
        /// <param name="iva">parametre tipus double</param>
        /// <param name="quantitat">parametre tipus int</param>
        public Producte(string nom, double preu_sense_iva, double iva, int quantitat) : this(nom, preu_sense_iva)
        {
            this.iva = iva;
            this.quantitat = quantitat;
        }

        //propietats
        /// <summary>
        /// Creem la propietat Nom. Retorna el nom del producte i el modifica verificant que no estigui buit.
        /// </summary>
        public string Nom
        {
            get { return nom; }
            set
            {
                do
                {
                    if (value == "")
                    {
                        Console.Write("El nom no pot ser buit.\nTorna a introduiïr el nom --> ");
                        value = Console.ReadLine();
                    }
                    nom = value;
                }
                while (value == "");
            }
        }
        /// <summary>
        /// Creem la propietat Preu_sense_iva. Retorna el preu sense iva i el modifica verificant que no sigui menor que 0.
        /// </summary>
        public double Preu_sense_iva
        {
            get { return preu_sense_iva; }
            set
            {
                do
                {
                    if (value < 0)
                    {
                        Console.Write("El preu no pot ser menor que 0.\nTorna a introduiïr el preu --> ");
                        value = Convert.ToDouble(Console.ReadLine());
                    }
                    preu_sense_iva = value;
                }
                while (value < 0);
            }
        }
        /// <summary>
        /// Creem la propietat Iva. Retorna el iva i el modifica verificant que no sigui menor que 0.
        /// </summary>
        public double Iva
        {
            get { return iva; }
            set
            {
                do
                {
                    if (value < 0)
                    {
                        Console.Write("L'IVA no pot ser menor que 0.\nTorna a introduiïr-lo --> ");
                        value = Convert.ToDouble(Console.ReadLine());
                    }
                    iva = value;
                }
                while (value < 0);
            }
        }
        /// <summary>
        /// Creem la propietat Quantitat. Retorna la quantitat de productes i la modifica verificant que no sigui menor que 0.
        /// </summary>
        public int Quantitat
        {
            get { return quantitat; }
            set
            {
                do
                {
                    if (value < 0)
                    {
                        Console.Write("La quantitat no pot ser menor que 0.\nTorna a introduiïr-la --> ");
                        value = Convert.ToInt32(Console.ReadLine());
                    }
                    quantitat = value;
                }
                while (value < 0);
            }
        }

        //metodes publics
        /// <summary>
        /// Metode Preu
        /// </summary>
        /// <returns>El preu amb iva.</returns>
        public double Preu()
        {
            return preu_sense_iva + (preu_sense_iva * iva / 100);
        }
        /// <summary>
        /// Creem el metode ToString
        /// </summary>
        /// <returns>Retorna de forma amigable les dades del producte (nom, preu i quantitat)</returns>
        public override string ToString()
        {
            return "Nom: " + nom + "\nPreu: " + Preu() + "\nQuantitat: " + quantitat;
        }
    }
}