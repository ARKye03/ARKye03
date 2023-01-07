using System;
using C_Mix;

namespace C_Mix
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            bool SiG = Stringer.Isgrounded;
            int sel = int.Parse(Console.ReadLine());
            if (sel == 1){Stringer.Isgrounded = true;}

            if (Stringer.Isgrounded){Stringer.SMain();}
            else{Console.WriteLine("Esta volaaaando");}

            Console.WriteLine("A number, then his POWER");
            int s_x = int.Parse(Console.ReadLine());
            int s_y = int.Parse(Console.ReadLine());
            
            Console.WriteLine(Stringer.Ch(s_x, s_y));


            Stringer.STMain();

            Console.ReadKey();
        }
    }
}