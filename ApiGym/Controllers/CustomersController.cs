﻿  using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dto;

namespace GymApi.Controllers
{
    public class CustomersController : ApiController
    {
        // GET: api/Customers
        public List<ClassCustomers> Get()
        {
            return Bl.ClassCustomers.GetAllCustomers();
        }

        //    // GET: api/Customers/5
        public string Get(int id)
        {
            return "value";
        }

        //    // POST: api/Customers
        public void PostCustomer([FromBody]string value)
        {
        }

        // PUT: api/Customers/5
           public void Put(int id, [FromBody]string value)
            {
            }

    // DELETE: api/Customers/5
    public void Delete(int id)
    {
    }
}
}
