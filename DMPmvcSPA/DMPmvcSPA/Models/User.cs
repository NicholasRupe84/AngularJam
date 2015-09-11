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

        public static void updateAuto(bool autoSelected)
        {
            currentPerson.car = autoSelected;
        }

        public static void updateHome(bool homeSelected)
        {
            currentPerson.house = homeSelected;
        }

        public static void updateMotorcycle(bool motorcycleSelected)
        {
            currentPerson.motorcycle = motorcycleSelected;
        }
    }
}