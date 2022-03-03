using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio.tres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a distancia percorrida" + " em Km: ");
            decimal.TryParse(Console.ReadLine(), out decimal kmPercorrido);

            Console.WriteLine("Informe o combustivel gasto" + " em litros: ");
            decimal.TryParse(Console.ReadLine(), out decimal litrosGastos);

            Console.WriteLine($"sua media foi de {kmPercorrido / litrosGastos}");
            Console.ReadLine();






        }
    }
}