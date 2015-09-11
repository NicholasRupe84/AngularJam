using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DMPmvcSPA.Models;

namespace DMPmvcSPA.Controllers
{
    public class HomeController : ApiController
    {
        public HomeViewModel Put(HomeViewModel viewModel)
        {
            var user = Models.User.currentPerson;
            string pageName = "";

            if (user.motorcycle == true)
            {
                pageName = "Motorcycle";
            }
            else
            {
                pageName = "FinalQuote";
            }

            return new HomeViewModel
            {
                user = Models.User.currentPerson,
                pageName = pageName
            };
        }
    }
}