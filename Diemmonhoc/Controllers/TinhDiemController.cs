using Microsoft.AspNetCore.Mvc;
using TinhDiemMonHoc.Models;

namespace TinhDiemMonHoc.Controllers
{
    public class TinhDiemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TinhToan(DiemMonHoc model)
        {
            model.TinhDiemTongKet();
            return View("KetQua", model);
        }
    }
}