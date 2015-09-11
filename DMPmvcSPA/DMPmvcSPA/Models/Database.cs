using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMPmvcSPA.Models
{
    public static class Database
    {
        private static List<Person> dataList = new List<Person>();
        
        public static Person GetData(string ssn)
        {
            initialize();
            return dataList.Find(x => x.ssn.Equals(ssn));
        }

        private static void initialize()
        {
            dataList.Add(new Person
            {
                firstName = "Bob",
                middleName = "G",
                lastName = "Smith",
                ssn = "000000000",
                car = true,
                house = true,
                motorcycle = true
            });
            dataList.Add(new Person
            {
                firstName = "Khasan",
                middleName = "Fleur Ó",
                lastName = "Floinn",
                car = true,
                house = true,
                motorcycle = false
            });
            dataList.Add(new Person
            {
                firstName = "Shahrokh",
                middleName = "Ahmed",
                lastName = "Markovic",
                car = true,
                house = false,
                motorcycle = false
            });
            dataList.Add(new Person
            {
                firstName = "Aygün",
                middleName = "Amalthea",
                lastName = "Chvátal",
                car = false,
                house = false,
                motorcycle = false
            });
            dataList.Add(new Person
            {
                firstName = "Amos",
                middleName = "Fulco",
                lastName = "Klerkx",
                car = false,
                house = true,
                motorcycle = true
            });
            dataList.Add(new Person
            {
                firstName = "Ignacy",
                middleName = "Chiemeka",
                lastName = "McCabe",
                car = false,
                house = false,
                motorcycle = true
            });
            dataList.Add(new Person
            {
                firstName = "Sigurd",
                middleName = "Mallory",
                lastName = "Leggièri",
                car = false,
                house = false,
                motorcycle = false
            });
            dataList.Add(new Person
            {
                firstName = "Cedric",
                middleName = "Lana",
                lastName = "Di Pietro",
                car = true,
                house = false,
                motorcycle = true
            });
        }
    }

    public class Person
    {
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string ssn { get; set; }
        public bool house { get; set; }
        public bool car { get; set; }
        public bool motorcycle { get; set; }
    }
}