using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EMSAPI.Controllers
{
    public class StuentController : ApiController
    {
        [HttpGet]
        public string Get()
        {
            return "Hello from Student API";
        }

        [HttpPost]
        public string Post(int n)
        {
            return "Hello from Student Post API - " + n.ToString();
        }
    }
}
