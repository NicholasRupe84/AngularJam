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
            var user = Models.User.currentPerson;
            Models.User.updateAuto(viewModel.updatedCar);
            Models.User.updateHome(viewModel.updatedHome);
            Models.User.updateMotorcycle(viewModel.updatedMotorcycle);

            string pageName = "";


//            if (user.car == true)
//            {
//                pageName = "Auto";
//            }
//            else if (user.house == true)
//            {
//                pageName = "Home";
//            }
//            else if (user.motorcycle == true)
//            {
//                pageName = "Motorcycle";
//            }
//            else
//            {
//                pageName = "Auto";
//            }

            return new SelectQuoteViewModel
            {
                user = Models.User.currentPerson,
                pageName = "MoreInfo"
            };
        }
    }
}