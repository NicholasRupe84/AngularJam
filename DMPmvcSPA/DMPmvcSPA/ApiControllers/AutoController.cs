using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DMPmvcSPA.Models;

namespace DMPmvcSPA.Controllers
{
    public class AutoController : ApiController
    {
        public AutoViewModel Put(AutoViewModel viewModel)
        {
            var user = Models.User.currentPerson;
            string pageName = "";

            if (user.house == true)
            {
                pageName = "Home";
            }
            else if (user.motorcycle == true)
            {
                pageName = "Motorcycle";
            }
            else
            {
                pageName = "FinalQuote";
            }

            return new AutoViewModel
            {
                user = Models.User.currentPerson,
                pageName = pageName
            };
        }
    }
}