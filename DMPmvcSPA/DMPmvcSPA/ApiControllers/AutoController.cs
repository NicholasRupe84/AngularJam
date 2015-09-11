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
            return new AutoViewModel
            {
                user = Models.User.currentPerson,
                pageName = "Home"
            };
        }
    }
}