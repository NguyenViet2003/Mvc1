using Microsoft.AspNetCore.Mvc;
using DEMOMVC.Models;

namespace DEMOMVC.Controllers
{
    public class BMIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(float weight, float height)
        {
            if (height <= 0 || weight <= 0)
            {
                ViewBag.Message = "Vui lòng nhập cân nặng và chiều cao hợp lệ.";
                return View();
            }

            // Sửa lỗi ở đây: chiều cao cần được đổi về mét nếu người dùng nhập cm
            if (height > 3) { // Giả sử không ai cao quá 3 mét
                height /= 100; // Chuyển cm sang mét
            }


            BMIModel model = new BMIModel
            {
                Weight = weight,
                Height = height,
                BMI = weight / (height * height)
            };

            ViewBag.BMI = model.BMI;
            ViewBag.Category = model.GetBMICategory();
            return View(model); // Truyền model sang view để dùng model binding
        }
    }
}