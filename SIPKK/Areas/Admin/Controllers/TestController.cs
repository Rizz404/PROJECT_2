using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SIPKK.DataAccess.Data;
using SIPKK.DataAccess.Repository.IRepository;
using SIPKK.Models;
using SIPKK.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Visus.Cuid;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SIPKK.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    public class TestController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public TestController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Test
        public async Task<IActionResult> Index()
        {
            List<Test> testList = (await _unitOfWork.Test.GetAllAsync()).ToList();
            return View(testList);
        }

        // GET: Test/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Test test = await _unitOfWork.Test.GetAsync(d => d.Id == id);

            if(test == null)
            {
                return NotFound();
            }

            return View(test);
        }

        // GET: Test/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Test/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TestVM programStudiVM)
        {
            if(ModelState.IsValid)
            {
                await _unitOfWork.Test.CreateAsync(programStudiVM.Test);
                await _unitOfWork.SaveAsync();
                TempData["Success"] = "Test created successfully";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: Test/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Test? test = await _unitOfWork.Test.GetAsync(d => d.Id == id);

            if(test == null)
            {
                return NotFound();
            }

            TestVM programStudiVM = new()
            {
                Test = test,
            };

            return View(programStudiVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(TestVM programStudiVM)
        {
            if(ModelState.IsValid)
            {
                await _unitOfWork.Test.UpdateAsync(programStudiVM.Test);
                await _unitOfWork.SaveAsync();
                TempData["Success"] = "Test updated successfully";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: Test/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Test test = await _unitOfWork.Test.GetAsync(d => d.Id == id);

            if(test == null)
            {
                return NotFound();
            }

            return View(test);
        }

        // POST: Test/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            Test? test = await _unitOfWork.Test.GetAsync(d => d.Id == id);

            if(test == null)
            {
                return NotFound();
            }
            await _unitOfWork.Test.DeleteAsync(test);
            await _unitOfWork.SaveAsync();
            TempData["Success"] = "Test deleted successfully";
            return RedirectToAction(nameof(Index));
        }
    }
}