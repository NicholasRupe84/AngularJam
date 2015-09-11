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
            //process data here

            return new HomeViewModel
            {
                user = Models.User.currentPerson,
                pageName = "Motorcycle"
            };
        }
    }
}