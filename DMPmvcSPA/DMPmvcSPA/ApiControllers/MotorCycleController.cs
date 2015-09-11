using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DMPmvcSPA.Models;

namespace DMPmvcSPA.Controllers
{
    public class MotorcycleController : ApiController
    {
        public MotorcycleViewModel Put(MotorcycleViewModel viewModel)
        {
            return new MotorcycleViewModel
            {
                user = Models.User.currentPerson,
                pageName = "FinalQuote"
            };
        }
    }
}