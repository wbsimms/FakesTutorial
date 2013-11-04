using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakesTutorialLib
{
    public class Person
    {
        private IAddressLookup addressLookup;
        public Address HomeAddress { get; set; } 

        public Person(int id, IAddressLookup addressLookup)
        {
            this.addressLookup = addressLookup;
            this.HomeAddress = addressLookup.GetAddress(id);
        }
    }
}
