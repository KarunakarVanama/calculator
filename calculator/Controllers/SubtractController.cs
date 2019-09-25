using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace calculator.Controllers
{
    public class SubtractController : ApiController
    {
        // GET: api/Subtract
        public IEnumerable<string> Get()
        {
            return new string[] { "vanama", "Karunakar" };
        }

        // GET: api/Subtract/sub
        public int Get(int a, int b)
        {
            return a-b;
        }

        
    }
}
