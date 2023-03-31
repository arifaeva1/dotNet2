using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Product
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public int Price { get; internal set; }
    }
}