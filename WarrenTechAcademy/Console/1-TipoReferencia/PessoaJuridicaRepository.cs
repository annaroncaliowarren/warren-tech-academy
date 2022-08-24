using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    internal class PessoaJuridicaRepository
    {
        private List<PessoaJuridica> pessoas;
        public PessoaJuridicaRepository()
        {
            this.pessoas = new List<PessoaJuridica>();
        }

        public string Create(PessoaJuridica pessoa)
        {
            this.pessoas.Add(pessoa);
            return $"Cadastro de {pessoa.Nome} salvo com sucesso!";
        }

        public List<PessoaJuridica> Read()
        {
            return pessoas;
        }

        public string Update(PessoaJuridica pessoa)
        {
            return $"Cadastro {pessoa.Nome} foi alterado com sucesso!";
        }

        public string Delete(int id)
        {
            return $"Cadastro com id: {id} foi deletado com sucesso!";
        }
    }
}
