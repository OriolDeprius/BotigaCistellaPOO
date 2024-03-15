namespace BotigaCistellaPOO
{
    internal class Cistella
    {
        //Atributs
        private Botiga botiga;
        private DateTime data;
        private Producte[] productesCistella;
        private int nElemTaula;
        private double diners;
        //private string preu;

        //Propietats
        /// <summary>
        /// Te el get i set de l'atribut producte, 
        /// </summary>
        public Producte[] ProductesCistella
        {
            get { return productesCistella; }
            set
            {
                this.productesCistella = value;
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
        public Botiga Botiga
        {
            get { return botiga; }
            set { botiga = value; }
        }
        
        //Constructors
        /// <summary>
        /// s'inicialitza l'array productes a 10, nElem a 0, diners a 0 tmabé i botiga a null.
        /// </summary>
        public Cistella()
        {
            botiga = new Botiga();
            this.productesCistella = new Producte[10];
            this.nElemTaula = 0;
            this.diners = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="botiga"></param>
        /// <param name="producte"></param>
        /// <param name="quantitats"></param>
        /// <param name="diner"></param>

        public Cistella(Botiga botiga, DateTime data, int producte, int quantitats, double diner)
        {
            this.botiga = botiga;
            this.data = DateTime.Now;
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
            botiga.Productes[n].Nom = producte.Nom;
        }
        /// <summary>
        /// Retorna un numero diferent a -1 si ha trobat el producte, si no el troba retorna -1.
        /// </summary>
        /// <param name="productes"></param>
        /// <param name="nElem"></param>
        /// <param name="nom"></param>
        /// <returns></returns>
        public int Buscar(Producte[] productes, int nElem, string nom)
        {
            int index = -1;
            for (int i = 0; i < nElem; i++)
            {
                if (productes[i].Nom == nom)
                    index = i;
            }
            return index;
        }
        /// <summary>
        /// Ordena la cistella per ordreq alfabetic.
        /// </summary>
        /// <param name="Cistella"></param>
        /// <param name="nElemTaula"></param>
        public void OrdenarCistella(Producte[] productes, int nElemTaula)
        {
            for (int numVolta = 0; numVolta < nElemTaula - 1; numVolta++)
            {
                for (int i = 0; i < nElemTaula - 1; i++)
                {
                    if (productes[i].Nom.CompareTo(productes[i + 1].Nom) > 0)
                    {
                        Producte aux = productes[i];
                        productes[i] = productes[i + 1];
                        productes[i + 1] = aux;
                    }

                }
            }
        }
        /// <summary>
        /// Mostra el tiquet de compra amb la data de la compra, els productes, el preu unitari i el preu total.
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            return "Botiga: " + botiga + "\nData de la compra: " + Data + "\nProductes: " + productesCistella + "\nPreu Unitari: " + preu + "\nPreu Total: " + preutotal;
        }
        /// <summary>
        /// Retorna el preu total de la cistella amb iva.
        /// </summary>
        /// <returns></returns>
        public double CostTotal()
        {
            
        }
        /// <summary>
        /// Mostra el ticket de compra amb un string
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {
            string toStr = "";
            for (int i = 0; i < nElemTaula; i++)
            {
                toStr = toStr + productesCistella[i].Nom + ": " + productesCistella[i].Preu + "\t" + "|" + "\t" + "Preu sense iva: " + productesCistella[i].Preu_sense_iva + "Percentatge d'IVA: " + productesCistella[i].Iva + "\n";
            }
            return toStr;
        }
    }
}
