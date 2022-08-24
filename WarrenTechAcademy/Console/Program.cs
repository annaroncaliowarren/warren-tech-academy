using Console._0_TipoValor;
using Console._1_TipoReferencia;
using Console._99_Exercícios;
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
            //BemVindo.Mensagem(); //Chamada de método estático

            //TipoNumerico tipoNumerico = new TipoNumerico(); //Chamada como objeto
            //tipoNumerico.Executar();

            //TipoNumerico2.Executar();

            //new Cadastro().Cadastrar(); // outro jeito de chamar o método

            //TipoNumerico3.Executar();

            //TipoBooleano.Executar();

            //Enumeradores.Executar();

            //Enumeradores2.Executar();

            //Estruturas.Executar();

            TestaPessoas.ExecutarFisica();
            TestaPessoas.ExecutarJuridica();

            System.Console.Read();
        }
    }
}
