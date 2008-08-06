using System;
using System.Collections.Generic;
using System.Text;

using System.Diagnostics;
using System.Xml.Serialization;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace libcvacars
{
    public class SOAPClient
    {
        SOAPClientService service = new SOAPClientService();
    }

    [System.Web.Services.WebServiceBindingAttribute( Name = "urn:ItemManager", Namespace = "http://localhost:8070/apache-soap/servlet/rpcrouter" )]
    class SOAPClientService : System.Web.Services.Protocols.SoapHttpClientProtocol
    {
        public SOAPClientService()
        {
            this.Url = "http://localhost:8080/apache-soap/servlet/rpcrouter";
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute( "", RequestNamespace = "urn:HelloService", ResponseNamespace = "urn:HelloService", Use = System.Web.Services.Description.SoapBindingUse.Encoded, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped )]
        public string CurrentDateTime()
        {
            object[] results = this.Invoke( "DateTime", new object[] { "now" } );
            return ( (string)( results[0] ) );
        }
    }
}
