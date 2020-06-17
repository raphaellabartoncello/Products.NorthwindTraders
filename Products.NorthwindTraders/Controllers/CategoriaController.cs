using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Products.NorthwindTraders.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Index()
        {
            var db = new CategoriaDb();
            var lista = db.CategoriasLista();
            return View(lista);
        }
    }
}