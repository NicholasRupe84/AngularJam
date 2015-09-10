using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace App.DestinationMarketplaceSPA.ApiControllers
{
    public class MainController : ApiController
    {
        private List<string> pages = new List<string> {"Index", "SelectQuotes", "Auto", "Home", "Motorcycle", "Final"};

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public string Put(string pageName, [FromBody]string value)
        {
            var currentIndex = pages.IndexOf(pageName);
            currentIndex++;
            return pages[currentIndex];
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}