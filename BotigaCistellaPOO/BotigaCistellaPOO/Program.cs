namespace BotigaCistellaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char respostaMenuInicial;
            char respostaMenuAdministrarBotiga;
            string contrasenyaIntroduida;
            string contrasenyaAdmin = "xxx123xxx";

            do
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
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
                                    SwitchProducte(respostaMenuAdministrarBotiga);
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
            string menu = "╔";

            return menu;
        }
        static void SwitchProducte(char opcio)
        {
            Console.Clear();
            Console.WriteLine(MenuProducte());
            char respostaMenuProducte = Console.ReadKey().KeyChar;
            switch (respostaMenuProducte)
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
    }
}
