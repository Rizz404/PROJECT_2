using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SIPKK.DataAccess.Data;
using SIPKK.DataAccess.Repository.IRepository;
using SIPKK.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Visus.Cuid;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SIPKK.Controllers
{
    public class DosenController : Controller
    {
        private readonly IDosenRepository _dosenRepo;

        public DosenController(IDosenRepository dosenRepo)
        {
            _dosenRepo = dosenRepo;
        }

        // GET: Dosens
        public IActionResult Index()
        {
            List<Dosen> dosenList = _dosenRepo.GetAll().ToList();
            return View(dosenList);
        }

        // GET: Dosens/Details/5
        public IActionResult Details(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Dosen dosen = _dosenRepo.Get(d => d.Id == id);

            if(dosen == null)
            {
                return NotFound();
            }

            return View(dosen);
        }

        // GET: Dosens/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dosens/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Dosen obj)
        {
            if(ModelState.IsValid)
            {
                _dosenRepo.Create(obj);
                _dosenRepo.Save();
                TempData["Success"] = "Dosen created successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(obj);
        }

        // GET: Dosens/Edit/5
        public IActionResult Edit(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Dosen? dosenFromDb = _dosenRepo.Get(d => d.Id == id);

            if(dosenFromDb == null)
            {
                return NotFound();
            }
            return View(dosenFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Dosen obj)
        {
            if(ModelState.IsValid)
            {
                _dosenRepo.Update(obj);
                _dosenRepo.Save();
                TempData["Success"] = "Dosen updated successfully";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: Dosens/Delete/5
        public IActionResult Delete(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Dosen? dosenFromDb = _dosenRepo.Get(d => d.Id == id);

            if(dosenFromDb == null)
            {
                return NotFound();
            }
            return View(dosenFromDb);
        }

        // POST: Dosens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(string id)
        {
            Dosen? dosen = _dosenRepo.Get(d => d.Id == id);

            if(dosen == null)
            {
                return NotFound();
            }
            _dosenRepo.Delete(dosen);
            _dosenRepo.Save();
            TempData["Success"] = "Dosen deleted successfully";
            return RedirectToAction(nameof(Index));
        }
    }
}