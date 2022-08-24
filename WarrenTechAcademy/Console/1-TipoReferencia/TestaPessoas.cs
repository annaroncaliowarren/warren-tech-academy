using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    internal class TestaPessoas
    {
        public static void ExecutarFisica()
        {
            PessoaFisica pessoaFisica1 = new PessoaFisica("Anna", "Roncalio", "07548266925");
            PessoaFisica pessoaFisica2 = new PessoaFisica("Djonathan", "Krause", "25686495623");

            PessoaFisicaRepository pessoaFisicaRepository = new PessoaFisicaRepository();

            string msg = pessoaFisicaRepository.Create(pessoaFisica1);
            pessoaFisicaRepository.Create(pessoaFisica2);
            System.Console.WriteLine(msg);

            System.Console.WriteLine(pessoaFisicaRepository.Update(pessoaFisica2));
            System.Console.WriteLine(pessoaFisicaRepository.Delete(2));

            List<PessoaFisica> pessoasFisicas = pessoaFisicaRepository.Read();
            foreach (PessoaFisica p in pessoasFisicas)  // pode ser usado o tipo especifico ou var
            {
                System.Console.WriteLine(p.Saudacao());
            }
        }
        public static void ExecutarJuridica()
        {
            PessoaJuridica pessoaJuridica = new PessoaJuridica("João", "Roncalio", "46256382000122");
            PessoaJuridica pessoaJuridica2 = new PessoaJuridica("Magda", "Carneiro", "46256782000122");

            PessoaJuridicaRepository pessoaJuridicaRepository = new PessoaJuridicaRepository();
            pessoaJuridicaRepository.Create(pessoaJuridica);
            pessoaJuridicaRepository.Create(pessoaJuridica2);

            List<PessoaJuridica> pessoasJuridicas = pessoaJuridicaRepository.Read();
            foreach (PessoaJuridica p in pessoasJuridicas)
            {
                System.Console.WriteLine(p.Saudacao());
            }
        }
    }
}
