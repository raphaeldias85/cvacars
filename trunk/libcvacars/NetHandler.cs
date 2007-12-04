using System;
using System.Collections.Generic;
using System.Text;

using System.Net;
using System.Net.Sockets;

namespace libcvacars
{
    public class NetHandler
    {
        private IPAddress serverHost;
        private UInt16 serverPort;
        private string serverURL;
        private string sessionKey;
        private Queue<string> outputBuffer;
        private Queue<string> inputBuffer;
        public int buildNumber
        {
            set { }
            get
            {
                return
                    Environment.Version.Major * 100 +
                    Environment.Version.Minor * 10 +
                    Environment.Version.Revision;
            }
        }
        public NetHandler()
        {
#if TRACE
            System.Console.Out.WriteLine("* New NetHandler...");
#endif
#if DEBUG
            System.Console.Out.WriteLine("* NetHandler version: " + this.buildNumber.ToString());
#endif
        }
    }
}
