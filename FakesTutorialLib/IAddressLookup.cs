using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakesTutorialLib
{
    public interface IAddressLookup
    {
        Address GetAddress(int personId);
    }
}
