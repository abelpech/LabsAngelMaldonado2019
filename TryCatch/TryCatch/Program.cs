using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {

            Try();

        }



        public static void Try()
        {

            try
            {

                
                


                Console.WriteLine("Escrbribe el numero 1");
                int a =  Convert.ToInt32( Console.ReadLine());

                Console.WriteLine("Escrbribe el numero 2");
                int b = Convert.ToInt32(Console.ReadLine());

                int c = a / b;

                Console.WriteLine("Este es el resultado" + " " + c );
                

            }
            //CLASE DE ERROR POR DIVIDIR EN CERO
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("ERROR POR DIVIDIR POR CERO");

            }
            //  catch (FormatException ex1)
            //{
            //   Console.WriteLine("ERROR POR USAR ENTEROS");

            //}



            //CLASE MADRE DE LOS ERRORES
            catch (Exception ex)
            {
                //Console.WriteLine("ERROR POR USAR ENTEROS");
                Console.WriteLine("ERROR POR DIVIDIR POR CERO");
            }

            finally
            {   //SE EJECUTA SALGA O NO SALGA EL ERROR
                Console.WriteLine("El programa se cerrara");
                Console.ReadKey();
            }

        }
    }
}
