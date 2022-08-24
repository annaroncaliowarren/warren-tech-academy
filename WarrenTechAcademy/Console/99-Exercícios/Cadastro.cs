using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._99_Exercícios
{
    internal class Cadastro
    {
        // Crie um sistema de cadastro de pessoas
        // 1 - O sistema deve exibir uma mensagem de boas vindas
        // 2 - Deve solicitar as seguintes informações ao usuário:
        //      Nome, sobrenome e idade
        // 3 - Ao fim da execução, deve exibir o nome completo e idade, juntamente com mensagem
        // de despedida

        public void Cadastrar()
        {
            System.Console.WriteLine("Seja bem vindo! Vamos realizar um pequeno cadastro?");
            System.Console.Write("\nPrimeiro, digite seu primeiro nome: ");

            string name = System.Console.ReadLine();

            System.Console.Write("Agora, digite o seu sobrenome: ");

            string lastName = System.Console.ReadLine();

            System.Console.Write("Por último, a sua idade: ");

            byte age = Convert.ToByte(System.Console.ReadLine());
            //byte age = Byte.Parse(System.Console.ReadLine());   --> outro jeito de converter

            System.Console.WriteLine("\nSeu cadastro foi realizado com sucesso!");
            System.Console.WriteLine($"Nome completo: {name} {lastName} e idade: {age} anos");
            System.Console.WriteLine("Até a próxima!");
        }
            
    }
}
