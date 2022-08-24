using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._0_TipoValor
{
    internal class TipoBooleano
    {
        public static void Executar()
        {
            bool gostaDeBanda = true;
            Boolean naoGostaDeBanda = false;

            bool ehMaior = 10 > 11;
            bool ehIgual = 10 + 11 == 21;

            if (ehMaior)
            {
                System.Console.WriteLine("É maior");
            }
            else
            {
                System.Console.WriteLine("É menor");
            }
        }
    }
}
