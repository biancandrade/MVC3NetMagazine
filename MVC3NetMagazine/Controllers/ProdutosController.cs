using System.Collections.Generic;
using System.Web.Mvc;
using MVC3NetMagazine.Models;

namespace MVC3NetMagazine.Controllers
{
    public class ProdutosController : Controller
    {
        //
        // GET: /Produto/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar()
        {
            var produtos = new List<Produto>
            {
                new Produto {Id = 10, Descricao = "Livro ASP.NET MVC", Valor = 50.35},
                new Produto {Id = 3, Descricao = "Celular moderno", Valor = 150.99},
                new Produto {Id = 120, Descricao = "Powerball", Valor = 22.99},
                new Produto {Id = 876, Descricao = "Caneca para café", Valor = 9.75},
                new Produto {Id = 13, Descricao = "Livro Design Patterns", Valor = 43.23}
            };

            return View(produtos);
        }
    }
}