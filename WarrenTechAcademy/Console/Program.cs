using Console._0_TipoValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BemVindo.Message(); //Chamada de método estático
            
            ValueType1 valueType1 = new ValueType1(); //Chamada como objeto
            valueType1.Execute();
            
            System.Console.Read();
        }
    }
}
