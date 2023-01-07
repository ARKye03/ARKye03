using System;
using C_Mix;

namespace C_Mix
{
    public class Stringer
    {
        public static bool Isgrounded;
        public static void SMain()
        {
            string x = "Oye si se hacer una referencia de otro proyecto";
            Console.WriteLine(x);
        }
        public static int Ch(int x, int y)
        {
            int Pr;
            Pr = Convert.ToInt32(Math.Pow(x, y));

            return Pr;
        }
        public static void STMain()
        {
            string h = "Pues estoy aqui ahora que hago lol";
            Console.WriteLine(h);
            Console.ReadKey();
            TmT.TMain();
        }
    }
}