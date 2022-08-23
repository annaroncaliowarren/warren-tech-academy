using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    internal class BemVindo
    {
        // passa argumento recebe parâmetro
        public static void Mensagem()
        {
            System.Console.WriteLine("Seja bem vindo");
            System.Console.WriteLine("Digite seu nome: ");
            string name = System.Console.ReadLine();
            System.Console.WriteLine("Até breve, " + name);
            System.Console.ReadLine();
        }
    }
}
