using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        public Person()
        {

        }

        public Person(string name,string family,string address,string addressCity)
        {
            Name = name;
            Family = family;
            Address = address;
            AddressCity = addressCity;
        }

        public string Name { get; set; }
        public string Family { get; set; }
        public string Address { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string FaxNumber { get; set; }

            

    }




}
