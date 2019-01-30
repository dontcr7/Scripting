using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jeferson Alvare Mesa 321195
            int votos1 = 7;
            int votos2 = 0;
            int votosBlanco = 10;
            int votosAnulados = 0;
            int numeroPoblacion = 200;
            double porcentajeMayor = numeroPoblacion*0.7;

            int totalVotos = votos1 + votos2 + votosAnulados + votosBlanco;
            Console.WriteLine("total votos ="+totalVotos);
            Console.WriteLine("numero poblacion = " + numeroPoblacion);
            Console.WriteLine("total votos 10% = " + totalVotos*.1);
            Console.WriteLine("Porcentaje = " +porcentajeMayor*.3);

            if (totalVotos > numeroPoblacion || votos1 - votos2 < totalVotos * 0.1 && totalVotos < porcentajeMayor * 0.3)
            {
                Console.WriteLine("Deben hacerse nuevamente");
            }
            else Console.WriteLine("No hay problema");

            Console.ReadKey();
        }
    }
}
