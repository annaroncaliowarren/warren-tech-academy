using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._0_TipoValor
{
    internal class ValueType1
    {
        public void Execute()
        {
            byte byteMin = Byte.MinValue;  // 8 Bits (pode ser até 256 = 255 + 0)
            byte byteMax = Byte.MaxValue;  // descobrir o valor min e max desse tipo
            System.Console.WriteLine("Byte: " + byteMin + " até " + byteMax);

            sbyte sbyteMin = sbyte.MinValue; // 8 bits aceitando negativo (-128 até 127)
            sbyte sbyteMax = sbyte.MaxValue;
            System.Console.WriteLine("sbyte: " + sbyteMin + " até " + sbyteMax);
        }
    }
}
