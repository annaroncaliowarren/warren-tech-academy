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
            // Para plataforma .NET que pode ser usado vários tipos de linguagem se usa o objeto (Byte) para tipar corretamente
            // Se usar apenas C# pode ser usado apenas o tipo (byte)

            byte byteMin = Byte.MinValue;  // 8 Bits (pode ser até 256 = 255 + 0)
            byte byteMax = Byte.MaxValue;  // descobrir o valor min e max desse tipo
            System.Console.WriteLine("Byte: " + byteMin + " até " + byteMax);

            sbyte sbyteMin = SByte.MinValue; // 8 bits com números negativos (-128 até 127)
            sbyte sbyteMax = sbyte.MaxValue;
            System.Console.WriteLine("sbyte: " + sbyteMin + " até " + sbyteMax);

            short shortMin = short.MinValue; // 16 bits com números negativos (-32768 até 32767) = Int16
            short shortMax = short.MaxValue;
            System.Console.WriteLine("short: " + shortMin + " até " + shortMax);

            ushort ushortMin = ushort.MinValue; // 16 bits apenas números positivos (0 até 65535)
            ushort ushortMax = ushort.MaxValue;
            System.Console.WriteLine("ushort: " + ushortMin + " até " + ushortMax);

            int intMin = int.MinValue; // 32 bits com números negativos (-2147483648 até 2147483647)
            int intMax = int.MaxValue;
            System.Console.WriteLine("int: " + intMin + " até " + intMax);

            uint uintMin = uint.MinValue; // 32 bits apenas números positivos (0 até 4294967295)
            uint uintMax = uint.MaxValue;
            System.Console.WriteLine("uint: " + uintMin + " até " + uintMax);

            long longMin = long.MinValue; // 64 bits com números negativos (-9223372036854775808 até 9223372036854775807) = Int64
            long longMax = long.MaxValue;
            System.Console.WriteLine("long: " + longMin + " até " + longMax);

            ulong ulongMin = ulong.MinValue; // 64 bits apenas números positivos (0 até 18446744073709551615) 
            ulong ulongMax = ulong.MaxValue;
            System.Console.WriteLine("ulong: " + ulongMin + " até " + ulongMax);

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
