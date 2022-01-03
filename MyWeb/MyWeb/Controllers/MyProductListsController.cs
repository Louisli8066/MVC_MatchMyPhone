using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWeb.Data;
using MyWeb.Models;

namespace MyWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyProductListsController : ControllerBase
    {
        private readonly PhonecompareContext _context;

        public MyProductListsController(PhonecompareContext context)
        {
            _context = context;
        }

        // GET: api/MyProductLists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MyProductList>>> GetMyProductLists()
        {
            return await _context.MyProductLists.ToListAsync();
        }

        // GET: api/MyProductLists/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<MyProductList>> GetMyProductList(int id)
        //{
        //    var myProductList = await _context.MyProductLists.FindAsync(id);

        //    if (myProductList == null)
        //    {
        //        return NotFound();
        //    }

        //    return myProductList;
        //}

        // PUT: api/MyProductLists/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMyProductList(int id, MyProductList myProductList)
        {
            if (id != myProductList.Id)
            {
                return BadRequest();
            }

            _context.Entry(myProductList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MyProductListExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/MyProductLists
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MyProductList>> PostMyProductList(MyProductList myProductList, string mail, int pid)
        {
            mail = HttpContext.Session.GetString("LoginEmail");
            Member m = await _context.Members.SingleOrDefaultAsync(m => m.Email == mail);

            myProductList = new MyProductList() { MemberId = m.Id, pid = pid };
            _context.MyProductLists.Add(myProductList);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMyProductList", new { id = myProductList.Id }, myProductList);
        }

        // DELETE: api/MyProductLists/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteMyProductList(int id)
        //{
        //    var myProductList = await _context.MyProductLists.FindAsync(id);
        //    if (myProductList == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.MyProductLists.Remove(myProductList);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        private bool MyProductListExists(int id)
        {
            return _context.MyProductLists.Any(e => e.Id == id);
        }



        [HttpGet("{pid}")]
        public async Task<ActionResult<List<string>>> AddMyProductList(int pid)
        {
            string mail = HttpContext.Session.GetString("LoginEmail");
            Member m = await _context.Members.SingleOrDefaultAsync(m => m.Email == mail);
            var myProductList = await _context.MyProductLists.SingleOrDefaultAsync(s=>s.MemberId==m.Id&&s.pid==pid);
            List<string> temp = new List<string>();
            if (myProductList != null)
            {
                temp.Add("已在清單中");
                return temp;
            }
            

            myProductList = new MyProductList() { MemberId = m.Id, pid = pid };
            if(_context.MyProductLists.Where(s=>s.MemberId==m.Id).ToList().Count < 3)
            {
                _context.MyProductLists.Add(myProductList);
                await _context.SaveChangesAsync();
                temp.Add("加入成功");
                return temp;
            }
            else
            {
                temp.Add("比較清單最多只能有三筆喔");
                return temp;
            }
            
        }

        [HttpGet("delete/{pid}")]
        public async Task<ActionResult<string>> DeleteMyProductList(int pid)
        {
            string mail = HttpContext.Session.GetString("LoginEmail");
            Member m = await _context.Members.SingleOrDefaultAsync(m => m.Email == mail);
            var myProductList = await _context.MyProductLists.SingleOrDefaultAsync(s => s.MemberId == m.Id && s.pid == pid);
            if (myProductList == null)
            {
                return NotFound();
            }

            _context.MyProductLists.Remove(myProductList);
            await _context.SaveChangesAsync();

            return "OK";
            //return RedirectToAction("Index", "PhoneMasters");
        }

        //[HttpGet("delete/{pid}")]
        //public ActionResult DeleteMyProductList(int pid)
        //{
        //    string mail = HttpContext.Session.GetString("LoginEmail");
        //    Member m =  _context.Members.SingleOrDefault(m => m.Email == mail);
        //    var myProductList =  _context.MyProductLists.SingleOrDefault(s => s.MemberId == m.Id && s.pid == pid);
        //    if (myProductList == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.MyProductLists.Remove(myProductList);
        //    _context.SaveChanges();

        //    return RedirectToAction("Index", "PhoneMasters");
        //}

    }

   

}
