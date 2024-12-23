﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EDental.Controllers
{
    public class TreatmentsController : Controller
    {
        // GET: TreatmentsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TreatmentsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TreatmentsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TreatmentsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: TreatmentsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TreatmentsController/Edit/5
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

        // GET: TreatmentsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TreatmentsController/Delete/5
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
