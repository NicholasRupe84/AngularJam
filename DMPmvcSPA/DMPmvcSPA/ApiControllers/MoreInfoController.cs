using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DMPmvcSPA.Models;

namespace DMPmvcSPA.Controllers
{
    public class MoreInfoController : ApiController
    {
        public MoreInfoViewModel Put(MoreInfoViewModel viewModel)
        {
            var user = Models.User.currentPerson;
            string pageName = "";

            if (user.car == true)
            {
                pageName = "Auto";
            }
            else if (user.house == true)
            {
                pageName = "Home";
            }
            else if (user.motorcycle == true)
            {
                pageName = "Motorcycle";
            }
            else
            {
                pageName = "Auto";
            }

            return new MoreInfoViewModel
            {
                user = Models.User.currentPerson,
                pageName = pageName
            };
        }
    }
}