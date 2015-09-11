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
        public FinalQuoteViewModel Put(FinalQuoteViewModel viewModel)
        {
            return new FinalQuoteViewModel
            {
                user = Models.User.currentPerson,
                pageName = "Complete"
            };
        }
    }
}