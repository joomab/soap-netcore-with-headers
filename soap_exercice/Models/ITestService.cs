using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

namespace soap_exercice.Models
{
    [MessageContract(IsWrapped = false)]
    public class TestMessage
    {
        [MessageHeader]
        public string Security;

        [MessageBodyMember]
        public string Body;

        public TestMessage()
        {
        }

        public TestMessage(string security, string body)
        {
            Security = security;
            Body = body;
        }
    }

    [ServiceContract]
    public interface ITestService
    {
        [OperationContract]
        void Operation(TestMessage message);
    }
}
