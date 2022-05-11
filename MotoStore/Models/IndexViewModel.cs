using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MotoStore.Models;
using System.Data.Entity;

namespace MotoStore.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Motobike> Motobikes { get; set; }// Get Set модификаторы доступа к полю
        public PageInfo PageInfo { get; set; }
    }
}