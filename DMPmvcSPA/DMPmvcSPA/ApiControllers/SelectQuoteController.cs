using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DMPmvcSPA.Models;

namespace DMPmvcSPA.Controllers
{
    public class SelectQuoteController : ApiController
    {
        public SelectQuoteViewModel Put(SelectQuoteViewModel viewModel)
        {
            //process data

            return new SelectQuoteViewModel
            {
                user = Models.User.currentPerson,
                pageName = "Auto"
            };
        }
    }
}