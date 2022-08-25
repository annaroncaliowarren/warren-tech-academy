using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    internal class Produto : BaseModel
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public Produto(string nome, string descricao)
        {
            this.Nome = nome;
            this.Descricao = descricao;
        }

        public virtual string ListarProduto()
        {
            return $"\nProduto: {this.Nome} - Descrição: {this.Descricao}";
        }
    }
}
