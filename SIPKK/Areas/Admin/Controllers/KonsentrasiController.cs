using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SIPKK.DataAccess.Repository.IRepository;
using SIPKK.Models;
using SIPKK.Models.ViewModels;

namespace SIPKK.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    [Authorize(Roles = nameof(Admin))]
    public class KonsentrasiController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public KonsentrasiController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Konsentrasi
        public async Task<IActionResult> Index()
        {
            List<Konsentrasi> konsentrasiList = (await _unitOfWork.Konsentrasi.FindAllAsync(include: q => q.Include(k => k.ProgramStudi))).ToList();
            return View(konsentrasiList);
        }

        // GET: Konsentrasi/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Konsentrasi konsentrasi = await _unitOfWork.Konsentrasi.FindAsync(d => d.Id == id);

            if(konsentrasi == null)
            {
                return NotFound();
            }

            return View(konsentrasi);
        }

        // GET: Konsentrasi/Create
        public async Task<IActionResult> Create()
        {
            // biar miftah
            KonsentrasiVM konsentrasiVM = new()
            {
                ProgramStudiList = (await _unitOfWork.ProgramStudi.FindAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.Nama,
                    Value = p.Id
                }),
            };

            return View(konsentrasiVM);
        }

        // POST: Konsentrasi/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(KonsentrasiVM konsentrasiVM)
        {
            if(ModelState.IsValid)
            {
                await _unitOfWork.Konsentrasi.CreateAsync(konsentrasiVM.Konsentrasi);
                await _unitOfWork.SaveAsync();
                TempData["Success"] = "Konsentrasi created successfully";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                konsentrasiVM.ProgramStudiList = (await _unitOfWork.ProgramStudi.FindAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.Nama,
                    Value = p.Id
                });
                return View(konsentrasiVM);
            }
        }

        // GET: Konsentrasi/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Konsentrasi? konsentrasi = await _unitOfWork.Konsentrasi.FindAsync(d => d.Id == id);

            if(konsentrasi == null)
            {
                return NotFound();
            }

            KonsentrasiVM konsentrasiVM = new()
            {
                Konsentrasi = konsentrasi,
                ProgramStudiList = (await _unitOfWork.ProgramStudi.FindAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.Nama,
                    Value = p.Id
                }),
            };

            return View(konsentrasiVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(KonsentrasiVM konsentrasiVM)
        {
            if(ModelState.IsValid)
            {
                await _unitOfWork.Konsentrasi.UpdateAsync(konsentrasiVM.Konsentrasi);
                await _unitOfWork.SaveAsync();
                TempData["Success"] = "Konsentrasi updated successfully";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                konsentrasiVM.ProgramStudiList = (await _unitOfWork.ProgramStudi.FindAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.Nama,
                    Value = p.Id
                });
                return View(konsentrasiVM);
            }
        }

        // GET: Konsentrasi/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Konsentrasi konsentrasi = await _unitOfWork.Konsentrasi.FindAsync(d => d.Id == id);

            if(konsentrasi == null)
            {
                return NotFound();
            }

            return View(konsentrasi);
        }

        // POST: Konsentrasi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            Konsentrasi? konsentrasi = await _unitOfWork.Konsentrasi.FindAsync(d => d.Id == id);

            if(konsentrasi == null)
            {
                return NotFound();
            }
            await _unitOfWork.Konsentrasi.DeleteAsync(konsentrasi);
            await _unitOfWork.SaveAsync();
            TempData["Success"] = "Konsentrasi deleted successfully";
            return RedirectToAction(nameof(Index));
        }
    }
}