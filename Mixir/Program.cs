using System;
using System.Diagnostics;

namespace Mixir
{
  class Kaprekar{
    static int KaprekarRc(int Kpk, int prev){
        prev = Kpk;

        int[] Kpkdi = new int[4];
        for (int i = 0; i < 4; i++){Kpkdi[i] = Kpk%10; Kpk = Kpk/10;};

        //Sort Ascend
        Array.Sort(Kpkdi);
        int asc = 0;
        for (int i = 0; i < 4; i++){asc = asc * 10 + Kpkdi[i];}

        //Sort Descend
        Array.Sort(Kpkdi);
        int desc = 0;
        for (int i = 3; i >= 0; i++){desc = desc / 10 + Kpkdi[i];}

        int diff = Math.Abs(asc - desc);
        if(diff == prev){return diff;}
        else {return KaprekarRc(diff, prev);}
      
      }
      public static int kaprekar(int Kpk){
       int prev = 0;
       return KaprekarRc(Kpk, prev);
        }
        //Driver
        public void MainX(){
          StartK:
          Console.Clear(); Console.Title = "Kaprekar"; Console.ForegroundColor = ConsoleColor.DarkMagenta;
          
          Console.WriteLine("Welcome to Kaprekar's constant");
          Console.WriteLine("Escribe un número de 4 cifras(No pueden ser iguales)        (Press Escape after # to exit)");   
          int Kpk = Convert.ToInt16(Console.ReadLine());
          if (Console.ReadKey().Key == ConsoleKey.Escape){return;}
          
          if (Kpk < 1000 || Kpk > 10000){goto StartK;}
          

          Console.WriteLine(Kpk);
          Console.ReadKey();
        }
    }//*/
    internal class Program
    {
      
        static void MathX(){
            ConsoleKeyInfo cki; Console.Clear(); Console.Title = "Math"; Console.ForegroundColor = ConsoleColor.Yellow;
            

            Console.ReadKey();
        }
        static void Game(){
            Guessin:
                Console.Clear(); Console.Title = "Guessin"; Console.ForegroundColor = ConsoleColor.Green;
                
                Random numGen = new Random();
                int number = numGen.Next(0, 50);
                
                ConsoleKeyInfo cki;
                Stopwatch crono = new Stopwatch();
                int prize;
                int chances;
                string[] game = {"Benvenuto nel gioco della fortuna", "Prova a indovinare il numero che ho scelto tra 0 e 50 e ti darò un premio"};
                string[] diff = {"Selecciona tu dificultad:", "1 - Fácil", "2 - Medio", "3 - Dificil", "             (4/Atrás)"};
                //Console.WriteLine(number);
                
            
              for (int i = 0; i < game.Length; i++){ Console.WriteLine(game[i]); }
              TmP:
              //if (Console.ReadKey().Key == ConsoleKey.Escape){return;}
              prize = Convert.ToInt16(Console.ReadLine());
              if(prize < 1 || prize > 50){goto TmP;}
              
              for (int d = 0; d < diff.Length; d++) { Console.WriteLine(diff[d]); }

              cki = Console.ReadKey(true);

              switch (cki.KeyChar)
              {
                case '1':
                crono.Start();
                chances = 12;
                Diff1:
                if(chances == 0){
                    Console.WriteLine("Valiste verga papu");
                    Console.ReadKey();
                    crono.Stop();
                    goto Guessin;
                }
                else{
                    while (true)
                { 
                if (prize == number)
              {
                crono.Stop();
                float time = crono.ElapsedMilliseconds / 1000;
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ganaste en " + time + " segundos");
                Console.WriteLine("Presiona cualquier tecla para regresar");
                Console.ReadKey();
                
                goto Guessin;
              }
              else if (prize < number)
              {chances--;
              Console.WriteLine("Te quedan " + chances + " oportunidad(s)");
                Console.WriteLine("El número que buscas es mayor");
                prize = Convert.ToInt16(Console.ReadLine());

                goto Diff1;
              }
              else{chances--;
              Console.WriteLine("Te quedan " + chances + " oportunidad(s)");
                Console.WriteLine("El número que buscas es menor");               
                prize = Convert.ToInt16(Console.ReadLine());
                
                goto Diff1;
              }
                }  
                }
                
                case '2':
                crono.Start();
                chances = 8;
                Diff2:
                if(chances == 0){
                    Console.WriteLine("Valiste verga papu");
                    Console.ReadKey();
                    crono.Stop();
                    goto Guessin;
                }
                else{
                    while (true)
                { 
                if (prize == number)
              {
                crono.Stop();
                float time = crono.ElapsedMilliseconds / 1000;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ganaste en " + time + " segundos");
                Console.WriteLine("Presiona cualquier tecla para regresar");
                Console.ReadKey();
                goto Guessin;
              }
              else if (prize < number)
              {chances--;
              Console.WriteLine("Te quedan " + chances + " oportunidad(s)");
                Console.WriteLine("El número que buscas es mayor");
                prize = Convert.ToInt16(Console.ReadLine());

                goto Diff2;
              }
              else{chances--;
              Console.WriteLine("Te quedan " + chances + " oportunidad(s)");
                Console.WriteLine("El número que buscas es menor");               
                prize = Convert.ToInt16(Console.ReadLine());
                
                goto Diff2;
              }
                }  
                }
            
                case '3':
                crono.Start();
                chances = 4;
                Diff3:
                if(chances == 0){
                    Console.WriteLine("Valiste verga papu");
                    Console.ReadKey();
                    crono.Stop();
                    goto Guessin;
                }
                else{
                    while (true)
                { 
                if (prize == number)
              {
                crono.Stop();
                float time = crono.ElapsedMilliseconds / 1000;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ganaste en " + time + " segundos");
                Console.WriteLine("Presiona cualquier tecla para regresar");
                Console.ReadKey();
                goto Guessin;
              }
              else if (prize < number)
              {chances--;
              Console.WriteLine("Te quedan " + chances + " oportunidad(s)");
                Console.WriteLine("El número que buscas es mayor");
                prize = Convert.ToInt16(Console.ReadLine());

                goto Diff3;
              }
              else{chances--;
              Console.WriteLine("Te quedan " + chances + " oportunidad(s)");
                Console.WriteLine("El número que buscas es menor");               
                prize = Convert.ToInt16(Console.ReadLine());
                
                goto Diff3;
              }
                }  
                }
                default:
                break;
              }
        }
        static void Collatzer(){
            long cll;
            int steps = 0;
            ConsoleKeyInfo cki;
            CllStart:
            Console.Title = "Collatzer"; Console.Clear(); Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1 - Direct  or  2 - Step by Step   (3/Start)");
            cki = Console.ReadKey(true);
            
            switch (cki.KeyChar){
                case '1':
            Console.WriteLine("Type a positive number. (/=0/1/2/3/4)");
            cll = Convert.ToInt64(Console.ReadLine());
            if(cll < 4){Console.WriteLine("4+ :)"); Console.ReadKey(); goto CllStart;}
            while (cll != 1){
                if ((cll % 2) == 0){ Console.ForegroundColor = ConsoleColor.DarkMagenta;
                cll = cll/2;
                steps++;
                Console.WriteLine("Par -------- " + cll);
            }
            else{ Console.ForegroundColor = ConsoleColor.DarkRed;
                cll = (cll * 3) + 1;
                steps++;
                Console.WriteLine("Impar -------- " + cll);
            }   
            }
            if(cll == 1){Console.WriteLine("Terminó con " + steps + " paso(s)");
            Console.Write("   Presiona cualquier tecla para regresar");
            Console.ReadKey();
            }  
            break;
            case '2':
            Console.WriteLine("Type a positive number. (/=0/1/2/3/4)");
            cll = Convert.ToInt64(Console.ReadLine());
            if(cll < 4){Console.WriteLine("4+ :)"); Console.ReadKey(); goto CllStart;}
            while (cll != 1){
                if ((cll % 2) == 0){ Console.ForegroundColor = ConsoleColor.DarkMagenta;
                cll = cll/2;
                steps++;
                Console.WriteLine("Par -------- " + cll);
                Console.ReadKey();
            }
            else{ Console.ForegroundColor = ConsoleColor.DarkRed;
                cll = (cll * 3) + 1;
                steps++;
                Console.WriteLine("Impar -------- " + cll);
                Console.ReadKey();
            }
            if(cll == 1){Console.WriteLine("Terminó con " + steps + " paso(s)");
            Console.Write("   Presiona cualquier tecla para regresar");
            Console.ReadKey();
            }  
             
            }
            break;
            case '3':
            return;
            default:
            goto CllStart;
            
            }
        }
        static void Main(string[] args)
        { 
            string[]wish = {"1 - Collatzer", "2 - Math", "3 - Game", "4 - Coming soon", "5 - Kaprekar - Coming Soon", "6 - Forsaken CS", "7 - Exit"};
            ConsoleKeyInfo keyInfo;
            
                Console.WriteLine("Como te llamas?                                          (Escape/Exit)");
                if (Console.ReadKey().Key == ConsoleKey.Escape){return;}
                 var name = Convert.ToString(Console.ReadLine());
            Start:
            Console.Title = "Inicio"; Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Clear();
            Console.WriteLine("Que deseas hacer " + name + "?");
            Console.WriteLine("               ");

            for (int i = 0; i < wish.Length; i++) {Console.WriteLine(wish[i]);}
            keyInfo = Console.ReadKey(true);
            
            switch (keyInfo.KeyChar)
            {
                case '1':
                Collatzer();
                goto Start;

                case '2':
                MathX();
                goto Start;

                case '3':
                Game();
                goto Start;

                case '4':
                goto Start;

                case '5':
                Kaprekar kpkr = new Kaprekar();
                kpkr.MainX();
                goto Start;

                case '6':
                goto Start;

                case '7':
                break;
                
                default:
                break;
            }
            Console.ReadKey();
        }
        }
    }