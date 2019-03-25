using System;
using System.Collections.Generic;

namespace convenience_payments.Models
{
    public partial class OlpsOnlineTradeD
    {
        public string Termino { get; set; }
        public string OiNo { get; set; }
        public string OlCode1 { get; set; }
        public string OlCode2 { get; set; }
        public string OlCode3 { get; set; }
        public string OlAmount { get; set; }
        public string Systemdate { get; set; }
        public string Systemtime { get; set; }
        public string OlCode4 { get; set; }
        public string OlCode5 { get; set; }
        public string OlPaytype { get; set; }
        public string Store { get; set; }
        public int Id { get; set; }
    }
}
