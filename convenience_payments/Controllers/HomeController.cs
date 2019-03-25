using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using convenience_payments.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using convenience_payments.Helpers;
using Microsoft.AspNetCore.Http;

namespace convenience_payments.Controllers
{
    public class HomeController : Controller
    {
        private ISearchDateTimeRange TimeRangeService { get; set; }
        //public HomeController()
        //{
        //    int g = 9; //測試程式啟動時是不是會 call 近來?
        //    g++;
        //}

        public HomeController(ISearchDateTimeRange s)
        {
            this.TimeRangeService = s;
        }

        public IActionResult Index()
        {
            //年
            List<SelectListItem> YearList = new List<SelectListItem>();
            foreach (string y in this.TimeRangeService.GetYearList())
            {
                YearList.Add(new SelectListItem(y, y));
            }
            ViewBag.Year = YearList;

            //月
            List<SelectListItem> MonthList = new List<SelectListItem>();
            foreach (string m in this.TimeRangeService.GetMonthList())
            {
                MonthList.Add(new SelectListItem(m, m));
            }
            ViewBag.Month = MonthList;

            //日
            List<SelectListItem> DayList = new List<SelectListItem>();
            foreach (string d in this.TimeRangeService.GetDayList())
            {
                DayList.Add(new SelectListItem(d, d));
            }
            ViewBag.Day = DayList;


            ViewBag.FullDateTimeString = this.TimeRangeService.FullDateTimeString();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(IFormCollection form)
        {

            string Y = form["SelectList_Y"]
            + form["SelectList_M"]
             + form["SelectList_D"]
             + form["StoreNum"]
             + form["MachineNum"]
             + form["SerialNum"];

            TempData["SearchKey"] = Y;

            return RedirectToAction("Details", "OlpsOnlineTradeDs");
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


    public class ViewSearchDateTiem
    {
        [Display(Name = "SearchDateTime")]
        public string YearString { get; set; }
    }
}
