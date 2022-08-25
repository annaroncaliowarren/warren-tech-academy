using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    internal class TestaPessoas
    {
        public static void ExecutarPessoa()
        {
            Pessoa p = new Pessoa("Anna", "Roncalio");
            Pessoa pf = new PessoaFisica("Anna Cecilia", "Roncalio", "25684599835");
            Pessoa pj = new PessoaJuridica("Anna C", "Roncalio", "56842563000122");

            PessoaFisica pf2 = (PessoaFisica)pf;  // tem que converter explicitamente porque ele entende que pf é uma pessoa
            PessoaJuridica pj2 = (PessoaJuridica)pj;

            BaseRepository<Pessoa> baseRepository = new BaseRepository<Pessoa>();
            baseRepository.Create(p);
            baseRepository.Create(pf2);
            baseRepository.Create(pj2);

            foreach (var pessoa in baseRepository.Read())
            {
                System.Console.WriteLine(pessoa.Saudacao());
            }
        }
    }
}
