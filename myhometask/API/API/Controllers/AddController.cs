using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class AddController : ApiController
    {

        public AddController() {
        
        
        }
        [HttpGet]
        [Route("api/products/all")]
        public string About()
        {
            Product[] products = new Product[10];
            for (int i = 0; i < 10; i++)
            {
             
                products[i] = new Product()
                {
                    Id = i + 1,
                    Name = "P-" + (i + 1),
                    Price = 45
                };
            }


            return ("no issue s");
        }
    }
}
