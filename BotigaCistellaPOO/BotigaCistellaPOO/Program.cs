using System.Net.Http.Headers;

namespace BotigaCistellaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char respostaMenuInicial;
            char respostaMenuAdministrarBotiga;
            string contrasenyaIntroduida;
            string contrasenyaAdmin = "xxx123xxx";//contrasenya que s'ha d'introduir per accedir a l'administració de la botiga
            Botiga botiga = CarregarBotiga();
            Producte producte = CarregarProducte();

            /// <summary>
            /// bucle que mostra el menú inicial i segons la resposta de l'usuari, crida a un mètode o un altre.
            /// també controla que la contrasenya sigui correcta per accedir a l'administració de la botiga.
            /// quan l'usuari vol sortir del programa, el bucle finalitza i acaba el programa.
            /// es posa la consola en cyan de fons i el text en vermell.
            /// </summary>
            do
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine(MenuInicial());
                respostaMenuInicial = Console.ReadKey().KeyChar;
                switch (respostaMenuInicial)
                {
                    case '1':

                        break;
                    case '2':
                        bool contrasenyaCorrecta = false;
                        do
                        {
                            Console.Clear();
                            Console.Write("Introdueix la contrasenya: ");
                            contrasenyaIntroduida = Console.ReadLine();

                            if (contrasenyaIntroduida == contrasenyaAdmin)
                            {
                                Console.WriteLine("Contrasenya correcta.");
                                contrasenyaCorrecta = true;
                                Thread.Sleep(1000);
                                Console.Clear();
                                for (int i = 3; i >= 1; i--)
                                {
                                    Console.Write($"Entrant a l'administració de la botiga en... ");
                                    Console.WriteLine(i);
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                }
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine(MenuAdministrarBotiga());
                                    respostaMenuAdministrarBotiga = Console.ReadKey().KeyChar;
                                    if (respostaMenuAdministrarBotiga == '1')
                                        SwitchBotiga(respostaMenuAdministrarBotiga, botiga, productes);
                                    if (respostaMenuAdministrarBotiga == '2')
                                        SwitchProducte(respostaMenuAdministrarBotiga, botiga, productes);
                                } while (respostaMenuAdministrarBotiga != '0');
                            }
                            else
                            {
                                Console.WriteLine("Contrasenya incorrecta.");
                                Thread.Sleep(2000);
                            }
                        }
                        while (!contrasenyaCorrecta);
                        break;
                    case '0':
                        Console.Clear();
                        Console.WriteLine("Adeu!");
                        break;
                }
            }
            while (respostaMenuInicial != '0');
        }
        /// <summary>
        /// Mètode amb el menú inicial del programa.
        /// </summary>
        /// <returns>retorna un string amb el menú inicial del programa.</returns>
        static string MenuInicial()
        {
            string menu = "╔══════════════════════════════════╗\n" +
                          "║*-*-*-*-*-TRIA UNA OPCIÓ-*-*-*-*-*║\n" +
                          "╠══════════════════════════════════╣\n" +
                          "║                                  ║\n" +
                          "║    1.  Comprar Productes         ║\n" +
                          "║                                  ║\n" +
                          "║    2.  Administrar Botiga        ║\n" +
                          "║                                  ║\n" +
                          "╠══════════════════════════════════╣\n" +
                          "║        0.  Tancar Menú           ║\n" +
                          "╚══════════════════════════════════╝\n";
            return menu;
        }
        /// <summary>
        /// metode amb el menu de l'administració de la botiga.
        /// </summary>
        /// <returns>retorna un string del menu</returns>
        static string MenuAdministrarBotiga()
        {
            string menu = "╔══════════════════════════════════╗\n" +
                          "║*-*-*-*-*-TRIA UNA OPCIÓ-*-*-*-*-*║\n" +
                          "╠══════════════════════════════════╣\n" +
                          "║                                  ║\n" +
                          "║          1.  Botiga              ║\n" +
                          "║                                  ║\n" +
                          "║          2.  Producte            ║\n" +
                          "║                                  ║\n" +
                          "╠══════════════════════════════════╣\n" +
                          "║         0. Tornar enrere         ║\n" +
                          "╚══════════════════════════════════╝\n";
            return menu;
        }
        /// <summary>
        /// metode per mostrar el menu de l'administracio de botiga.
        /// </summary>
        /// <returns>retorna string del menu Botiga</returns>
        static string MenuBotiga()
        {
            string menu = "╔══════════════════════════════════════╗\n" +
                          "║*-*-*-*-*-*-TRIA UNA OPCIÓ-*-*-*-*-*-*║\n" +
                          "╠══════════════════════════════════════╣\n" +
                          "║                                      ║\n" +
                          "║  1. Veure Botiga                     ║\n" +
                          "║  2. Afegir Producte                  ║\n" +
                          "║  3. Ordenar Productes (NOM)          ║\n" +
                          "║  4. Ordenar Productes (PREU)         ║\n" +
                          "║                                      ║\n" +
                          "╠══════════════════════════════════════╣\n" +
                          "║          0.  Tornar enrere           ║\n" +
                          "╚══════════════════════════════════════╝\n";

            return menu;
        }
        /// <summary>
        /// metode amb switch per triar una opcio de l'administracio de la botiga.
        /// </summary>
        /// <param name="opcio">parametre tipus char</param>
        static void SwitchBotiga(char opcio, Botiga botiga, Producte productes)
        {
            Console.Clear();
            Console.WriteLine(MenuBotiga());
            char respostaMenuBotiga = Console.ReadKey().KeyChar;
            switch (respostaMenuBotiga)
            {
                case '1':
                    Console.Clear();
                    Console.WriteLine(botiga.ToString());
                    Console.WriteLine("Prem una tecla per continuar...");
                    Console.ReadKey();
                    break;
                case '2':
                    Console.Clear();
                    Console.WriteLine("Introdueix el nou producte:");
                    Console.WriteLine("Nom: ");
                    string nom = Console.ReadLine();
                    Console.WriteLine("Preu (sense IVA): ");
                    double preu = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("IVA: ");
                    double iva = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Quantitat: ");
                    int quantitat = Convert.ToInt32(Console.ReadLine());
                    Producte p = new Producte(nom, preu, iva, quantitat);
                    botiga.AfegirProducte(p);
                    StreamWriter sw = new StreamWriter("botiga.csv");
                    sw.Write($".{nom};{preu};{iva};{quantitat}");
                    sw.Close();
                    break;
                case '3':
                    Console.Clear();
                    botiga.OrdenarProductes();
                    break;
                case '4':
                    break;
                case '0':
                    Console.Clear();
                    Console.WriteLine("Tornant al menú d'administració...");
                    Thread.Sleep(2000);
                    break;
            }
        }
        /// <summary>
        /// metode amb el menu de producte.
        /// </summary>
        /// <returns>retorna un string amb el menu de producte</returns>
        static string MenuProducte()
        {
            string menu = "╔══════════════════════════════════╗\n" +
                          "║*-*-*-*-*-TRIA UNA OPCIÓ-*-*-*-*-*║\n" +
                          "╠══════════════════════════════════╣\n" +
                          "║                                  ║\n" +
                          "║    1. Modificar Producte         ║\n" +
                          "║                                  ║\n" +
                          "║    2. Veure tots els productes   ║\n" +
                          "║                                  ║\n" +
                          "╠══════════════════════════════════╣\n" +
                          "║      0.    Tornar enrere         ║\n" +
                          "╚══════════════════════════════════╝\n";

            return menu;
        }
        /// <summary>
        /// metode amb switch per triar una opcio de l'administracio de producte.
        /// </summary>
        /// <param name="opcio">tipus char</param>
        /// <param name="botiga"> tipus Botiga</param>
        static void SwitchProducte(char opcio, Botiga botiga, Producte productes)
        {
            char respostaMenuProducte;
            do
            {
                Console.Clear();
                Console.WriteLine(MenuProducte());
                respostaMenuProducte = Console.ReadKey().KeyChar;
                switch (respostaMenuProducte)
                {
                    case '1':
                        Console.Clear();
                        ModificarProducte(botiga);
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine(productes.ToString());
                        Console.WriteLine("Prem una tecla per continuar...");
                        Console.ReadKey();
                        break;
                    case '0':
                        Console.Clear();
                        Console.WriteLine("Tornant al menú d'administració...");
                        Thread.Sleep(2000);
                        break;
                }
            }
            while (respostaMenuProducte != '0');
        }
        static void ModificarProducte(Botiga botiga)
        {
            Console.Clear();
            Console.WriteLine("Tria el producte que vols modificar (numero de linia):");
            Console.WriteLine(botiga.Mostrar());
            int producteSeleccionat = Convert.ToInt32(Console.ReadLine());
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Quin camp vols modificar?");
            Console.WriteLine("1. Nom");
            Console.WriteLine("2. Preu");
            Console.WriteLine("3. IVA");
            Console.WriteLine("4. Quantitat");
            char campSeleccionat = Console.ReadKey().KeyChar;
            switch (campSeleccionat)
            {
                case '1':
                    Console.Clear();
                    Console.Write("Introdueix el nou nom: ");
                    string nouNom = Console.ReadLine();
                    botiga.Productes[producteSeleccionat].Nom = nouNom;
                    break;
                case '2':
                    Console.Clear();
                    Console.Write("Introdueix el nou preu: ");
                    double nouPreu = Convert.ToDouble(Console.ReadLine());
                    botiga.Productes[producteSeleccionat].Preu_sense_iva = nouPreu;
                    break;
                case '3':
                    Console.Clear();
                    Console.Write("Introdueix el nou IVA: ");
                    double nouIva = Convert.ToDouble(Console.ReadLine());
                    botiga.Productes[producteSeleccionat].Iva = nouIva;
                    break;
                case '4':
                    Console.Clear();
                    Console.Write("Introdueix la nova quantitat: ");
                    int novaQuantitat = Convert.ToInt32(Console.ReadLine());
                    botiga.Productes[producteSeleccionat].Quantitat = novaQuantitat;
                    break;
            }
        }
        /// <summary>
        /// metode per carregar la botiga.
        /// </summary>
        /// <returns>retorna una botiga creada en base a arxiu</returns>
        static Botiga CarregarBotiga()
        {
            Botiga botigaAux = new Botiga();
            botigaAux.Productes = new Producte[10];
            StreamReader sr = new StreamReader("botiga.csv");
            sr.ReadLine();
            string linia = sr.ReadLine();
            botigaAux.NomBotiga = linia.Split(',')[0];
            string[] productes = linia.Split(',')[1].Split('.');
            for (int i = 0; i < productes.Length; i++)
            {
                Producte p = new Producte();
                p.Nom = productes[i].Split(';')[0];
                p.Preu_sense_iva = Convert.ToDouble(productes[i].Split(';')[1]);
                p.Iva = Convert.ToDouble(productes[i].Split(';')[2]);
                p.Quantitat = Convert.ToInt32(productes[i].Split(';')[3]);
                botigaAux.Productes[i] = p;
                botigaAux.NElem++;
            }
            sr.Close();
            return botigaAux;
        }
        static Producte CarregarProducte()
        {
            //falta persistencia de dades amb arxiu csv pero de moment tenim aixo per provar
            Producte producteAux = new Producte();
            StreamReader sr = new StreamReader("producte.csv");
            sr.ReadLine();
            string linia = sr.ReadLine();
            producteAux.Nom = linia.Split(',')[0];
            producteAux.Preu_sense_iva = Convert.ToDouble(linia.Split(',')[1]);
            producteAux.Iva = Convert.ToDouble(linia.Split(',')[2]);
            producteAux.Quantitat = Convert.ToInt32(linia.Split(',')[3]);
            return producteAux;
        }
    }
}
