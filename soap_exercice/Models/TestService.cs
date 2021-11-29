using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace soap_exercice.Models
{
    public class TestService : ITestService
    {
        public void Operation(TestMessage message)
        {
            throw new NotImplementedException();
        }
    }
}
