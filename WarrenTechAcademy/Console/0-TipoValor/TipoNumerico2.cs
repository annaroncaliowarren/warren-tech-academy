using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._0_TipoValor
{
    internal class TipoNumerico2
    {
        public static void Executar()
        {
            char letra = '/';
            char charMin = char.MinValue;
            char charMax = char.MaxValue;
            System.Console.WriteLine(letra + " : " + (byte)letra);
            System.Console.WriteLine("char: " + charMin + " até " + charMax);

            float floatMin = float.MinValue; // (-3,402823E+38 até 3,402823E+38)
            float floatMax = float.MaxValue;
            System.Console.WriteLine("float: " + floatMin + " até " + floatMax);

            double doubleMin = double.MinValue; // (-1,79769313486232E+308 até 1,79769313486232E+308)
            double doubleMax = double.MaxValue;
            System.Console.WriteLine("double: " + doubleMin + " até " + doubleMax);

            decimal decimalMin = decimal.MinValue; // (-79228162514264337593543950335 até 79228162514264337593543950335)
            decimal decimalMax = decimal.MaxValue;
            System.Console.WriteLine("decimal: " + decimalMin + " até " + decimalMax);
        }
    }
}
