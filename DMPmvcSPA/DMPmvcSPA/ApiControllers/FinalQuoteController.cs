using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DMPmvcSPA.Models;

namespace DMPmvcSPA.Controllers
{
    public class FinalQuoteController : ApiController
    {
        public string Put(FinalQuoteViewModel viewModel)
        {
            return "Complete";
        }
    }
}