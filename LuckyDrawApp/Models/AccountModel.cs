using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Security.Principal;
using System.ComponentModel.DataAnnotations;

namespace LuckyDrawApp.Models
{
    public class AccountModel
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Code { get; set; }
        public string Password { get; set; }
       
    }
}