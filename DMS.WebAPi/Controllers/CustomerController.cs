using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DMS.Business;

namespace DMS.WebAPi.Controllers
{
    public class CustomerController : ApiController
    {
        private CustomerManager customerManager;
        public CustomerController()
        {
            customerManager = new CustomerManager();
        }
        public string getdata()
        {
            return customerManager.GetCompanyName();
        }
    }
}
