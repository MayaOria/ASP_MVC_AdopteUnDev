using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projet_ASP.Handlers;
using Projet_ASP.Models;
using Projet_ASP.Models.HomeViewModel;
using Projet_BLL.Entities;
using Projet_Common.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_ASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDeveloperRepository<Developer, int> _servicesDev;
        private readonly IItLangRepository<ItLang, int> _servicesitLang;
        private readonly ICategoriesRepository<Categories, int> _servicescategories;
        private readonly IClientRepository<Client, int> _servicesClient;
        private readonly SessionManager _sessionManager;

        public HomeController(IDeveloperRepository<Developer, int> servicesDev, IItLangRepository<ItLang, int> servicesitLang, ICategoriesRepository<Categories, int> servicescategories, IClientRepository<Client, int> servicesClient, SessionManager sessionManager)
        {
            _servicesDev = servicesDev;
            _servicesitLang = servicesitLang;
            _servicescategories = servicescategories;
            _servicesClient = servicesClient;
            _sessionManager = sessionManager;
        }

        public IActionResult Index()
        {
            IndexModel model = new IndexModel();
            model.Developers = _servicesDev.Get().Select(e => e.ToListItem());
            model.Categories = _servicescategories.Get().Select(e=>e.ToListItem());
            model.ItLangs = _servicesitLang.Get().Select(e => e.ToListItem());
            return View(model);
        }

        

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Login(LoginForm form)
        {
            if (!ModelState.IsValid) return View();
            int? id = _servicesClient.CheckPassword(form.CliLogin, form.CliPassword);
            if (id == null) return View();
            CurrentUser currentUser = new CurrentUser()
            {
                IdUser = (int)id,
                Login = form.CliLogin,
                LastConnection = DateTime.Now
            };

            //Va enregistrer le currentUser dans la session grâce au set mis en place dans la propriété currentUser du Session Manager
            _sessionManager.currentUser = currentUser;

            return RedirectToAction("Index");

        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

    }
}
