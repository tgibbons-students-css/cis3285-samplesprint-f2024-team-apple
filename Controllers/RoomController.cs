﻿using Humanizer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CIS3285_Unit3Sample_2024.Controllers
{

    //As a message posting user, I want to create rooms for categorizing conversations -- Miles L

    public class RoomController : Controller
    {
        // GET: RoomController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RoomController/Details/5
        public ActionResult Details(int id)
        {
            //Miles L -- Editing
            return View();
        }

        // GET: RoomController/Create
        public ActionResult Create()
        {
            //Miles L -- Editing
            return View();
        }

        // POST: RoomController/Create
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

        // GET: RoomController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RoomController/Edit/5
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

        // GET: RoomController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RoomController/Delete/5
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
