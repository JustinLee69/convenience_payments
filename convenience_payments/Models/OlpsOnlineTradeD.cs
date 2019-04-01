using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace convenience_payments.Models
{
    public partial class OlpsOnlineTradeD
    {
        [BindRequired]
        public string Termino { get; set; }
        [Required]
        public string OiNo { get; set; }
        public string OlCode1 { get; set; }
        public string OlCode2 { get; set; }
        public string OlCode3 { get; set; }
        public string OlAmount { get; set; }
        //[RegularExpression(@"([12]\d{3}(0[1-9]|1[0-2])(0[1-9]|[12]\d|3[01]))",
        //    ErrorMessage = "輸入格式錯誤",
        //    ErrorMessageResourceName = "Systemdate",
        //    ErrorMessageResourceType = typeof(string),
        //    MatchTimeoutInMilliseconds = 3)]
        public string Systemdate { get; set; }
        public string Systemtime { get; set; }
        public string OlCode4 { get; set; }
        public string OlCode5 { get; set; }
        public string OlPaytype { get; set; }
        [StringLengthAttribute(6, ErrorMessage ="長度錯誤", ErrorMessageResourceName = "Store", ErrorMessageResourceType = typeof(string), MinimumLength = 6)]
        public string Store { get; set; }
        public int Id { get; set; }
    }
}
