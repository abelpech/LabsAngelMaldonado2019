using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesConsola2019
{

    
    class Program
    {

        static void excepcion() {

            try
            {
                Console.WriteLine("Escribir un numero que representa X: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escribir un numero que representa Y: ");
                int y = Convert.ToInt32(Console.ReadLine());
                int z = x / y;
            }
            catch (System.DivideByZeroException ex)
            {
                Console.WriteLine("Error");
                Console.WriteLine(ex);
            }
            
            catch (System.FormatException ex)
            {
                Console.WriteLine("Debe ser entero");
                Console.WriteLine(ex);
            }
            
            catch (Exception ex)
            {
                Console.WriteLine("Error Base");
            }
            finally
            {
                Console.WriteLine("Esto es un finally");
                Console.ReadKey();
            }
        }
        static int operacion(int x, int y)
        {
            if (x > y)
                return x / y;
            else
                return x * y;
        }
        static void Main(string[] args)
        {
            excepcion();
            /*
            int x, y;
            Console.WriteLine("Escribir un numero que representa X: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribir un numero que representa Y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La operacion de los numeros es: " + operacion(x, y));
            Console.ReadKey();

            */

        }
    }
}
