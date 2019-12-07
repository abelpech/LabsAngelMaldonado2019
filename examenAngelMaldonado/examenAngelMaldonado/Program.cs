using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Abel Pech - Examen Ing. Angel Maldonado

namespace examenAngelMaldonado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Examen Final de Ing. Angel Maldonado");
            menu();
            Console.ReadKey();
        }

        public static void menu()
        {
            int opc;
            Console.WriteLine("\nSelecciona una opcion: \n1)Ejercicio 1\n2)Ejercicio 2\n3)Ejercicio 3\n4)Ejercicio 4\n5)Ejercicio 5\n6)SALIR ");
            opc = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch(opc)
                {
                    case 1:
                        ejercicioUno();
                        menu();
                        break;
                    case 2:
                        ejercicioDos();
                        menu();
                        break;
                    case 3:
                        ejercicioTres();
                        menu();
                        break;
                    case 4:
                        ejercicioCuatro();
                        menu();
                        break;
                    case 5:
                        ejercicioCinco();
                        menu();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\nSeleccione una opcion valida!!");
                        menu();
                        break;
                 
                }
            } while (opc!=5);

        }


        public static void ejercicioCinco()
        {
            for (int mm = 1; mm < 10; mm++)
            {
                Console.WriteLine("Hacer ejercicio y tomar suplementos");
            }
            Console.WriteLine("Se logro la masa muscular deseada");
        }

        public static void ejercicioCuatro()
        {
            string nombre;
            string apellido;
            Console.WriteLine("Favor de ingresar su primer nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Favor de ingresar su primer apellido: ");
            apellido = Console.ReadLine();
            if ((nombre == "angel" || nombre == "Angel" || nombre == "ANGEL") && (apellido == "maldonado" || apellido == "Maldonado" || apellido == "MALDONADO"))
            {
                Console.WriteLine(nombre + " " + apellido + " " + "Impartira la materia de desarrollo de software de plataformas propietarias I");
            }
            else if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
            {
                Console.WriteLine("Favor de ingresar los datos necesarios");
            }
            else
            {
                Console.WriteLine(nombre + " " + apellido + " Alumno de la materia de desarrollo de software de plataformas propietarias I");
            }

        }


        public static void ejercicioTres()
        {
            int opc = 0;
            Console.WriteLine("Selecciona una opcion: \n Opcion 2 \n Opcion 4 \n Opcion 6 \n Opcion 8");
            opc = Convert.ToInt32(Console.ReadLine());
            
            switch(opc)
            {
                case 2:
                    opc--;
                    if(opc >= 1)
                    {
                        Console.WriteLine(opc + "es mayor igual a 3");
                    }
                    else
                    {
                        Console.WriteLine("ERROR");
                    }
                    break;
                case 4:
                    bool bandera = false;
                    Console.WriteLine(!bandera);
                    break;
                case 6:
                    opc += opc;
                    Console.WriteLine(opc * 2);
                    break;
                case 8:
                    Console.WriteLine(-1 * (((opc + 5) * 8) / 2));
                    break;
                default:
                    Console.WriteLine("Ingresaste una opcion invalida");
                    break;            
            }

        }

        public static void ejercicioDos()
        {
            //Promedio
            float promHombres = 0, promMujeres = 0;
            //Tipo de dato BYTE 0-255
            byte[] edades = new byte[] { 28, 29, 30, 27, 22, 24, 25, 20 };

            for(int i = 0; i < edades.Length; i++)
            {
                if( i <= 3)
                {
                    promMujeres += edades[i];
                }
                if( i >= 4 && i <= 7)
                {
                    promHombres += edades[i];
                }
            }
            Console.WriteLine("Años promedio de mis amistades: ");
            Console.WriteLine("Hombres: " + promHombres/4 + " Mujeres: " + promMujeres/4);


        }


        public static void ejercicioUno()
        {
            string palabra1 = "Hola";
            string palabra2 = "Estimado";
            string palabra3, palabra4;

            Console.WriteLine("Favor de ingresar su primer nombre: ");
            palabra3 = Console.ReadLine();
            Console.WriteLine("Favor de ingresar su primer apellido: ");
            palabra4 = Console.ReadLine();
            Console.WriteLine("La oracion concatenada de 2 variables inicializadas y 2 ingresadas por User: ");
            Console.WriteLine(palabra1 + " " + palabra2 + " " + palabra3 + " " + palabra4);
        }
    }
}
