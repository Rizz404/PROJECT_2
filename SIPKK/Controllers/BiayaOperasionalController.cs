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
    public class BiayaOperasionalController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public BiayaOperasionalController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Dosens
        public IActionResult Index()
        {
            List<Dosen> dosenList = _unitOfWork.Dosen.GetAll().ToList();
            return View(dosenList);
        }

        // GET: Dosens/Details/5
        public IActionResult Details(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Dosen dosen = _unitOfWork.Dosen.Get(d => d.Id == id);

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
                _unitOfWork.Dosen.Create(obj);
                _unitOfWork.Save();
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

            Dosen? dosenFromDb = _unitOfWork.Dosen.Get(d => d.Id == id);

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
                _unitOfWork.Dosen.Update(obj);
                _unitOfWork.Save();
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

            Dosen? dosenFromDb = _unitOfWork.Dosen.Get(d => d.Id == id);

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
            Dosen? dosen = _unitOfWork.Dosen.Get(d => d.Id == id);

            if(dosen == null)
            {
                return NotFound();
            }
            _unitOfWork.Dosen.Delete(dosen);
            _unitOfWork.Save();
            TempData["Success"] = "Dosen deleted successfully";
            return RedirectToAction(nameof(Index));
        }
    }
}