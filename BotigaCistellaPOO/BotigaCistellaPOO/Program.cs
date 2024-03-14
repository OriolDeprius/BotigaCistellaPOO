using System.Runtime.InteropServices.Marshalling;

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

                                Console.WriteLine(MenuAdministrarBotiga());
                                respostaMenuAdministrarBotiga = Console.ReadKey().KeyChar;

                                if (respostaMenuAdministrarBotiga == '1')
                                    SwitchBotiga(respostaMenuAdministrarBotiga);

                                if (respostaMenuAdministrarBotiga == '2')
                                    SwitchProducte(respostaMenuAdministrarBotiga, botiga);
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
                          "╚══════════════════════════════════╝\n";
            return menu;
        }
        /// <summary>
        /// metode per mostrar el menu de l'administracio de botiga.
        /// </summary>
        /// <returns></returns>
        static string MenuBotiga()
        {
            string menu = "╔══════════════════════════════════════╗\n" +
                          "║*-*-*-*-*-*-TRIA UNA OPCIÓ-*-*-*-*-*-*║\n" +
                          "╠══════════════════════════════════════╣\n" +
                          "║                                      ║\n" +
                          "║  1. Crear Botiga                     ║\n" +
                          "║  2. Veure Botiga                     ║\n" +
                          "║  3. Canviar nom Botiga               ║\n" +
                          "║  4.          ║\n" +
                          "║  5.                    ║\n" +
                          "║  6. Ordenar Productes (NOM)          ║\n" +
                          "║  7. Ordenar Productes (PREU)         ║\n" +
                          "║  8.     ║\n";

            return menu;
        }
        /// <summary>
        /// metode amb switch per triar una opcio de l'administracio de la botiga.
        /// </summary>
        /// <param name="opcio">parametre tipus char</param>
        static void SwitchBotiga(char opcio)
        {
            Console.Clear();
            Console.WriteLine(MenuBotiga());
            char respostaMenuBotiga = Console.ReadKey().KeyChar;
            switch (respostaMenuBotiga)
            {
                case '1':
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
                case '5':
                    break;
                case '6':
                    break;
                case '7':
                    break;
                case '8':
                    break;
            }
        }
        static string MenuProducte()
        {
            string menu = "╔══════════════════════════════════╗\n" +
                          "║*-*-*-*-*-TRIA UNA OPCIÓ-*-*-*-*-*║\n" +
                          "╠══════════════════════════════════╣\n" +
                          "║    1. Modificar Producte         ║\n" +
                          "║    2. Veure tots els productes   ║\n" +
                          "╠══════════════════════════════════╣\n" +
                          "║      TECLA 0 PER ANAR INICI      ║\n" +
                          "╚══════════════════════════════════╝\n";

            return menu;
        }
        static void SwitchProducte(char opcio, Botiga botiga)
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
                        Console.WriteLine("Tria el producte que vols modificar (numero de linia):");
                        Console.WriteLine(botiga.Mostrar());
                        int producteSeleccionat = Convert.ToInt32(Console.ReadLine());
                        Thread.Sleep(2000);
                        break;
                    case '2':
                        break;
                    case '0':
                        Console.Clear();
                        Console.WriteLine("Tornant al menú principal...");
                        Thread.Sleep(2000);
                        break;
                }
            }
            while (respostaMenuProducte != '0');
        } 
        static Botiga CarregarBotiga()
        {
            Botiga botigaAux = new Botiga();
            botigaAux.Productes = new Producte[10];
            StreamReader sr = new StreamReader("botiga.csv");
            sr.ReadLine();
            string linia = sr.ReadLine();
            botigaAux.NomBotiga = linia.Split(',')[0];
            string[] productes = linia.Split(',')[1].Split(';');
            for (int i = 0; i < productes.Length; i++)
            {
                Producte p = new Producte();
                p.Nom = productes[i].Split(',')[0];
                p.Preu_sense_iva = Convert.ToDouble(productes[i].Split(';')[1]);
                p.Iva = Convert.ToDouble(productes[i].Split(';')[2]);
                p.Quantitat = Convert.ToInt32(productes[i].Split(';')[3]);
                botigaAux.Productes[i] = p;

                //botigaAux.Productes[i].Nom = productes[i].Split(',')[0];
                //botigaAux.Productes[i].Preu_sense_iva = Convert.ToDouble(productes[i].Split(';')[1]);
                //botigaAux.Productes[i].Iva = Convert.ToDouble(productes[i].Split(';')[2]);
                //botigaAux.Productes[i].Quantitat = Convert.ToInt32(productes[i].Split(';')[3]);
            }
            return botigaAux;
        }

    }
}
