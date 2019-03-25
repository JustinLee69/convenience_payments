using System;
using System.Collections.Generic;

namespace convenience_payments.Helpers
{
    public class SearchDateTimeRange : ISearchDateTimeRange
    {
        private readonly DateTime dt = DateTime.Now;
        private DateTime sTime;
        private DateTime eTime;

        public SearchDateTimeRange()
        {
            eTime = dt.AddDays(-2);
            sTime = eTime.AddMonths(-1);
        }

        /// <summary>
        /// 取得搜尋的時間起迄
        /// 搜尋時間的起始為系統日期的前兩日的前一個月
        /// </summary>
        DateTime Get_Start()
        {
            DateTime rtnDate = Get_End().AddMonths(-1);
            return rtnDate;
        }

        /// <summary>
        /// 取得搜尋的時間起迄
        /// 搜尋時間的結束為系統日期的前兩日
        /// </summary>
        DateTime Get_End()
        { return dt.AddDays(-2); }

        public List<string> GetYearList()
        {
            List<string> rtn = new List<string>();
            rtn.Add(eTime.Year.ToString());
            if (eTime.Year != sTime.Year)
                rtn.Add(sTime.Year.ToString());

            return rtn;
        }
        public List<string> GetMonthList()
        {
            List<string> rtn = new List<string>();
            rtn.Add(eTime.Month.ToString("00"));
            rtn.Add(sTime.Month.ToString("00"));
            
            return rtn;
        }

        public List<string> GetDayList()
        {
            List<string> rtn = new List<string>();
            for(int i = 1; i<= 31; i++)
            {
                rtn.Add(i.ToString("00"));
            }

            return rtn;
        }

        public string FullDateTimeString()
        {
            return "自 " + sTime.ToString("yyyy年MM月dd日") + " 到 " + eTime.ToString("yyyy年MM月dd日");
        }
    }
}
