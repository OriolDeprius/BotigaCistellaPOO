namespace BotigaCistellaPOO
{
    internal class Cistella
    {
        //Atributs
        private string botiga;
        private DateTime data;
        private int[] producte;
        private int[] quantitat;
        private int nElemTaula;
        private double diners;

        //Propietats
        /// <summary>
        /// Te el get i set de l'atribut producte, 
        /// </summary>
        public string Productes
        {
            get { return producte; }
            set { producte = value; }
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
            this.producte = new int[10];
            this.nElemTaula= 0;
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
        public Cistella(string botiga, int productes, int quantitat, double diners)
        {

        }
        //Mètodes
        public double ComprarProducte (Producte producte, int quantitat)
        {

        }
    }
}
