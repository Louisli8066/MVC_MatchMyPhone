using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyWeb.Data;
using MyWeb.Models;

namespace MyWeb.Controllers
{
    public class PhoneMastersController : Controller
    {
        private readonly PhonecompareContext _context;
        IWebHostEnvironment _env;

        public PhoneMastersController(PhonecompareContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;

            
        }

        // GET: PhoneMasters
        public async Task<IActionResult> Index()
        {
            ViewBag.IsLogin = HttpContext.Session.GetString("LoginEmail") != null;
            string mail = HttpContext.Session.GetString("LoginEmail");
            Member m = await _context.Members.SingleOrDefaultAsync(m => m.Email == mail);
            
            if (m == null)
            {
                return RedirectToAction("Login","Members");
            }
            else
            {
                ViewBag.id = m.Id;
                ViewBag.email = m.Email;
                ViewBag.password = m.Password;
                ViewBag.name = m.UserName;
                int[] ids = new int[_context.MyProductLists.Where(s=>s.MemberId==m.Id).ToList().Count];
                for(int n = 0; n < _context.MyProductLists.Where(s => s.MemberId == m.Id).ToList().Count; n++)
                {
                    ids[n] = _context.MyProductLists.Where(s => s.MemberId == m.Id).ToList()[n].pid;
                }

                List<PhoneMaster> myPMs = new List<PhoneMaster>();
                foreach (int id in ids)
                {
                    PhoneMaster pm = await _context.PhoneMasters.FindAsync(id);
                    myPMs.Add(pm);
                }
                return View(myPMs);
            }
            
        }

        // GET: PhoneMasters/Details/5
        public async Task<IActionResult> Details(int? id, string mail)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phoneMaster = await _context.PhoneMasters
                .FirstOrDefaultAsync(m => m.Id == id);
            if (phoneMaster == null)
            {
                return NotFound();
            }
            ViewBag.IsLogin = HttpContext.Session.GetString("LoginEmail") != null;
            mail = HttpContext.Session.GetString("LoginEmail");
            Member m = await _context.Members.SingleOrDefaultAsync(m => m.Email == mail);
            if (m == null)
            {
                return View();
            }
            ViewBag.id = m.Id;
            ViewBag.email = m.Email;
            ViewBag.password = m.Password;
            ViewBag.name = m.UserName;
            return View(phoneMaster);
        }

        public async Task<IActionResult> BackendDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phoneMaster = await _context.PhoneMasters
                .FirstOrDefaultAsync(m => m.Id == id);
            if (phoneMaster == null)
            {
                return NotFound();
            }
            ViewBag.IsLogin = HttpContext.Session.GetString("LoginEmail") != null;
            string mail = HttpContext.Session.GetString("LoginEmail");
            Member m = await _context.Members.SingleOrDefaultAsync(m => m.Email == mail);
            if (m == null)
            {
                return View();
            }
            ViewBag.id = m.Id;
            ViewBag.email = m.Email;
            ViewBag.password = m.Password;
            ViewBag.name = m.UserName;
            return View(phoneMaster);
        }

        // GET: PhoneMasters/Create
        public async Task<IActionResult> CreateAsync(string mail)
        {
            ViewBag.IsLogin = HttpContext.Session.GetString("LoginEmail") != null;
            mail = HttpContext.Session.GetString("LoginEmail");
            Member m = await _context.Members.SingleOrDefaultAsync(m => m.Email == mail);
            if (m == null)
            {
                return View();
            }
            ViewBag.id = m.Id;
            ViewBag.email = m.Email;
            ViewBag.password = m.Password;
            ViewBag.name = m.UserName;
            return View();
        }

        // POST: PhoneMasters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PhoneMaster phoneMaster, IFormFile file)
        {
            ViewBag.IsLogin = HttpContext.Session.GetString("LoginEmail") != null;
            string mail = HttpContext.Session.GetString("LoginEmail");
            Member m = await _context.Members.SingleOrDefaultAsync(m => m.Email == mail);
            if (m == null)
            {
                return View();
            }
            if (ModelState.IsValid)
            {
                phoneMaster.Image = file.FileName;
                var filePath = $"{_env.ContentRootPath}\\wwwroot\\images\\{file.FileName}";

                using (var stream = System.IO.File.Create(filePath))
                {
                    file.CopyTo(stream);
                }
                _context.Add(phoneMaster);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(BackIndex));
            }
            return View(phoneMaster);
        }

        // GET: PhoneMasters/Edit/5
        public async Task<IActionResult> Edit(int? id, string mail)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phoneMaster = await _context.PhoneMasters.FindAsync(id);
            if (phoneMaster == null)
            {
                return NotFound();
            }
            ViewBag.IsLogin = HttpContext.Session.GetString("LoginEmail") != null;
            mail = HttpContext.Session.GetString("LoginEmail");
            Member m = await _context.Members.SingleOrDefaultAsync(m => m.Email == mail);
            if (m == null)
            {
                return View();
            }
            ViewBag.id = m.Id;
            ViewBag.email = m.Email;
            ViewBag.password = m.Password;
            ViewBag.name = m.UserName;
            return View(phoneMaster);
        }

        // POST: PhoneMasters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, PhoneMaster phoneMaster, IFormFile file)
        {
            if (id != phoneMaster.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    phoneMaster.Image = file.FileName;
                    var filePath = $"{_env.ContentRootPath}\\wwwroot\\images\\{file.FileName}";

                    using (var stream = System.IO.File.Create(filePath))
                    {
                        file.CopyTo(stream);
                    }
                    _context.Update(phoneMaster);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhoneMasterExists(phoneMaster.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(BackIndex));
            }
            return View(phoneMaster);
        }

        // GET: PhoneMasters/Delete/5
        public async Task<IActionResult> Delete(int? id, string mail)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phoneMaster = await _context.PhoneMasters
                .FirstOrDefaultAsync(m => m.Id == id);
            if (phoneMaster == null)
            {
                return NotFound();
            }
            ViewBag.IsLogin = HttpContext.Session.GetString("LoginEmail") != null;
            mail = HttpContext.Session.GetString("LoginEmail");
            Member m = await _context.Members.SingleOrDefaultAsync(m => m.Email == mail);
            if (m == null)
            {
                return View();
            }
            ViewBag.id = m.Id;
            ViewBag.email = m.Email;
            ViewBag.password = m.Password;
            ViewBag.name = m.UserName;
            return View(phoneMaster);
        }

        // POST: PhoneMasters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phoneMaster = await _context.PhoneMasters.FindAsync(id);
            _context.PhoneMasters.Remove(phoneMaster);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(BackIndex));
        }

        private bool PhoneMasterExists(int id)
        {
            return _context.PhoneMasters.Any(e => e.Id == id);
        }

        // GET: PhoneMastersCards
        public async Task<IActionResult> ListCards(string brand = "all")
        {
            ViewBag.IsLogin = HttpContext.Session.GetString("LoginEmail") != null;
            string mail = HttpContext.Session.GetString("LoginEmail");
            Member m = await _context.Members.SingleOrDefaultAsync(m => m.Email == mail);
            if (m == null)
            {
                return RedirectToAction("Login","Members",null);
            }
            ViewBag.id = m.Id;
            ViewBag.email = m.Email;
            ViewBag.password = m.Password;
            ViewBag.name = m.UserName;
            if(brand == "all")
            {
                return View(await _context.PhoneMasters.ToListAsync());
            }
            else
            {
                return View(await _context.PhoneMasters.Where(p => p.Brand == brand).ToListAsync());
            }
            
        }

        //[HttpPost]
        //public async Task<IActionResult> ListCards(string brand)
        //{
        //    ViewBag.IsLogin = HttpContext.Session.GetString("LoginEmail") != null;
        //    string mail = HttpContext.Session.GetString("LoginEmail");
        //    Member m = await _context.Members.SingleOrDefaultAsync(m => m.Email == mail);
        //    if (m == null)
        //    {
        //        return RedirectToAction("Login", "Members", null);
        //    }
        //    ViewBag.id = m.Id;
        //    ViewBag.email = m.Email;
        //    ViewBag.password = m.Password;
        //    ViewBag.name = m.UserName;
        //    return View(await _context.PhoneMasters.Where(p => p.Brand == brand).ToListAsync());
        //}


        // GET: PhoneMasters
        public async Task<IActionResult> BackIndex()
        {
            ViewBag.IsLogin = HttpContext.Session.GetString("LoginEmail") != null;
            string mail = HttpContext.Session.GetString("LoginEmail");
            Member m = await _context.Members.SingleOrDefaultAsync(m => m.Email == mail);
            int[] ids = new int[_context.MyProductLists.ToList().Count];
            if (m.Id != 1)
            {
                return RedirectToAction("Login", "Members");
            }
            else
            {
                ViewBag.id = m.Id;
                ViewBag.email = m.Email;
                ViewBag.password = m.Password;
                ViewBag.name = m.UserName;
                
                return View(await _context.PhoneMasters.ToListAsync());
            }

        }

    }
}
