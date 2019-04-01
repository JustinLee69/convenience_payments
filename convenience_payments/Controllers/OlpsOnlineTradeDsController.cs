using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using convenience_payments.Models;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Http;

namespace convenience_payments.Controllers
{
    public class OlpsOnlineTradeDsController : Controller
    {
        private readonly ConvPaymentContext _context;
        
        public OlpsOnlineTradeDsController(ConvPaymentContext context)
        {
            _context = context;
        }

        // GET: OlpsOnlineTradeDs
        public async Task<IActionResult> Index()
        {
            return View(await _context.OlpsOnlineTradeD.ToListAsync());
        }

        //// GET: OlpsOnlineTradeDs/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var olpsOnlineTradeD = await _context.OlpsOnlineTradeD
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (olpsOnlineTradeD == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(olpsOnlineTradeD);
        //}

        // 查詢結果
        public async Task<IActionResult> Details()
        {
            string TestRcv;
            var t = TempData["SearchKey"];

            if (t != null) //tempdata 為空就跳回查詢頁面
            {
                TestRcv = t.ToString();

                var olpsOnlineTradeD = await _context.OlpsOnlineTradeD
                    .FirstOrDefaultAsync(m => m.Termino.Contains(TestRcv)); //.FirstOrDefaultAsync(m => m.Termino.Contains("2019030518810801000002")); 
                if (olpsOnlineTradeD == null)
                {
                    //return NotFound();

                    //TempData["SearchKey"] = TestRcv; //為了解決 refresh 頁面失效的問題, 再把值塞回去, 有點蠢.

                    return View("Error", new ErrorViewModel { RequestId = TestRcv });
                }
                return View(olpsOnlineTradeD);
            }

            return RedirectToAction("Index", "Home");
        }

        // GET: OlpsOnlineTradeDs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OlpsOnlineTradeDs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Termino,OiNo,OlCode1,OlCode2,OlCode3,OlAmount,Systemdate,Systemtime,OlCode4,OlCode5,OlPaytype,Store,Id")] OlpsOnlineTradeD olpsOnlineTradeD)
        {
            if (ModelState.IsValid)
            {
                _context.Add(olpsOnlineTradeD);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(olpsOnlineTradeD);
        }

        // GET: OlpsOnlineTradeDs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var olpsOnlineTradeD = await _context.OlpsOnlineTradeD.FindAsync(id);
            if (olpsOnlineTradeD == null)
            {
                return NotFound();
            }
            return View(olpsOnlineTradeD);
        }

        // POST: OlpsOnlineTradeDs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Termino,OiNo,OlCode1,OlCode2,OlCode3,OlAmount,Systemdate,Systemtime,OlCode4,OlCode5,OlPaytype,Store,Id")] OlpsOnlineTradeD olpsOnlineTradeD)
        {
            if (id != olpsOnlineTradeD.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(olpsOnlineTradeD);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OlpsOnlineTradeDExists(olpsOnlineTradeD.Id))
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
            return View(olpsOnlineTradeD);
        }

        // GET: OlpsOnlineTradeDs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var olpsOnlineTradeD = await _context.OlpsOnlineTradeD
                .FirstOrDefaultAsync(m => m.Id == id);
            if (olpsOnlineTradeD == null)
            {
                return NotFound();
            }

            return View(olpsOnlineTradeD);
        }

        // POST: OlpsOnlineTradeDs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var olpsOnlineTradeD = await _context.OlpsOnlineTradeD.FindAsync(id);
            _context.OlpsOnlineTradeD.Remove(olpsOnlineTradeD);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OlpsOnlineTradeDExists(int id)
        {
            return _context.OlpsOnlineTradeD.Any(e => e.Id == id);
        }
    }
}
