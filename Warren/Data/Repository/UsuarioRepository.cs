using Data.Model;
using Data.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class UsuarioRepository : BaseRepository<UsuarioModel>
    {
        public override Dictionary<string, dynamic> Create(UsuarioModel model)
        {
            model.Senha = Criptografia.Criptografar(model.Senha);
            return base.Create(model);
        }

        public override Dictionary<string, dynamic> Update(UsuarioModel model)
        {
            model.Senha = Criptografia.Criptografar(model.Senha);
            return base.Update(model);
        }
    }
}
