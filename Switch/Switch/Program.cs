using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            ciclo();
            Console.ReadKey();
        }

        public static void ciclo()
        {
            System.Console.WriteLine("1-imprimir Hola mundo 2.0");
            System.Console.WriteLine("2-concatenacion");
            System.Console.WriteLine("3-Suma de dos numeros");
            System.Console.WriteLine("4-Boleanos");
            System.Console.WriteLine("5-Ejercicio Do-While ");
            System.Console.WriteLine("6-Ejercicio While ");


            int casos = Convert.ToInt32(Console.ReadLine());
            string a = "hello";
            switch (casos)
            {
                case 1:

                    //Despliega un hola mundo
                    System.Console.WriteLine("Hola mundo 2.0");
                    Console.ReadKey();

                    //despliega los dos strings 

                    string b = "negro";
                    System.Console.WriteLine(a + " " + b);
                    Console.ReadKey();


                    break;
                case 2:


                    //despliega el nombre que ingresas y la concatena

                    System.Console.WriteLine("Ingresa un nombre:");
                    string c = Console.ReadLine();

                    System.Console.WriteLine(a + " " + c);
                    Console.ReadKey();

                    break;

                case 3:

                    //despliega pidiendo un numero
                    double num1 = 15;
                    System.Console.WriteLine("El primer numero es 15 cuanto deseas sumar?");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    System.Console.WriteLine(num1 + " " + num2 + " " + (num1 + num2));
                    Console.ReadKey();

                    break;



                case 4:

                    System.Console.WriteLine("ARE YOU GAY???   YOU CAN ANSWER ONLY WITH  TRUE OR FALSE");
                    //bool respuesta = Convert.ToBoolean(Console.ReadLine());
                    Boolean gay = true;

                    if (gay)
                    {

                        System.Console.WriteLine("I KHOW IT");
                        Console.ReadKey();

                    }

                    else
                    {
                        System.Console.WriteLine("YOU ARE GAY");
                        Console.ReadKey();
                    }



                    /*
                    if( respuesta == true)
                    {

                        System.Console.WriteLine("I KHOW IT");
                        Console.ReadKey();

                    }

                    else if (respuesta == false)
                    {2
                        System.Console.WriteLine("YOU ARE GAY");
                        Console.ReadKey();
                    }
                    */
                    break;





                case 5:

                    int cntr = 11;
                    do
                    {
                        Console.WriteLine("Hello World" + cntr);
                        cntr++;
                        Console.ReadKey();


                    } while (cntr < 10);



                    break;


                case 6:

                    int cntr2 = 1;
                    while (cntr2 <= 5)
                    {
                        Console.WriteLine("Hello World" + cntr2);
                        cntr2++;
                        Console.ReadKey();


                    }



                    break;


                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
    }
}
