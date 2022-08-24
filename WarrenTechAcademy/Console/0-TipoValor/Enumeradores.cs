using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._0_TipoValor
{
    internal class Enumeradores
    {
        public static void Executar()
        {
            System.Console.WriteLine(DiasDaSemana.Segunda);

            System.Console.WriteLine((byte)DiasDaSemana.Segunda);
            System.Console.WriteLine((int)DiasDaSemana.Quarta);

            System.Console.WriteLine((DiasDaSemana)3);

            DiasDaSemana seg = DiasDaSemana.Segunda;
            System.Console.WriteLine(seg);

            DiasDaSemana ter = (DiasDaSemana)2;
            System.Console.WriteLine(ter);
        }
    }

    public enum DiasDaSemana
    {
        Domingo,
        Segunda,
        Terça,
        Quarta,
        Quinta,
        Sexta,
        Sábado
    }
}
