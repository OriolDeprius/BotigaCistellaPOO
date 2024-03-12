namespace BotigaCistellaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.CursorVisible = false;
            

        }
        static string MenuInicial()
        {
            string menu = "╔══════════════════════════════════╗" +
                          "║*-*-*-*-*-TRIA UNA OPCIÓ-*-*-*-*-*║" +
                          "╠══════════════════════════════════╣" +
                          "║                                  ║" +
                          "║    1.  Comprar Productes         ║" +
                          "║                                  ║" +
                          "║    2.  Administrar Botiga        ║" +
                          "║                                  ║" +
                          "╚══════════════════════════════════╝";
            return menu;
        }
        static string MenuAdministrarBotiga()
        {
            string menu = "╔══════════════════════════════════╗" +
                          "║*-*-*-*-*-TRIA UNA OPCIÓ-*-*-*-*-*║" +
                          "╠══════════════════════════════════╣" +
                          "║                                  ║" +
                          "║          1.  Botiga              ║" +
                          "║                                  ║" +
                          "║          2.  Producte            ║" +
                          "║                                  ║" +
                          "╚══════════════════════════════════╝";
                          
            return menu;
        }
        static string MenuBotiga()
        {
            string menu = "╔══════════════════════════════════════╗" +
                          "║*-*-*-*-*-*-TRIA UNA OPCIÓ-*-*-*-*-*-*║" +
                          "╠══════════════════════════════════════╣" +
                          "║                                      ║" +
                          "║  1. Crear Botiga                     ║" +
                          "║  2. Veure Botiga                     ║" +
                          "║  3. Canviar nom Botiga               ║" +
                          "║  4.          ║" +
                          "║  5.                    ║" +
                          "║  6. Ordenar Productes (NOM)          ║" +
                          "║  7. Ordenar Productes (PREU)         ║" +
                          "║  8.     ║";

            return menu;
        }
    }
}
