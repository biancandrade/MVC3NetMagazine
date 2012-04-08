using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC3NetMagazine.Models;

namespace MVC3NetMagazine.Controllers
{
      public class ComLayoutController : Controller
     {
         public ActionResult Index()
         {
            @ViewBag.Texto = "Conhecendo o ASP.NET MVC 3 com Vinicius Quaiato.";
           
            @ViewBag.Novidades = new List<string>
                                         {
                                            "Razor View Engine",
                                            "Dynamic View e ViewModel",
                                            "MasterPages com Razor",
                                            "ViewStart.cshtml"
                                        };

             return View();
        }
    }
}