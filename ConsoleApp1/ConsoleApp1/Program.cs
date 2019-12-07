using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declara una variable tipo String con tu nombre como valor
            string nombre = "Abel";

            // Declara una constante con un valor predeterminado
            int constante = 10;

            
            Console.WriteLine("Hola {0}, Captura tu apellido", nombre);
        
            string apellido = Console.ReadLine();
            Console.WriteLine("Bienvenido {0} {1}", nombre, apellido);

            //Declarar una variable numerica y captura 1 para despues sumarlos.
            Console.WriteLine("Ingresa un numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tu numero {0} + la constante {1} es igual a {2} ", numero, constante, numero + constante);

            // Utilizar Booleans y probar con una frase para desplegar si es verdadero o falso
            // Constantes en mayusculas

            bool CALUROSO = false;
            Console.WriteLine("Vamos a probar la variable CALUROSO");
            Console.WriteLine("VALOR : {0}", CALUROSO);
            Console.WriteLine("Por lo tanto: ");

            if (CALUROSO)
                Console.WriteLine("Se me antoja una nieve de chocolate");
            else
            {
                Console.WriteLine("Me comprare una chamarra para el frio");
            }


            Console.ReadKey();

        }
    }
}
