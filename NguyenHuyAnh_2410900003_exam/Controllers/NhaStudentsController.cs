using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NguyenHuyAnh_2410900003_exam.Models;

namespace NguyenHuyAnh_2410900003_exam.Controllers
{
    public class NhaStudentsController : Controller
    {
        private readonly NhaDbContext _context;

        public NhaStudentsController(NhaDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string? searchString, string? statusFilter)
        {
            var query = _context.NhaStudents.AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchString))
            {
                searchString = searchString.Trim();
                query = query.Where(s => s.NhaName.Contains(searchString)
                                      || s.NhaEmail.Contains(searchString)
                                      || s.NhaPhone.Contains(searchString)
                                      || s.Id.ToString() == searchString);
            }

            if (!string.IsNullOrWhiteSpace(statusFilter))
            {
                if (statusFilter == "active")
                {
                    query = query.Where(s => s.NhaActive == true);
                }
                else if (statusFilter == "inactive")
                {
                    query = query.Where(s => s.NhaActive == false);
                }
            }

            ViewBag.TotalStudents = await _context.NhaStudents.CountAsync();
            ViewBag.ActiveStudents = await _context.NhaStudents.CountAsync(s => s.NhaActive);
            ViewBag.InactiveStudents = await _context.NhaStudents.CountAsync(s => !s.NhaActive);

            ViewBag.CurrentSearch = searchString;
            ViewBag.CurrentStatus = statusFilter;

            var students = await query.OrderByDescending(s => s.Id).ToListAsync();
            return View(students);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.NhaStudents
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        public IActionResult Create()
        {
            var newStudent = new NhaStudent
            {
                NhaBirthDay = new DateTime(2004, 1, 1),
                NhaGender = true,
                NhaActive = true
            };
            return View(newStudent);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NhaName,NhaGender,NhaBirthDay,NhaEmail,NhaPhone,NhaActive")] NhaStudent nhaStudent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nhaStudent);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = $"Them sinh vien '{nhaStudent.NhaName}' thanh cong!";
                return RedirectToAction(nameof(Index));
            }
            return View(nhaStudent);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.NhaStudents.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NhaName,NhaGender,NhaBirthDay,NhaEmail,NhaPhone,NhaActive")] NhaStudent nhaStudent)
        {
            if (id != nhaStudent.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nhaStudent);
                    await _context.SaveChangesAsync();
                    TempData["SuccessMessage"] = $"Cap nhat sinh vien '{nhaStudent.NhaName}' thanh cong!";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NhaStudentExists(nhaStudent.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(nhaStudent);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.NhaStudents
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student = await _context.NhaStudents.FindAsync(id);
            if (student != null)
            {
                _context.NhaStudents.Remove(student);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = $"Da xoa sinh vien '{student.NhaName}' (ID: {student.Id}) thanh cong!";
            }

            return RedirectToAction(nameof(Index));
        }

        private bool NhaStudentExists(int id)
        {
            return _context.NhaStudents.Any(e => e.Id == id);
        }
    }
}
