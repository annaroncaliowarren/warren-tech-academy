using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    internal class BaseRepository : IRepository
    {
        List<Pessoa> pessoas;

        public BaseRepository()
        {
            this.pessoas = new List<Pessoa>();
        }

        public string Create(Pessoa p)
        {
            this.pessoas.Add(p);
            return $"Cadastro de {p.Nome} salvo com sucesso!";
        }

        public List<Pessoa> Read()
        {
            return pessoas;
        }

        public string Delete(int id)
        {
            return $"Cadastro com id: {id} foi deletado com sucesso!";
        }

        public string Update(Pessoa p)
        {
            return $"Cadastro {p.Nome} foi alterado com sucesso!";
        }
    }
}
