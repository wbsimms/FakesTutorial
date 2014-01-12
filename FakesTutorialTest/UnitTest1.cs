using System;
using FakesTutorialLib;
using FakesTutorialLib.Fakes;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FakesTutorialTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IAddressLookup mock = new FakesTutorialLib.Fakes.StubIAddressLookup()
            {
                GetAddressInt32 = (id) => {return new Address(){Line1 = "blah",Line2= "blah2"};}
            };


            using (ShimsContext.Create())
            {
                ShimAddress.AllInstances.Line1Get = address => { return "shimmed"; };
                Person p = new Person(2, mock);
                Assert.AreEqual("shimmed",p.HomeAddress.Line1);
                Assert.AreEqual("blah2",p.HomeAddress.Line2);
            }
        }

        [TestMethod]
        public void ShimOnceTest()
        {
            using (ShimsContext.Create())
            {
                Address address = new ShimAddress()
                {
                    Line1Get = () => { return "shimmed"; },
                    Line2Get = () => { return "shimmed2"; },
                    CalculatePostage = () => { return 7.5; }
                };
                Assert.AreEqual(7.5,address.CalculatePostage());
            }
        }
    }
}
