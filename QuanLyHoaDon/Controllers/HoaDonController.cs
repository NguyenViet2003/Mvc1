using Microsoft.AspNetCore.Mvc;
using QuanLyHoaDon.Models;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyHoaDon.Controllers
{
    public class HoaDonController : Controller
    {
        private static List<MatHang> matHangs = new List<MatHang>();

        public IActionResult Index()
        {
            decimal tongTien = matHangs.Sum(item => item.SoLuong * item.DonGia);
            ViewBag.TongTien = tongTien;
            return View(matHangs);
        }

        [HttpPost]
        public IActionResult ThemMatHang(MatHang matHang)
        {
            if (ModelState.IsValid)
            {
                matHangs.Add(matHang);
                return RedirectToAction("Index");
            }
            return View(matHang);
        }
    }
}