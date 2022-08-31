using Data.Context;
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

        public UsuarioModel Logon(string email, string senha)
        {
            senha = Criptografia.Criptografar(senha);
            UsuarioModel usuario = new UsuarioModel();

            using (WarrenContext contexto = new WarrenContext())
            {
                usuario = contexto.Usuario.Where(u => u.Email == email && u.Senha == senha).FirstOrDefault();
            }

            return usuario;
        }
    }
}
