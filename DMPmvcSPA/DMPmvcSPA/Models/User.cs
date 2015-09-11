using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMPmvcSPA.Models
{
    public static class User
    {
        public static Person currentPerson;

        public static void populateUser(Person person)
        {
            currentPerson = person;
        }
    }
}