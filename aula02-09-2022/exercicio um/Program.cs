using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_um
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor em R$:  ");
            string valorDigitado = Console.ReadLine();
            decimal valorConvertido = 0.0m;
            decimal valorCambio = 0.1932m;

            decimal.TryParse(valorDigitado, out valorConvertido);
            decimal valorCambioConvertido = valorConvertido * valorCambio;    
            Console.WriteLine($"valor em : {valorCambioConvertido}");
            Console.ReadLine();
        }
    }
}
