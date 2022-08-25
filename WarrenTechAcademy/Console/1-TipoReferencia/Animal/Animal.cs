using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    internal class Animal : BaseModel
    {
        public string Nome { get; set; }
        public string Especie { get; set; }

        public Animal(string nome, string especie)
        {
            this.Nome = nome;
            this.Especie = especie;
        }

        public virtual string ListarAnimal()
        {
            return $"\nEspécie: {this.Especie} \nNome: {this.Nome}";
        }
    }
}
