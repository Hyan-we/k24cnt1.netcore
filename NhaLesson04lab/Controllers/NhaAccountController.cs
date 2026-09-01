using Microsoft.AspNetCore.Mvc;
using NhaLesson04lab.Models;

namespace NhaLesson04lab.Controllers
{
    public class NhaAccountController : Controller
    {
        private readonly List<NhaAccount> NhaAccounts = new()
        {
            new NhaAccount
            {
                Id = 1,
                Name = "Nguyễn Huy Anh",
                Email = "huyanh@gmail.com",
                Phone = "0987654321",
                Avatar = "/images/1.png",
                Address = "Hà Nội",
                Bio = "Sinh viên Công nghệ Thông tin",
                Gender = 1,
                Birthday = new DateTime(2005, 5, 10)
            },

            new NhaAccount
            {
                Id = 2,
                Name = "Nguyễn Tùng Dương",
                Email = "tungduong@gmail.com",
                Phone = "0987654322",
                Avatar = "/images/2.png",
                Address = "Hà Nội",
                Bio = "Yêu thích lập trình",
                Gender = 1,
                Birthday = new DateTime(2004, 8, 15)
            },

            new NhaAccount
            {
                Id = 3,
                Name = "Trịnh Hoàng Bách",
                Email = "hoangbach@gmail.com",
                Phone = "0987654323",
                Avatar = "/images/3.png",
                Address = "Hà Nội",
                Bio = "Sinh viên ngành CNTT",
                Gender = 1,
                Birthday = new DateTime(2005, 1, 20)
            },

            new NhaAccount
            {
                Id = 4,
                Name = "Nguyễn Minh Anh",
                Email = "minhanh@gmail.com",
                Phone = "0987654324",
                Avatar = "/images/4.png",
                Address = "Hà Nội",
                Bio = "Thích thiết kế website",
                Gender = 0,
                Birthday = new DateTime(2005, 3, 12)
            },

            new NhaAccount
            {
                Id = 5,
                Name = "Trần Thu Hà",
                Email = "thuha@gmail.com",
                Phone = "0987654325",
                Avatar = "/images/5.png",
                Address = "Hà Nội",
                Bio = "Yêu thích công nghệ",
                Gender = 0,
                Birthday = new DateTime(2004, 11, 25)
            }
        };

        public IActionResult NhaIndex()
        {
            ViewBag.NhaAccounts = NhaAccounts;
            return View();
        }
    }
}