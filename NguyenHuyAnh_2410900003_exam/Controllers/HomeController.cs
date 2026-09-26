using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NguyenHuyAnh_2410900003_exam.Models;

namespace NguyenHuyAnh_2410900003_exam.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult NhaAbout()
    {
        ViewBag.FullName = "Nguyen Huy Anh";
        ViewBag.StudentId = "2410900003";
        ViewBag.Gender = "Nam";
        ViewBag.BirthDay = new DateTime(2004, 5, 15);
        ViewBag.Email = "huyanh.nguyen@student.edu.vn";
        ViewBag.Phone = "0912345678";
        ViewBag.Class = "K24 - CNTT (Cong nghe Thong tin)";
        ViewBag.Subject = "Phat trien ung dung Web voi ASP.NET Core MVC";
        ViewBag.ExamName = "NguyenHuyAnh_2410900003_exam";
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
