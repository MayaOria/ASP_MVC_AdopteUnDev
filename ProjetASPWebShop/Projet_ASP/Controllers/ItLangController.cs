using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projet_ASP.Handlers;
using Projet_ASP.Models.ItLangViewModels;
using Projet_BLL.Entities;
using Projet_Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_ASP.Controllers
{
    public class ItLangController : Controller
    {
        private readonly IItLangRepository<ItLang, int> _services;

        public ItLangController(IItLangRepository<ItLang, int> services)
        {
            _services = services;
        }

        // GET: ItLangController
        public ActionResult Index()
        {
            IEnumerable<ItLangListItem> model = _services.Get().Select(e => e.ToListItem());

            return View(model);
        }

        // GET: ItLangController/Details/5
        public ActionResult Details(int id)
        {
            ItLangDetails model = _services.Get(id).ToDetails();
            if(model is null)
            {
                TempData["Error"] = "Ce language n'a pas été trouvé...";
                    return RedirectToAction("Index");
            }
            return View(model);
        }

       
    }
}
