using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace libcvacars
{
    /// <summary>
    /// Network class for cvacars
    /// </summary>
    public class Network
    {
        public readonly bool connected = false;
        public readonly bool canConnect = true;

        string server = "";
        UInt16 port;

        /// <summary>
        /// Constructor.  Creates object.
        /// </summary>
        /// <param name="server">IP address of the server to connect</param>
        /// <param name="port">Port to connect to the server with</param>
        public Network( string server, UInt16 port )
        {
            this.server = server;
            this.port = port;
            connect();
        }
        public int connect()
        {
            System.Net.IPAddress ipAddress = null;
            System.Net.IPEndPoint ipEndPoint = null;
            try
            {
                Socket socketListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                ipAddress = System.Net.IPAddress.Parse(server);
                ipEndPoint = new System.Net.IPEndPoint(ipAddress, port);
                socketListener.Connect(ipEndPoint);
            }
            catch (Exception ex)
            {
                ErrorHandling.error(ex);
                connected = false;
                canConnect = false;
                return 1;
            }
            return 0;
        }
    }
}
