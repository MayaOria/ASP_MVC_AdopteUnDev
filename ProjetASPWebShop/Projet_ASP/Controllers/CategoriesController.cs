using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projet_ASP.Handlers;
using Projet_ASP.Models.CategoriesViewModels;
using Projet_BLL.Entities;
using Projet_Common.Entities;
using Projet_Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_ASP.Controllers
{
    
    public class CategoriesController : Controller
    {
        private readonly ICategoriesRepository<Categories, int> _services;

        public CategoriesController(ICategoriesRepository<Categories, int> services)
        {
            _services = services;
        }

        // GET: CategoriesController
        public ActionResult Index()
        {
            IEnumerable<CategoriesListItem> model = _services.Get().Select(e => e.ToListItem());

            return View(model);
        }

        // GET: CategoriesController/Details/5
        public ActionResult Details(int id)
        {
            CategoriesDetails model = _services.Get(id).ToDetails();
            if(model is null)
            {
                TempData["Error"] = "Cette catégorie n'a pas été retrouvée...";
                return RedirectToAction("Index");
            }
            return View(model);
        }

    }
}
