﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DMPmvcSPA.Models;

namespace DMPmvcSPA.Controllers
{
    public class DefaultController : ApiController
    {
        public SelectQuoteViewModel Put(DefaultViewModel viewModel)
        {
            //process data here
            Models.User.populateUser(Database.GetData(viewModel.socialSecurity));
            
            return new SelectQuoteViewModel
            {
                pageName = "SelectQuote",
                user = Models.User.currentPerson
            };
        }
    }
}