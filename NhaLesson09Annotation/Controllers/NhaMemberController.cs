using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NhaLesson09Annotation.Models.DataModels;
using NhaLesson09Annotation.Models.DataViewModels;

namespace NhaLesson09Annotation.Controllers
{
    public class NhaMemberController : Controller
    {
        private static List<NhaMember> _nhaMembers = new List<NhaMember>
        {
            new NhaMember
            {
                NhaMemberId = "2410900003",
                NhaUserName = "nguyenhuyanh",
                NhaPassword = "Password123",
                NhaEmail = "hyanh173@gmail.com",
                NhaPhoneNumber = "0987654321",
                NhaFullName = "Nguyen Huy Anh",
                NhaBirthday = new DateTime(2006, 3, 17)
            }
        };

        // GET: NhaMemberController
        public ActionResult Index()
        {
            return View(_nhaMembers);
        }

        // GET: NhaMemberController/Details/5
        public ActionResult Details(string id)
        {
            var member = _nhaMembers.FirstOrDefault(m => m.NhaMemberId == id);
            if (member == null)
            {
                return NotFound();
            }
            return View(member);
        }

        // GET: NhaMemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhaMemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NhaMemberRegister nhaMember)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(nhaMember);
                }

                NhaMember member = new NhaMember
                {
                    NhaMemberId = (nhaMember.NhaMemberId.HasValue && nhaMember.NhaMemberId > 0)
                        ? nhaMember.NhaMemberId.Value.ToString()
                        : Guid.NewGuid().ToString(),
                    NhaUserName = nhaMember.NhaUserName,
                    NhaPassword = nhaMember.NhaPassword,
                    NhaEmail = nhaMember.NhaEmail,
                    NhaPhoneNumber = nhaMember.NhaPhoneNumber,
                    NhaFullName = nhaMember.NhaFullName,
                    NhaBirthday = nhaMember.NhaBirthday
                };

                _nhaMembers.Add(member);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NhaMemberController/Edit/5
        public ActionResult Edit(string id)
        {
            var member = _nhaMembers.FirstOrDefault(m => m.NhaMemberId == id);
            if (member == null)
            {
                return NotFound();
            }
            return View(member);
        }

        // POST: NhaMemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, NhaMember member)
        {
            try
            {
                var existingMember = _nhaMembers.FirstOrDefault(m => m.NhaMemberId == id);
                if (existingMember != null)
                {
                    existingMember.NhaUserName = member.NhaUserName;
                    existingMember.NhaPassword = member.NhaPassword;
                    existingMember.NhaEmail = member.NhaEmail;
                    existingMember.NhaPhoneNumber = member.NhaPhoneNumber;
                    existingMember.NhaFullName = member.NhaFullName;
                    existingMember.NhaBirthday = member.NhaBirthday;
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NhaMemberController/Delete/5
        public ActionResult Delete(string id)
        {
            var member = _nhaMembers.FirstOrDefault(m => m.NhaMemberId == id);
            if (member == null)
            {
                return NotFound();
            }
            return View(member);
        }

        // POST: NhaMemberController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, IFormCollection collection)
        {
            try
            {
                var member = _nhaMembers.FirstOrDefault(m => m.NhaMemberId == id);
                if (member != null)
                {
                    _nhaMembers.Remove(member);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
