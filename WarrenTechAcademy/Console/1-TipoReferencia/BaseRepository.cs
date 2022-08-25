using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    internal class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        List<T> list;

        public BaseRepository()
        {
            this.list = new List<T>();
        }

        public virtual string Create(T p)
        {
            this.list.Add(p);
            return $"O dado de id: {p.Id} foi salvo com sucesso!";
        }

        public virtual List<T> Read()
        {
            return list;
        }

        public virtual string Delete(int id)
        {
            return $"Cadastro com id: {id} foi deletado com sucesso!";
        }

        public virtual string Update(T p)
        {
            return $"Cadastro com id: {p.Id} foi alterado com sucesso!";
        }
    }
}
