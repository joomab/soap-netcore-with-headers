using System.ServiceModel;
using System.ServiceModel.Channels;

namespace Models
{
    [ServiceContract]
    public interface ISampleService
    {
        [OperationContract]
        string Test(string s);
        [OperationContract]
        void XmlMethod(System.Xml.Linq.XElement xml);
        [OperationContract]
        MyCustomModel TestCustomModel(MyCustomModel inputModel);
        object BeforeSendRequest(ref Message request, IClientChannel channel);
    }
}