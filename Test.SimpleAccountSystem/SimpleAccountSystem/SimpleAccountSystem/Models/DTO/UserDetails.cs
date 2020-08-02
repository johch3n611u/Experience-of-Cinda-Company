using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SimpleAccountSystem.Models.DTO
{
    public class UserDetails
    {
        [DisplayName("帳號")]
        public string cAccount { get; set; }
        [DisplayName("姓名")]
        public string cName { get; set; }
        [DisplayName("郵箱")]
        public string cEmail { get; set; }
        [DisplayName("啟用狀態")]
        public int? cStatus { get; set; }
        [DisplayName("權限")]
        public string cGroupNames { get; set; }

    }
}