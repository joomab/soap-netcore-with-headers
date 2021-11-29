using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace soap_exercice.Models
{
    public class Security : MessageHeader
    {
        public Headers UsernameToken { get; set; }

        public override string Name => this.GetType().Name;

        public override string Namespace => "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd";

        public override bool MustUnderstand => true;

        protected override void OnWriteHeaderContents(XmlDictionaryWriter writer, MessageVersion messageVersion)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Headers));
            serializer.Serialize(writer, this.UsernameToken);
        }
    }
}
