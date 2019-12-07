using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            switchAnidado();
            //claseJulio2();
            
        }


        static int Edad(int num1, int num2) {

            return num1 + num1;

        }

        static void switchAnidado() {
            //Pregunta si eres alumno o maestro
            // si eres alumno te manda al otro switch donde pedimos un input (matricula) y arroja la calificacion predefinida
            Console.WriteLine("¿Eres Alumno o Maestro\n\nSelecciona una opcion: \n1.-Alumno\n2.-Maestro");
            String opc = Console.ReadLine();
            switch (Convert.ToInt32(opc))
            {
                case 1:
                    Console.WriteLine("¿Cual es tu matricula?");
                    string matricula = Console.ReadLine();
                    switch (Convert.ToInt32(matricula)) {
                        case 123:
                            Console.WriteLine("Sacaste un 100");
                            break;
                        case 456:
                            Console.WriteLine("Sacaste un 80");
                            break;
                        case 789:
                            Console.WriteLine("Sacaste un 60");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Felicidades! Eres un maestro");
                    break;
                default:
                    Console.WriteLine("Opcion Inexistente");
                    break;
                    
            }
            Console.ReadKey();

        }
        static void claseJulio2() {
            //Declarar un arreglo y asignar los valores
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            int entrar = 1;
            int suma = 0;
            // Hacer una captura y grabarlo en un entero
            Console.WriteLine("Favor de ingresar a numero a capturar");
            String captura = Console.ReadLine();
            // Sumar del arreglo y lo capturo
            for (int i = 0; i < array.Length; i++) {
                suma = array[i] + Convert.ToInt32(captura);
                switch (entrar) {
                    case 1:
                        if (suma < 3) 
                        Console.WriteLine("Es menor que 3");
                        if (suma >= 3 && suma < 10)
                            Console.WriteLine("El valor es mayor que 3 y menor que 10");
                        break;

                    default:
                        Console.WriteLine("Sigue intentando");
              
                        break;
                }
                Console.ReadKey();
            
            }


            //Resultado es menor que 3, despliegas un texto que es menor que 3

            // Resultado es igual y mayor que 3 y menor que 10. Despliegas un mensaje

            //Default / Adivinar
       
        }
        static void claseJulio1() {
            //Defining and assigning an element at the same time
            int[] array2 = new int[5];
            //Initiliaze with 5 elements without indicating the size of an array
            int[] array3 = new int[] { 1, 2, 3, 4, 5 };
            //Another way to initialize an array without size
            int[] array4 = { 1, 2, 3, 4, 5 };
            //Declare an array without initialization nor elements assignment


            //Declare an array of 9 elements and assign them
            //Declare another array of 9 elements but only assign 5 elements
            
            int[] array5 = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] array6 = new int[9] ;

            array6[0] = 1;
            array6[1] = 2;
            array6[2] = 3;
            array6[3] = 4;
            array6[4] = 5;

            //Print element number 5 of 1st array
            Console.WriteLine(array5[5]);
            //Print empty element of 2nd array
            Console.WriteLine(array6[5]);
            Console.ReadKey();
        }
    }
}
