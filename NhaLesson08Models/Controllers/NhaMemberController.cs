using Microsoft.AspNetCore.Mvc;
using NhaLesson08Models.Models;

namespace NhaLesson08Models.Controllers
{
    public class NhaMemberController : Controller
    {
        // Mock data - NhaMember
        private static List<NhaMember> _members = new List<NhaMember>()
        {
            new NhaMember
            {
                NhaMemberId = Guid.NewGuid().ToString(),
                NhaUserName = "huyanh",
                NhaPassword = "Password123!",
                NhaFullName = "Nguyen Huy Anh",
                NhaEmail = "hyanh173@gmail.com"
            },
            new NhaMember
            {
                NhaMemberId = Guid.NewGuid().ToString(),
                NhaUserName = "tranthib",
                NhaPassword = "SecurePass456#",
                NhaFullName = "Trần Thị B",
                NhaEmail = "tranthib@outlook.com"
            },
            new NhaMember
            {
                NhaMemberId = Guid.NewGuid().ToString(),
                NhaUserName = "levanc",
                NhaPassword = "MyPassword789$",
                NhaFullName = "Lê Văn C",
                NhaEmail = "levanc@company.com"
            }
        };

        // GET: Danh sách thành viên
        public IActionResult Index()
        {
            return View(_members);
        }

        [HttpGet]
        public IActionResult NhaCreate()
        {
            var member = new NhaMember();
            return View(member);
        }
        [HttpPost]
        public IActionResult NhaCreate(NhaMember NhaMember)
        {
            NhaMember.NhaMemberId = Guid.NewGuid().ToString();
            _members.Add(NhaMember);

            return RedirectToAction("Index");
            //return View(NhaMember);
        }

        [HttpGet]
        public IActionResult NhaEdit(string id)
        {
            var member = _members.Where(x => x.NhaMemberId.Equals(id)).FirstOrDefault();
            return View(member);
        }

        [HttpPost]
        public IActionResult NhaEdit(string id, NhaMember NhaMember)
        {
            // var member = _members.Where(x => x.NhaMemberId.Equals(id)).FirstOrDefault();
            for (int i = 0; i < _members.Count; i++)
            {
                if (_members[i].NhaMemberId == id)
                {
                    _members[i].NhaUserName = NhaMember.NhaUserName;
                    _members[i].NhaPassword = NhaMember.NhaPassword;
                    _members[i].NhaFullName = NhaMember.NhaFullName;
                    _members[i].NhaEmail = NhaMember.NhaEmail;

                    return RedirectToAction("Index");
                }

            }
            return View();
        }

        [HttpGet]
        public IActionResult NhaDetails(string id)
        {
            var member = _members.Where(x => x.NhaMemberId.Equals(id)).FirstOrDefault();
            return View(member);
        }

        [HttpGet]
        public IActionResult NhaDelete(string id)
        {
            var member = _members.Where(x => x.NhaMemberId.Equals(id)).FirstOrDefault();
            return View(member);
        }

        [HttpPost]
        public IActionResult NhaDeleted(string id)
        {
            foreach (var item in _members)
            {
                if (item.NhaMemberId.Equals(id))
                {
                    _members.Remove(item);
                    return RedirectToAction("Index");
                }
            }
            return View("NhaDelete");
        }
    }
}
