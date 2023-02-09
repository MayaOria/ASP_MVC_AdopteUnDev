using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projet_ASP.Handlers;
using Projet_ASP.Models.ClientViewModel;
using Projet_BLL.Entities;
using Projet_Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_ASP.Controllers
{

    public class ClientController : Controller
    {

        private readonly IClientRepository<Client, int> _services;

        public ClientController(IClientRepository<Client, int> services)
        {
            _services = services;
        }

        

        // GET: ClientController/Details/5
        public ActionResult Details(int id)
        {
            ClientDetails model = _services.Get(id).ToDetails();
            return View();
        }

        // GET: ClientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClientCreateForm form)
        {
            if (!ModelState.IsValid)
            {
                form.CliPassword = null;
                form.ConfirmPass = null;
                return View();
            }
            else
            {
                int id = _services.Insert(form.ToBLL());
                return RedirectToAction("Index", "Home");
            }
        }

        


    }
}
