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
        /// <param name="nom">parametre tipus string</param>
        /// <param name="nombreProductes">parametre tipus int</param>
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
        /// <param name="nom">parametre tipus string</param>
        /// <param name="productes">parametre tipus Producte</param>
        public Botiga(string nom, Producte[] productes)
        {
            nomBotiga = nom;
            this.productes = productes;
            nElem = productes.Length;
        }

        //propietats
        /// <summary>
        /// Propietat NomBotiga. Retorna el nom de la botiga i el modifica.
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
        /// <summary>
        /// Metode per buscar un producte a l'array de productes.
        /// </summary>
        /// <param name="producte">parametre tipus Producte</param>
        /// <returns>retorna la posicio de l'array on es troba el producte o -1 si no s'ha trobat.</returns>
        public int Indexador(Producte producte)
        {
            int index = -1;
            for (int i = 0; i < nElem; i++)
            {
                if (producte.Nom == productes[i].Nom)
                {
                    index = i;
                }
            }
            return index;
        }
        /// <summary>
        /// Metode per afegir un producte a l'array de productes.
        /// </summary>
        /// <param name="producte">parametre tipus Producte</param>
        /// <returns>retorna false si no s'ha pogut afegir i true si s'ha pogut afegir.</returns>
        public bool AfegirProducte(Producte producte)
        {
            bool afegit = false;
            if (productes.Length >= nElem)
            {
                nElem++;
                productes[nElem - 1] = producte;
                afegit = true;
            }
            return afegit;
        }
        /// <summary>
        /// Metode per afegir un array de productes a l'array de productes. si la botiga esta plena, demana si vols ampliar-la.
        /// </summary>
        /// <param name="productesAfegir">parametre  tipus array de Producte</param>
        /// <returns>retorna si s'ha afegit o no</returns>
        public bool AfegirProducte(Producte[] productesAfegir)
        {
            bool afegits = false;
            if (productesAfegir.Length < productes.Length - nElem)
            {
                for (int i = 0; i < productesAfegir.Length; i++)
                {
                    productes[nElem] = productesAfegir[i];
                    nElem++;
                }
                afegits = true;
            }
            else if (productesAfegir.Length >= productes.Length - nElem)
            {
                Console.Write("La botiga està plena. Vols ampliar-la? (s/n) --> ");
                char ampliar = Console.ReadKey().KeyChar;
                if (ampliar == 's')
                {
                    Array.Resize(ref productes, productes.Length + productesAfegir.Length);//es referencia perque modifiqui l'array original i es suma la llargada dels dos arrays perque es redimensioni correctament.
                    for (int i = 0; i < productesAfegir.Length; i++)
                    {
                        productes[nElem] = productesAfegir[i];
                        nElem++;
                    }
                    afegits = true;
                }
                else if (ampliar == 'n')
                {
                    afegits = false;
                }
                else
                {
                    Console.WriteLine("Opció no vàlida.");
                }
            }
            return afegits;
        }
        /// <summary>
        /// Redimensiona l'array de productes segons el número pasat per parametre.
        /// </summary>
        /// <param name="numero">parametre tipus int</param>
        public void AmpliarBotiga(int numero)
        {
            Array.Resize(ref productes, productes.Length + numero);//es referencia perque modifiqui l'array original i es suma la llargada dels dos arrays perque es redimensioni correctament.
        }
        /// <summary>
        /// Modifca el preu del producte que ens passen per parametre, si no el troba llença missatge que no s'ha trobat i no modifica res.
        /// </summary>
        /// <param name="producte">parametre (nom) tipus string</param>
        /// <param name="preu">parametre tipus double</param>
        /// <returns>retorna true si l'ha trobat i modificat i false si no l'ha trobat.</returns>
        public bool ModificarPreu(string producte, double preu)
        {
            bool modificat = false;
            for (int i = 0; i < nElem; i++)
            {
                if (productes[i].Nom == producte)
                {
                    productes[i].Preu_sense_iva = preu;
                    modificat = true;
                }
            }
            if (!modificat)
            {
                Console.WriteLine("No s'ha trobat el producte, per tant, no s'ha modificat res.");
            }
            return modificat;
        }
        /// <summary>
        /// Busca el producte a traves del nom.
        /// </summary>
        /// <param name="producteBuscar">parametre tipus Producte</param>
        /// <returns>retorna true si l'ha trobat i false si no.</returns>
        public bool BuscarProducte(Producte producteBuscar)
        {
            bool trobat = false;
            for (int i = 0; i < nElem; i++)
            {
                if (producteBuscar.Nom == productes[i].Nom)
                {
                    trobat = true;
                }
            }
            return trobat;
        }
        /// <summary>
        /// Metode per modificar un producte. busca el producte a traves del nom i modifica el nom, el preu i la quantitat.
        /// </summary>
        /// <param name="producteModificar">parametre tipus Producte</param>
        /// <param name="nomNou">parametre tipus string</param>
        /// <param name="nouPreu">parametre tipus double</param>
        /// <param name="novaQuantitat">parametre tipus int</param>
        /// <returns>retorna true si l'ha modificat o fasle si no.</returns>
        public bool ModificarProducte(Producte producteModificar, String nomNou, double nouPreu, int novaQuantitat)
        {
            bool modificat = false;
            for (int i = 0; i < nElem; i++)
            {
                if (producteModificar.Nom == productes[i].Nom)
                {
                    productes[i].Nom = nomNou;
                    productes[i].Preu_sense_iva = nouPreu;
                    productes[i].Quantitat = novaQuantitat;
                    modificat = true;
                }
            }
            return modificat;
        }
        /// <summary>
        /// Metode per ordenar els productes de l'array de productes per nom. (Quick sort)
        /// </summary>
        /// <param name="p"> parametre tipus Producte[]</param>
        /// <param name="li">parametre tipus int</param>
        /// <param name="ls">parametre tipus int</param>
        public void OrdenarProductes(Producte[] p, int li, int ls)
        {
            Producte mig = p[(li + ls) / 2];
            int i = li;
            int j = ls;
            do
            {
                while (p[i].Nom.CompareTo(mig.Nom) < 0) i++;
                while (p[j].Nom.CompareTo(mig.Nom) > 0) j--;
                if (i <= j)
                {
                    (p[i], p[j]) = (p[j], p[i]);
                    i++;
                    j--;
                }
            }
            while (i <= j);
            if(j > li) OrdenarProductes(p, li, j);
            if(i < ls) OrdenarProductes(p, i, ls);
        }
        /// <summary>
        /// Metode per ordenar els productes de l'array de productes per preu.(Quick sort)
        /// </summary>
        /// <param name="p"> parametre tipus Producte[]</param>
        /// <param name="li">parametre tipus int</param>
        /// <param name="ls">parametre tipus int</param>
        public void OrdenarPreus(Producte[] p, int li, int ls)
        {
            Producte mig = p[(li + ls) / 2];
            int i = li;
            int j = ls;
            do
            {
                while (p[i].Preu() < mig.Preu() && i < ls) i++;
                while (p[j].Preu() > mig.Preu() && j > ls) j--;
                if (i <= j)
                {
                    (p[i], p[j]) = (p[j], p[i]);
                    i++;
                    j--;
                }
            }
            while (i <= j);
            if (j > li) OrdenarPreus(p, li, j);
            if (i < ls) OrdenarPreus(p, i, ls);
        }
        /// <summary>
        /// Metode per esborrar un producte de l'array de productes mantenint l'ordre.
        /// Es reaprofita el metode Indexador per buscar el producte a esborrar.
        /// </summary>
        /// <param name="producteEsborrar">parametre tipus Producte</param>
        public void EsborrarProducte(Producte producteEsborrar)
        {
            int posicioPerBorrar = Indexador(producteEsborrar);
            if (posicioPerBorrar != -1)
            {
                for (int i = posicioPerBorrar; i < nElem - 1; i++)
                    productes[i] = productes[i + 1];
                nElem--;
            }
        }
        /// <summary>
        /// Metode per mostrar els noms i preus amb iva aplicats dels productes de l'array de productes.
        /// </summary>
        /// <returns>retorna string</returns>
        public string Mostrar()
        {
            string mostrar = "";
            for (int i = 0; i < nElem; i++)
            {
                mostrar = mostrar + productes[i].Nom + ": " + productes[i].Preu + "\n";
            }
            return mostrar;
        }
        /// <summary>
        /// Metode per mostrar els noms, preus, preus sense iva i percentatge d'iva dels productes de l'array de productes.
        /// </summary>
        /// <returns>retorna de forma amigable totes les dades de l'array de Productes</returns>
        public string ToString()
        {
            string toStr = "";
            for (int i = 0; i < nElem; i++)
            {
                toStr = toStr + productes[i].Nom + ": " + productes[i].Preu + "\t" + "|" + "\t" + "Preu sense iva: " + productes[i].Preu_sense_iva + "Percentatge d'IVA: " + productes[i].Iva + "\n";
            }
            return toStr;
        }
    }
}