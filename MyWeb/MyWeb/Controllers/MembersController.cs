using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyWeb.Data;
using MyWeb.Models;

namespace MyWeb.Controllers
{
    public class MembersController : Controller
    {
        private readonly PhonecompareContext _context;

        public MembersController(PhonecompareContext context)
        {
            _context = context;
        }

        // GET: Members
        public async Task<IActionResult> Index()
        {
            string mail = HttpContext.Session.GetString("LoginEmail");
            Member m = await _context.Members.SingleOrDefaultAsync(m => m.Email == mail);
            if (m.Id != 1 || m==null)
            {
                return RedirectToAction(nameof(Login));
            }
            ViewBag.id = m.Id;
            ViewBag.email = m.Email;
            ViewBag.password = m.Password;
            ViewBag.name = m.UserName;
            return View(await _context.Members.ToListAsync());
        }

        // GET: Members/Details/5
        public async Task<IActionResult> Details(string mail)
        {
            mail = HttpContext.Session.GetString("LoginEmail");
            Member m = await _context.Members.SingleOrDefaultAsync(m => m.Email == mail);
            if (m == null)
            {
                return RedirectToAction(nameof(Login));
            }
            ViewBag.id = m.Id;
            ViewBag.email = m.Email;
            ViewBag.password = m.Password;
            ViewBag.name = m.UserName;
            return View(m);

        }

        public async Task<IActionResult> BackDetails(int? id)
        {
            string mail = HttpContext.Session.GetString("LoginEmail");
            Member m = await _context.Members.SingleOrDefaultAsync(mm => mm.Email == mail);
            if (m.Id != 1)
            {
                return RedirectToAction(nameof(Login));
            }
            Member s = await _context.Members.SingleOrDefaultAsync(ss => ss.Id == id);
            ViewBag.id = s.Id;
            ViewBag.email = s.Email;
            ViewBag.password = s.Password;
            ViewBag.UserName = s.UserName;
            ViewBag.name = m.UserName;
            return View();

        }


        // GET: Members/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Members/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Member member)
        {
            if (ModelState.IsValid)
            {
                Member repeat = await _context.Members.SingleOrDefaultAsync(s => s.Email == member.Email);
                if (repeat == null)
                {
                    _context.Add(member);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Login));
                }
                ModelState.AddModelError("error", "此Email已重覆註冊過");
                return View(member);

            }
            return View(member);
        }

        // GET: Members/Edit/5
        public async Task<IActionResult> BackEdit(int? id)
        {
            string mail = HttpContext.Session.GetString("LoginEmail");
            Member m = await _context.Members.SingleOrDefaultAsync(mm => mm.Email == mail);
            if (id == null)
            {
                return RedirectToAction(nameof(Login));
            }

            var member = await _context.Members.FindAsync(id);
            if (member == null)
            {
                return RedirectToAction(nameof(Login));
            }
            if (m == null || m.Id != 1)
            {
                return RedirectToAction(nameof(Login));
            }
            Member s = await _context.Members.SingleOrDefaultAsync(ss => ss.Id==id);
            ViewBag.id = s.Id;
            ViewBag.email = s.Email;
            ViewBag.password = s.Password;
            ViewBag.UserName = s.UserName;
            ViewBag.name = m.UserName;
            return View();
        }

        // POST: Members/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BackEdit(int id, Member member)
        {
            string mail = HttpContext.Session.GetString("LoginEmail");
            Member m = await _context.Members.SingleOrDefaultAsync(mm => mm.Email == mail);
            ViewBag.name = m.UserName;
            if (id != member.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    m.Email = member.Email;
                    m.UserName = member.UserName;
                    m.Password = member.Password;
                    _context.Update(m);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MemberExists(member.Id))
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
            return View(member);
        }

        // GET: Members/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            string mail = HttpContext.Session.GetString("LoginEmail");
            Member m = await _context.Members.SingleOrDefaultAsync(mm => mm.Email == mail);
            ViewBag.name = m.UserName;
            if (m == null || m.Id != 1)
            {
                return RedirectToAction(nameof(Login));
            }
            if (id == null)
            {
                return NotFound();
            }

            var member = await _context.Members
                .FirstOrDefaultAsync(m => m.Id == id);
            if (member == null)
            {
                return NotFound();
            }

            return View(member);
        }

        // POST: Members/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var member = await _context.Members.FindAsync(id);
            _context.Members.Remove(member);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MemberExists(int id)
        {
            return _context.Members.Any(e => e.Id == id);
        }

        //登入~~~~~~~~~~~~~~~~~~~~~~
        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string Email, string Password)
        {
            var member = await _context.Members.SingleOrDefaultAsync(m => m.Email == Email && m.Password == Password);
            if (member != null)
            {
                //using Microsoft.AspNetCore.Http;
                HttpContext.Session.SetString("LoginEmail", member.Email);

                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("error", "帳號或密碼不正確");
            return View(member);
        }

        //登出~~~~~~~~~~~~~~~~~~~~~~
        public async Task<IActionResult> Logout()
        {
            HttpContext.Session.Clear();

            //return RedirectToAction("Index","Home");
            return Json(await _context.Members.FindAsync(0));

        }

        // GET: Members/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            string mail = HttpContext.Session.GetString("LoginEmail");
            Member m = await _context.Members.SingleOrDefaultAsync(m => m.Email == mail);
            if (id == null)
            {
                return RedirectToAction(nameof(Login));
            }

            var member = await _context.Members.FindAsync(id);
            if (member == null)
            {
                return RedirectToAction(nameof(Login));
            }
            if (m == null || m.Id != 1)
            {
                return RedirectToAction(nameof(Login));
            }
            ViewBag.id = m.Id;
            ViewBag.email = m.Email;
            ViewBag.password = m.Password;
            ViewBag.name = m.UserName;
            return View();
        }

        // POST: Members/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Member member)
        {
            string mail = HttpContext.Session.GetString("LoginEmail");
            Member m = await _context.Members.SingleOrDefaultAsync(m => m.Email == mail);

            if (id != member.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    m.Email = member.Email;
                    m.Password = member.Password;
                    m.UserName = member.UserName;
                     _context.Update(m);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MemberExists(member.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Details));
            }
            return RedirectToAction(nameof(Details));
        }
    }
}
