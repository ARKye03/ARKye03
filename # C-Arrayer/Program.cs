﻿using System;
using System.Linq;
using System.IO;

namespace C_Arrayer
{ 
    internal class Mind
    {
        static string[] Arrayer(){
            int a = int.Parse(Console.ReadLine());
            Console.Clear();
            string[] str = new string[a];

            for (int i = 0; i < str.Length; i++){str[i] = Console.ReadLine();}

            for (int d = 0; d < str.Length; d++){ Console.Write('"' + str[d] + '"' + ',');}

            return str;

        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Cantidad de items");

            FileStream ost;
            StreamWriter sw;
            TextWriter Oo = Console.Out;

            try
            {
                ost = new FileStream ("./Arrayed.txt", FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter (ost);
            }
            catch (Exception e)
            {
                Console.WriteLine ("Cannot open Arrayed.txt for writing");
                Console.WriteLine (e.Message);
                return;
            }
             Console.SetOut(sw);     
             Console.Write(Arrayer() + ";");
             Console.SetOut(Oo);
             sw.Close();
             ost.Close();
             Console.WriteLine("Done");
            

            Console.ReadKey();
        }

    }
}
