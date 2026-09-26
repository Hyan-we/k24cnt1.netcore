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
                Name = "Nguyen Huy Anh",
                Email = "huyanh@gmail.com",
                Phone = "0987654321",
                Avatar = "/images/1.png",
                Address = "Ha Noi",
                Bio = "Sinh vien Cong nghe Thong tin",
                Gender = 1,
                Birthday = new DateTime(2005, 5, 10)
            },

            new NhaAccount
            {
                Id = 2,
                Name = "Nguyen Tung Duong",
                Email = "tungduong@gmail.com",
                Phone = "0987654322",
                Avatar = "/images/2.png",
                Address = "Ha Noi",
                Bio = "Yeu thich lap trinh",
                Gender = 1,
                Birthday = new DateTime(2004, 8, 15)
            },

            new NhaAccount
            {
                Id = 3,
                Name = "Trinh Hoang Bach",
                Email = "hoangbach@gmail.com",
                Phone = "0987654323",
                Avatar = "/images/3.png",
                Address = "Ha Noi",
                Bio = "Sinh vien nganh CNTT",
                Gender = 1,
                Birthday = new DateTime(2005, 1, 20)
            },

            new NhaAccount
            {
                Id = 4,
                Name = "Nguyen Minh Anh",
                Email = "minhanh@gmail.com",
                Phone = "0987654324",
                Avatar = "/images/4.png",
                Address = "Ha Noi",
                Bio = "Thich thiet ke website",
                Gender = 0,
                Birthday = new DateTime(2005, 3, 12)
            },

            new NhaAccount
            {
                Id = 5,
                Name = "Tran Thu Ha",
                Email = "thuha@gmail.com",
                Phone = "0987654325",
                Avatar = "/images/5.png",
                Address = "Ha Noi",
                Bio = "Yeu thich cong nghe",
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
