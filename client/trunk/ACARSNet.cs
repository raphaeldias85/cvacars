using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace cvacars
{
    class ACARSNet
    {
        string server = "acars.comairva.org";
        UInt16 port = 16579;
        UdpClient udpClient = null;
        TcpClient tcpClient = null;
        NetworkStream stream = null;
        private bool Iconnected = false;
        public bool connected
        {
            get
            {
                return this.Iconnected;
            }
            set { } // Disregard external changes.
        }

        public ACARSNet()
        {  }
        public ACARSNet(UInt16 port)
        {
            this.port = port;
        }
        public void setServer(string hostName)
        {
            this.server = hostName;
        }

        public int connect()
        {
            tcpClient = new TcpClient(server, port);
            stream = tcpClient.GetStream();
            string response = this.writeMessage("HELLO");  //PENDING PROTOCOL SPEC
            if (response == "")
                return 0;

            return 1;
        }
        private string writeMessage(string message)
        {
            if (
                !stream.CanWrite ||
                !stream.CanRead
                )
                return "";
            try
            {
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
                System.Console.WriteLine("SENDING: " + message);
                stream.Write(data, 0, data.Length);
                System.Console.WriteLine("SENT!");
                string response = "";
                while (stream.DataAvailable)
                {
                    byte[] a = new byte[1];
                    int b = stream.Read(a, 0, a.Length);
                    response += System.Text.Encoding.ASCII.GetString(a);
                }
                return response;

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return "";
            }
        }
    }
}
