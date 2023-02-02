using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projet_ASP.Handlers;
using Projet_ASP.Models.DeveloperViewModel;
using Projet_BLL.Entities;
using Projet_Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_ASP.Controllers
{
    public class DeveloperController : Controller
    {
        private readonly IDeveloperRepository<Developer, int> _services;

        public DeveloperController(IDeveloperRepository<Developer, int> services)
        {
            _services = services;
        }

        // GET: DeveloperController
        public ActionResult Index()
        {
            IEnumerable<DeveloperListItem> model = _services.Get().Select(e => e.ToListItem());

            return View(model);
        }

        // GET: DeveloperController/Details/5
        public ActionResult Details(int id)
        {
            DeveloperDetails model = _services.Get(id).ToDetails();
            if (model is null)
            {
                TempData["Error"] = "Ce développeur n'a pas été trouvé...";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: DeveloperController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DeveloperController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DeveloperCreateForm form)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
               int id = _services.Insert(form.ToBLL());
                return RedirectToAction("Details", "Developer", new { id = id });
            }
        }

        // GET: DeveloperController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DeveloperController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DeveloperController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DeveloperController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
