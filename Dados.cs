using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DADOS
{
    class Program
    {
        static void Main(string[] args)
        {
            // crear el objeto random
            Random dados = new Random();

            //Declarar la variable aleatoria oara los dos dados
            int dado1 = 0;
            int dado2 = 0;

            //Declaramos el contador de ountos acumulados
            int contador = 0;
            int sumadados = 0;

            //VAriables contadoras
            int mayorSeis = 0;
            int numeroLAnzados = 0;

            // declarar la variable de lanzamiento
            string lanzar = "";

            //Validar si desea lanzar 
            while (true)
            {

                dado1 = dados.Next(1, 6);
                dado2 = dados.Next(1, 6);
                
                

                Console.WriteLine("Desea arrojar los dados? s/n");
                lanzar = Console.ReadLine();

                Console.WriteLine("El resultado es: " + dado1 + "," + dado2);
                sumadados = dado1 + dado2;

                contador = contador + sumadados;
                Console.WriteLine("Su puntuacion es: "+contador);

                //Validamos los contadores
                if (sumadados > 6) mayorSeis++;
                Console.WriteLine("Mayores a seis: " + mayorSeis);

                numeroLAnzados++;
                Console.WriteLine("Lanzados: " + numeroLAnzados);

                //rompemos el ciclo
                if (lanzar != "s" || contador > 100)
                {
                    Console.WriteLine("Desea continuar? s/n");
                    string continuar = Console.ReadLine();

                    if (continuar != "s") break;
                    else lanzar = "s";

                }

            }

            Console.WriteLine("El porcentaje de turnos donde la suma fue mayor a 6 fue: " + mayorSeis * numeroLAnzados / 100 + "%");
            Console.ReadKey();

        }
    }
}
