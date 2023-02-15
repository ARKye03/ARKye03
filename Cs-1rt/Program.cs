using System;
using System.Text;
using System.Diagnostics;

namespace Cps;
class Cp2{
    static void Main(string[] args){
        string[] opt = {"Di hola","Recibiendo Entradas","Circunferencias","Ecuacion cuadratica","Velocidad de escritura","Fecha de nacimiento","Formando fechas"};
        string[] opt1 = {"1. String que muestra Hello World", "2. Valor maximo y minimo admitido por un int", "3. Valor aproximado de PI (MATH)"};
        string[] opt2 = {"1. Medio limon wtf", "2. Doble de un entero :)", "3. 3 Enteros y valor medio", "4. String con entero (x), caracter x del string"};
        bool Keep = true;
        //Start:
        while (Keep){
        Console.Clear(); Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Elige una opcion:");
        for (int i = 0; i < opt.Length; i++) { Console.WriteLine((i+1) +". "+ opt[i]);}
    
        var sel = Console.ReadKey(true).KeyChar;
        switch (sel)
        {
            case '1':
            Console.Clear();
            //for (int i = 0; i < opt1.Length; i++){ Console.WriteLine(opt1[i]); }
            foreach (string item in opt1) { Console.WriteLine(item);}
            sel = Console.ReadKey(true).KeyChar;
            switch (sel)
            {
                case '1':
                Console.WriteLine("\nHello World");
                Console.ReadKey();
                continue;
                case '2':
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nEl valor maximo admitido por un tipo entero (32 bits) es " + int.MaxValue);
                Console.WriteLine("El valor maximo admitido por un tipo entero (64 bits) es " + long.MaxValue);
                Console.WriteLine("El valor maximo admitido por un tipo entero (128 bits) es " + Int128.MaxValue);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nEl valor minimo admitido por un tipo entero (32 bits) es " + int.MinValue);
                Console.WriteLine("El valor minimo admitido por un tipo entero (64 bits) es " + long.MinValue);
                Console.WriteLine("El valor minimo admitido por un tipo entero (128 bits) es " + Int128.MinValue);
                Console.ReadKey();
                continue;
                case '3':
                string PI = "3,1415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679";
                decimal pi = Convert.ToDecimal(Math.PI);
                Console.WriteLine("\nEl aproximado de PI usando la clase " + '"' + "Math" + '"' + " es: " + pi);
                Console.WriteLine($"\n\n Aquí un poco exagerado: {PI}...");
                Console.ReadKey();
                continue;
                
                default:
                break;
            }

            break;

            case '2': Console.Clear();
                //for (int i = 0; i < opt2.Length; i++) { Console.WriteLine(opt2[i]); }
                foreach (string item2 in opt2) { Console.WriteLine(item2);}
                sel = Console.ReadKey(true).KeyChar;
                switch (sel)
                {
                    case '1': Console.Clear();
                    Console.Write("Introduzca una cadena de caracteres: ");
                    var opp = Console.ReadLine();
                    Console.WriteLine($"\n{opp} medio limon");
                    Console.ReadKey();
                    continue;
                    case '2': Entero: Console.Clear();
                    double input;
                    Console.Write("Introduzca un numero entero... Gracias: ");
                    try{ input = Convert.ToInt64(Console.ReadLine());}
                    catch{ Console.Clear();
                        Console.WriteLine("Pusiste algo que no era un numero, muy probablemente algo como pizza :)))))");
                        Console.ReadKey();   goto Entero; }

                    Console.WriteLine($"El doble de su numero es {input*2}");
                    Console.ReadKey();  
                    continue;
                    case '3': MidOne: Console.Clear();
                    int num1, num2, num3;
                    try{
                    Console.Write("Ingrese el primer número entero: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo número entero: ");
                    num2 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el tercer número entero: ");
                    num3 = int.Parse(Console.ReadLine());
                    } catch{ Console.WriteLine("Eso no es un numero, o es una talla turbia"); Console.ReadKey(); goto MidOne;}

                    int max = Math.Max(Math.Max(num1, num2), num3);
                    int min = Math.Min(Math.Min(num1, num2), num3);
                    int medio = num1 + num2 + num3 - max - min;
                    double promedio = (num1 + num2 + num3) / 3.0;

                    Console.WriteLine("El número máximo es: " + max);
                    Console.WriteLine("El número mínimo es: " + min);
                    Console.WriteLine("El número de valor medio es: " + medio);
                    Console.WriteLine("El promedio es: " + promedio);
                    Console.ReadKey();
                    continue;

                    case '4': Console.Clear(); SB:
                    int int4;
                    //StringBuilder sb = new StringBuilder();
                    Console.Write("Introduzca un elemento de tipo string: ");
                    var pp4 = Console.ReadLine();
                    int slong = pp4.Length;
                    Console.Write($"Introduzca un entero menor que la cantidad de caracteres ({slong}) del string antes insertado: ");
                    try{int4 = int.Parse(Console.ReadLine());} catch {System.Console.WriteLine("Intentalo de nuevo pip@"); goto SB;}
                    
                    if(slong < int4) { Console.WriteLine("El numero entero es mayor xd"); Console.ReadKey(); goto SB;}

                    Console.WriteLine("El caracter que se encuentra en la posicion {0} del string es '{1}'", int4, pp4.ElementAt(int4 - 1)); 
                    Console.ReadKey();
                    continue;
                
                    default:
                    continue;
                }
            case '3': Circ: Console.Clear();
            int radio;
            double AreaS;
            Console.Write("Introduzca un numero el cual pasara a ser radio de dos circunferencias: ");
            try{ radio = int.Parse(Console.ReadLine());} catch{Console.WriteLine("Parece que ese radio no era del todo un radio que crees"); Console.ReadKey(); goto Circ;}
            AreaS = (((Math.PI * radio * radio * 60) / 360) - 1/2 * (radio*radio * (Math.Sqrt(3)/2))) * 2; //Se que el 60 sobra pero me gusta :)
            Console.WriteLine("El valor del area sombreada es: " + AreaS);

            Console.ReadKey();
            continue;

            case '4': Cuad: Console.Clear();
            int a, b, c;
            Console.WriteLine("Tenemos una ecuacion cuadratica... ax^2 + bx + c = 0\n Dame los valores de la 'a', 'b' y 'c', y mira la magia");
            double Sol1, Sol2;
            try{
                Console.Write("Valor de 'a': "); a = int.Parse(Console.ReadLine());
                Console.Write("Valor de 'b': "); b = int.Parse(Console.ReadLine());
                Console.Write("Valor de 'c': "); c = int.Parse(Console.ReadLine());
            } catch{System.Console.WriteLine("Hubo un misunderstending ahi :)"); Console.ReadKey(); goto Cuad;}
            try{
            Sol1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a;
            Sol2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a;
            } catch{Console.WriteLine("Parece que la ecuacion no tenia solucion real prueba con otra..."); Console.ReadKey(); goto Cuad;}

            Console.WriteLine($"La solucion X1 es {Sol2} y la solucion X2 es {Sol1}");
            Console.ReadKey();

            continue;

            case '5': Console.Clear(); Stopwatch timer = new Stopwatch();
            Console.WriteLine("Escriba un  texto cualquiera asi podemos calcular su velocida de  escritura: ");
            timer.Start();
            string text = Console.ReadLine();
            //int result = Environment.TickCount;
            double l = text.Length;
            timer.Stop();
            Console.WriteLine("Usted escribio su texto en {0} segundos", timer.ElapsedMilliseconds / 1000);
            //Console.WriteLine("Usted escribio su texto en {0} segundos",result / 10000000);
            Console.WriteLine("Con una velocidad de {0} caracteres por segundos", text.Length / (timer.ElapsedMilliseconds / 1000));
            Console.ReadKey();
            continue;

            case '6': Age: Console.Clear();
            long id; long[] cifras = new long[11];
            Console.Write("Introduce tu numero de identidad: ");
            try{id = long.Parse(Console.ReadLine());} catch{Console.WriteLine("El programa no pudo ver el carnet de identidad, prueba de nuevo"); Console.ReadKey(); goto Age;}
            for (int i = 0; id >= cifras.Length; i++)
            {
                cifras[i] = id % 10;
                id /= 10;
            }
            if(cifras.Length != 11){Console.WriteLine("Tu id parece especial, no tiene la misma longitud que el resto"); Console.ReadKey(); goto Age;}
            Console.WriteLine($"Naciste el {cifras[6]}{cifras[5]}/{cifras[8]}{cifras[7]}/{cifras[10]}{cifras[9]}");
            Console.ReadKey();
            continue;

            case '7': Fecha: Console.Clear();
            int dia, mes, ano;
            try{
                Console.Write("introduzca un dia: "); dia = int.Parse(Console.ReadLine()); if(dia > 31 || dia < 1){Console.WriteLine("Un dia epico ese eh"); Console.ReadKey(); goto Fecha;}
                Console.Write("introduzca un mes: "); mes = int.Parse(Console.ReadLine()); if(mes > 12 || mes < 1){Console.WriteLine("Un mes guapisimo ese eh"); Console.ReadKey(); goto Fecha;}
                Console.Write("introduzca un año: "); ano = int.Parse(Console.ReadLine()); if(ano < 1){Console.WriteLine("Un año esplendido ese eh"); Console.ReadKey(); goto Fecha;}
            } catch{System.Console.WriteLine("Algo puesto ahi no cuadraba del todo mi pana"); Console.ReadKey(); goto Fecha;}
            Console.WriteLine($"La fecha formada es {dia}/{mes}/{ano}");
            Console.ReadKey();
            continue;
            
            default:
            break;
        }

        }




        Console.ReadKey();
    }
}

//Separar