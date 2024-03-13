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
        /// s'inicialitza l'array productes a 10, nElem a 0, diners a 0 tmabé i botiga a null.
        /// </summary>
        public Cistella()
        {
            this.productes = new Producte[10];
            this.nElemTaula = 0;
            this.diners = 0;
            this.botiga = null;
        }

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
        public void ComprarProducte(Producte producte, int quantitat)
        {
           int posicio = 
            if (Buscar == 1)
            {
                productes[nElemTaula] = producte;
                this.quantitat[nElemTaula] = quantitat;
                nElemTaula++;
            }
            else
            {
                Console.WriteLine("No hi ha espai per a més productes");
            }
        }
        /// <summary>
        /// Retorna un numero diferent a -1 si ha trobat el producte, si no el troba retorna -1.
        /// </summary>
        /// <param name="productes"></param>
        /// <param name="nElem"></param>
        /// <param name="nom"></param>
        /// <returns></returns>
        public void Buscar(Producte[] productes, int nElem, string nom)
        {
            int index = -1;
            for (int i = 0; i < nElem; i++)
            {
                if (productes[i].Nom == nom)
                    index = i;
            }
            return index;
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
