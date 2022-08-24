using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._0_TipoValor
{
    internal class Enumeradores2
    {
        public static void Executar()
        {
            System.Console.WriteLine(DiasDaSemana2.DOM);

            DiasDaSemana2 diasPresenciais = (DiasDaSemana2)20;  // soma dos valores dos dias que você quer mostrar
            System.Console.WriteLine(diasPresenciais);
        }
    }
    [Flags]
    public enum DiasDaSemana2
    {
        DOM = 1,
        SEG = 2,
        TER = 4,
        QUA = 8,
        QUI = 16,
        SEX = 32,
        SAB = 64
    }
}
