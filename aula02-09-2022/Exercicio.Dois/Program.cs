using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Dois
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor em dolar: ");
            String valorDigitado = Console.ReadLine();
            Decimal valorConvertido = 0.0m;
            Decimal valorCambio = 5.22m;

            decimal.TryParse( valorDigitado, out valorConvertido);
            decimal valorCambioConvertido = valorConvertido * valorCambio;
            Console.WriteLine($"valor em = {valorCambioConvertido}");    
            Console.ReadLine();
        }
    }
}
