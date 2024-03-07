namespace BotigaCistellaPOO
{
    internal class Botiga
    {
        //atributs
        private string nomBotiga;//nom de la botiga
        private Producte[] productes;//array de productes
        private int nElem;//número d'elements de l'array

        //constructors
        /// <summary>
        /// Constructor buit de la botiga amb array de productes inicialitzat per defecte a 10
        /// i el número d'elements a 0.
        /// </summary>
        public Botiga()
        {
            productes = new Producte[10];
            nElem = 0;
        }
        /// <summary>
        /// Cosntructor botiga amb nom i nombre de productes. Inicialitzem nElem a 0, el nom de la botiga per paramtre i l'array de productes al nombre de productes.
        /// </summary>
        /// <param name="parametre nom tipus string"></param>
        /// <param name="parametre nombreProductes tipus int"></param>
        public Botiga(string nom, int nombreProductes)
        {
            nElem = 0;
            nomBotiga = nom;
            productes = new Producte[nombreProductes];
        }
        /// <summary>
        /// Cconstructor amb nom i array de productes. Inicialitzem el nom de la botiga i l'array de productes al array de productes pasat per parametre.
        /// nElem al nombre d'elements de l'array de productes.
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="productes"></param>
        public Botiga(string nom, Producte[] productes)
        {
            nomBotiga = nom;
            this.productes = productes;
            nElem = productes.Length;
        }

        //propietats
        /// <summary>
        /// Propietat NomBotiga. Retorna el nom de la botiga.
        /// </summary>
        public string NomBotiga
        {
            get { return nomBotiga; }
            set { nomBotiga = value; }
        }
        /// <summary>
        /// Propietat Productes. Retorna l'array de productes i el modifica.
        /// </summary>
        public Producte[] Productes
        {
            get { return productes; }
            set { productes = value; }
        }
        /// <summary>
        /// Propietat NElem. Retorna el número d'elements de l'array de productes i el modifica.
        /// </summary>
        public int NElem
        {
            get { return nElem; }
            set { nElem = value; }
        }

        //metodes
        /// <summary>
        /// Metode per buscar una posicio buida a l'array de productes.
        /// </summary>
        /// <returns>posicio de l'espai buit o -1 si no n'ha trobat cap.</returns>
        public int EspaiLliure()
        {
            int posicio = -1;
            for (int i = 0; i < productes.Length && posicio == -1; i++)
            {
                if (productes[i] == null)
                {
                    posicio = i;
                }
            }
            return posicio;
        }
        //public int Indexador(Producte producte)
        //{
        //    int index = -1;
        //    for (int i = 0; i < nElem; i++)
        //    {
        //        if (producte.Nom == productes.Nom)
        //        {
        //            index = i;
        //        }
        //    }
        //    return index;
        //}

    }
}