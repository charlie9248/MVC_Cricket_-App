using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Mvc_Cricket.Models
{
    public class Cricketer
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public int ODI { get; set; }
        public int Test { get; set; }
    }



    public class CricketerDBContext1 :DbContext
    {
        public DbSet<Cricketer> Cricketers { get; set; }
    }
}