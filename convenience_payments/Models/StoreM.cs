using System;
using System.Collections.Generic;

namespace convenience_payments.Models
{
    public partial class StoreM
    {
        public string Store { get; set; }
        public string EffDateFrom { get; set; }
        public string EffDateTo { get; set; }
        public string StNameLong { get; set; }
        public string StNameShort { get; set; }
        public string OldStore { get; set; }
        public string OpenDate { get; set; }
        public string SalesDate { get; set; }
        public string CloseDate { get; set; }
        public string ZoCd { get; set; }
        public string DoCd { get; set; }
        public string FmCd { get; set; }
        public string County { get; set; }
        public string Zip { get; set; }
        public string Address { get; set; }
        public string TelArea { get; set; }
        public string TelNo { get; set; }
        public string FaxNo { get; set; }
        public string Area { get; set; }
        public string StoreType { get; set; }
        public string SpecialFlag { get; set; }
        public string InvoiceFlag { get; set; }
        public string OpTime { get; set; }
        public string OpType { get; set; }
        public decimal? Longitude { get; set; }
        public decimal? Latitude { get; set; }
        public string JournalFlag { get; set; }
        public string Reason { get; set; }
        public string UpdId { get; set; }
        public string UpdDate { get; set; }
        public string UpdTime { get; set; }
        public DateTime? SysDate { get; set; }
        public string TestStoreFlag { get; set; }
        public int Id { get; set; }
    }
}
