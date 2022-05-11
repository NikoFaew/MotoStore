using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MotoStore.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
     
        public string Person { get; set; }
       
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public int MotoId { get; set; }
       
        public DateTime Date { get; set; }
    }
}