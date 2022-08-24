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
        }
    }
}
