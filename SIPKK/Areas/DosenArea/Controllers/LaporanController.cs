using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
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

namespace SIPKK.Areas.DosenArea.Controllers
{
    [Area(nameof(DosenArea))]
    [Authorize(Roles = "Dosen")]

    public class LaporanController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public LaporanController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Laporan
        public async Task<IActionResult> Index()
        {
            List<Laporan> laporanList = (await _unitOfWork.Laporan.GetAllAsync()).ToList();
            return View(laporanList);
        }

        // GET: Laporan/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || id == string.Empty)
            {
                return NotFound();
            }

            Laporan laporan = await _unitOfWork.Laporan.GetAsync(d => d.Id == id);

            if (laporan == null)
            {
                return NotFound();
            }

            return View(laporan);
        }

    }
}