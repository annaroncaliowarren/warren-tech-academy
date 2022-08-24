using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._0_TipoValor
{
    internal class Estruturas
    {
        public static void Executar()
        {
            PessoaClasse p1 = new PessoaClasse();
            p1.Nome = "Chimbinha";

            PessoaStruct p2 = new PessoaStruct();
            p2.Nome = "Joelma";

            System.Console.WriteLine(p1); // imprime o namespace por padrão
            System.Console.WriteLine(p1.Nome);
            System.Console.WriteLine(p2.Nome);

            PessoaClasse p3 = new PessoaClasse(); // aponta para a mesma área de memória (por referência) por isso se altera um altera o outro também
            p3 = p1;

            PessoaStruct p4 = new PessoaStruct(); // cria uma nova área de memória (uma cópia) então quando modifica um não modifica o outro
            p4 = p2;

            System.Console.WriteLine(p3.Nome);
            System.Console.WriteLine(p4.Nome);

            p1.Nome = "Chimbinha - melhor guitarrista do mundo";
            p2.Nome = "Joelma - melhor cantora do mundo";

            System.Console.WriteLine("\nValores alterados");
            System.Console.WriteLine(p1.Nome);
            System.Console.WriteLine(p2.Nome);
            System.Console.WriteLine(p3.Nome);
            System.Console.WriteLine(p4.Nome);

        }
    }
    struct PessoaStruct // tipo por valor
    {
        public string Nome { get; set; } 
        public string Sobrenome { get; set; }
        public byte Idade { get; set; }
    }
    class PessoaClasse // tipo por referência
    {
        // public int MyProperty { get; set; } --> isso substitui escrever getter e setter para todos os campos (Propriedade - prop)
        public string Nome { get; set; } // get e set do campo nome e ele já entende que tem um campo private não precisa ser declarado
        public string Sobrenome { get; set; }
        public byte Idade { get; set; }

        // isso vai ser substituido
        // private string nome;
        // private string sobrenome;
        // private byte idade;

        // public string GetNome()
        // {
        //    return this.nome;
        // }

        // public void SetNome(string nome)
        // {
        //    this.nome = nome;
        // }
    }
}
