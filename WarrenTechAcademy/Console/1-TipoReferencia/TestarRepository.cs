using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    internal class Testar
    {
        public static void ExecutarPessoa()
        {
            Pessoa p = new Pessoa("Anna", "Roncalio");
            Pessoa pf = new PessoaFisica("Anna Cecilia", "Roncalio", "25684599835");
            Pessoa pj = new PessoaJuridica("Anna C", "Roncalio", "56842563000122");

            PessoaFisica pf2 = (PessoaFisica)pf;  // tem que converter explicitamente porque ele entende que pf é uma pessoa
            PessoaJuridica pj2 = (PessoaJuridica)pj;

            PessoaFisicaRepository pfRepository = new PessoaFisicaRepository();
            pfRepository.Create(pf2);

            foreach (var pessoaFisica in pfRepository.Read())
            {
                System.Console.WriteLine(pessoaFisica.Saudacao());
            }
        }

        public static void ExecutarProduto()
        {
            Produto produto = new Produto("Caneta", "Caneta BIC (cor azul)");
            Produto produto2 = new Produto("Livro", "Livro de Programação");

            ProdutoRepository produtoRepository = new ProdutoRepository();
            produtoRepository.Create(produto);
            produtoRepository.Create(produto2);

            foreach (var prod in produtoRepository.Read())
            {
                System.Console.WriteLine($"\nProduto: {prod.Nome} - Descrição: {prod.Descricao}");
            }
        }

        public static void ExecutarAnimal()
        {
            Animal a1 = new Animal("Janis", "Cachorro");
            Animal a2 = new Animal("Cigana", "Cachorro");
            Animal a3 = new Animal("Pingo", "Gato");

            AnimalRepository animalRepository = new AnimalRepository();
            animalRepository.Create(a1);
            animalRepository.Create(a2);
            animalRepository.Create(a3);

            foreach (var animal in animalRepository.Read())
            {
                System.Console.WriteLine($"\nEspécie: {animal.Especie} \nNome: {animal.Nome}");
            }
        }
    }
}
