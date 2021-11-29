using Models;
using soap_exercice.Models;
using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Xml.Linq;
public class SampleService : IClientMessageInspector, ISampleService
{
    public string Test(string s)
    {
        Console.WriteLine("Test Method Executed!");
        return s;
    }
    public void XmlMethod(XElement xml)
    {
        Console.WriteLine(xml.ToString());
    }
    public MyCustomModel TestCustomModel(MyCustomModel customModel)
    {
        return customModel;
    }

    public void AfterReceiveReply(ref Message reply, object correlationState)
    {
        throw new NotImplementedException();
    }

    public object BeforeSendRequest(ref Message request, IClientChannel channel)
    {
        Headers head = new Headers();
        request.Headers.Add(head);
        return head;
        //throw new NotImplementedException();
    }
}