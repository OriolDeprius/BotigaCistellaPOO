namespace BotigaCistellaPOO
{
    internal class Cistella
    {
        //Atributs
        private string botiga;
        private DateTime data;
        private Producte[] productes;
        private int[] quantitat;
        private int nElemTaula;
        private double diners;

        //Propietats
        /// <summary>
        /// Te el get i set de l'atribut producte, 
        /// </summary>
        public Producte[] Productes
        {
            get { return productes; }
            set
            {
                this.productes = value;
            }
        }
        /// <summary>
        /// Te nomes el get de l'atribut nElemTaula
        /// </summary>
        public int NElemTaula
        {
            get { return nElemTaula; }
        }
        /// <summary>
        /// Atribut diners te una propietat amb un get i un set
        /// </summary>
        public double Diners
        {
            get { return diners; }
            set { diners = value; }
        }
        /// <summary>
        /// te un get i set de l'atribut data
        /// </summary>
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        //Constructors
        /// <summary>
        /// inicialitzem l'array productes a 10, nElem a 0, diners a 0 tmabé i botiga a null.
        /// </summary>
        public Cistella()
        {
            this.productes = new Producte[10];
            this.nElemTaula = 0;
            this.diners = 0;
            this.botiga = null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="botiga"></param>
        /// <param name="productes"></param>
        /// <param name="quantitat"></param>
        /// <param name="diners"></param>
        public Cistella(string botiga, int producte, int quantitats, double diner)
        {
            Producte[] productes = new Producte[producte];
            //ens hem d’assegurar que tenen la mateixa mida i
            //assignar - li aquesta mida a nElements, hem de comprovar que tenim suficients diners per
            //aquesta cistella.).
            int[] quantitat = new int[quantitats];
            this.diners = diner;
        }


        //Mètodes
        public double ComprarProducte(Producte producte, int quantitat)
        {
            double preu = 0;
            if (producte.Quantitat >= quantitat)
            {
                preu = producte.Preu_sense_iva * (1 + producte.Iva / 100) * quantitat;
                if (diners >= preu)
                {
                    diners -= preu;
                    producte.Quantitat -= quantitat;
                    return preu;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -2;
            }
        }
        static int Buscar(string[] productesCistella, int nElemCistella, string nom)
        {
            int index = -1;
            for (int i = 0; i < nElemCistella; i++)
            {
                if (productesCistella[i] == nom)
                    index = i;
            }
            return index;
        }
        public void ComprarProducte(Producte producte, int quantitat, double preu)
        {

        }

    }


}
