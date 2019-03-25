using System;
using System.Collections.Generic;

namespace convenience_payments.Helpers
{
    public interface ISearchDateTimeRange
    {
        List<string> GetYearList();
        List<string> GetMonthList();
        List<string> GetDayList();

        string FullDateTimeString();
    }
}
