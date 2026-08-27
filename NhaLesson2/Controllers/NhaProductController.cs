using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using NhaLesson2.Models;

namespace NhaLesson2.Controllers
{
    public class NhaProductController : Controller
    {
        public IActionResult Index()
        {
            //dua du lieu ra view

            ViewBag.name = "huy anh";
            ViewData["address"] = "fit NTU";
            TempData["UNI"] = "Truong Dai Hoc Nguyen Trai";
            return View();
        }

        //chi tiet san pham
        public IActionResult GetProduct()
        {
            //Mock Data
            NhaProduct nhaProduct = new NhaProduct()
            {
                ProductId = "P001",
                ProductName = "Iphone 14 Pro Max",
                YearRelease = 2022,
                Price = 11000000,
            };
            ViewData["productVD"] = nhaProduct;
            ViewBag.productVB = nhaProduct;
            return View(nhaProduct);
        }
    }
}
