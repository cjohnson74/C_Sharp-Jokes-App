using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JokesWebApp.Controllers
{
    public class JokesController : Controller
    {
        // GET: Jokes
        public ActionResult Index()
        {
            return View();
        }

        // GET: Jokes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Jokes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Jokes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Jokes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Jokes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Jokes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Jokes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}