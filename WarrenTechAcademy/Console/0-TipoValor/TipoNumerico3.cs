using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._0_TipoValor
{
    internal class TipoNumerico3
    {
        public static void Executar()
        {
            float floatMin = float.MinValue; // (-3,402823E+38 até 3,402823E+38) = single
            float floatMax = float.MaxValue;
            System.Console.WriteLine("float: " + floatMin + " até " + floatMax);

            double doubleMin = double.MinValue; // Dobro de bits do float (-1,79769313486232E+308 até 1,79769313486232E+308)
            double doubleMax = double.MaxValue;
            System.Console.WriteLine("double: " + doubleMin + " até " + doubleMax);

            decimal decimalMin = decimal.MinValue; // (-79228162514264337593543950335 até 79228162514264337593543950335)
            decimal decimalMax = decimal.MaxValue;
            System.Console.WriteLine("decimal: " + decimalMin + " até " + decimalMax);

            // ele completa com 999... os espaços vazios para completar o tamanho do double, por isso não é igual
            double n1 = 10.1;
            double n2 = 20.2;
            double result = 30.3;

            System.Console.WriteLine($"\n{n1 + n2} - {result}");
            System.Console.WriteLine((n1 + n2) == result);

            // tipo usado para transações monetárias
            decimal n1d = 10.1m;
            decimal n2d = 20.2m;
            decimal resultd = 30.3m;

            System.Console.WriteLine($"\n{n1d + n2d} - {resultd}");
            System.Console.WriteLine((n1d + n2d) == resultd);

        }
    }
}
