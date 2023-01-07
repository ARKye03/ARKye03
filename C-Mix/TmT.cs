using System;
using System.Collections;

namespace C_Mix
{
    public class TmT
    {
        public long num;
        public int milt;
        
        static void Fact(){
            Console.Clear();
            hr:
            Console.WriteLine("Type a number(<=20)");
            long f = Convert.ToInt64(Console.ReadLine());
            long y = f;
            long g = f;
            if(f > 20 || f < 1){goto hr;}

            for (int i = 2; i < f; i++)
            {
                y = y * (g - 1);
                g--;
                Console.WriteLine(y);
            }
                
            }

        static void Funct(){
            Start:
            Console.Clear();
            Console.WriteLine("How many times you want to multiply?");
            Console.WriteLine("Type a number");
            TmT x = new TmT();
            
            x.milt = Convert.ToInt32(Console.ReadLine());
            x.num = Convert.ToInt64(Console.ReadLine());

            if(x.milt == 1){Console.WriteLine("Se multiplicará " + x.milt + " vez(es) el número " + x.num);}
            else if(x.milt <= 0){Console.WriteLine("2 de IQ loco"); Console.ReadKey(); goto Start;}
            else{Console.WriteLine("Se multiplicará " + x.milt + " veces el número " + x.num);}

            long y;

            for (int i = 1; i <= x.milt; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                y = x.num * i;
                Console.Write(i + ". - " + x.num + " x " + i + " = ");
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(y);
            
            }
        }
        public static void TMain()
        {
            Console.Title = "Tablilla pa mistiplicar"; Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("1 - Factorial 2 - Tabla mistiplicar");
            ConsoleKeyInfo cki;

            cki = Console.ReadKey();

            switch (cki.KeyChar)
            {
                case '1':
                Fact();
                break;

                case '2':
                Funct();
                break;

                default:
                break;
            }    
            Console.ReadKey();
        }
    }
}