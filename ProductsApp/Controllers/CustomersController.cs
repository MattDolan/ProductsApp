using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using ProductsApp.Models;

namespace ProductsApp.Controllers
{
    public class CustomersController : ApiController
    {
        Customers[] customers = new Customers[] 
        { 
            new Customers { Id = 1, Company = "Home Depot" }, 
            new Customers { Id = 2, Company = "Lowes" }, 
            new Customers { Id = 3, Company = "Schlotzkys" } 
        };

        public IEnumerable<Customers> GetAllProducts()
        {
            return customers;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var customer = customers.FirstOrDefault((p) => p.Id == id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }
    }
}
