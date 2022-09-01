using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class ProdutoController : GenericController<ProdutoModel, ProdutoRepository>
    {
    }
}
