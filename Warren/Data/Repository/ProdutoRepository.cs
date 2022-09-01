using Data.Context;
using Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class ProdutoRepository : BaseRepository<ProdutoModel>
    {
        public override List<ProdutoModel> GetAll()
        {
            List<ProdutoModel> list = new List<ProdutoModel>();

            using (WarrenContext context = new WarrenContext())
            {
                list = context.Produto.Include("Categoria").ToList();
            }

            return list;
        }
    }
}
