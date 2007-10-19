using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
//using System.Net;
using N = System.Net;
using System.Text;
using System.Threading;

namespace cvacarsd
{
    class Program
    {
        N.Sockets.TcpListener server;
        public static Hashtable handles;
        public static Hashtable handlesByConnect;
        int port = 15677;

        static void Main(string[] args)
        {
            handles = new Hashtable(512);
            handlesByConnect = new Hashtable(512);
            Program P = new Program();
        }

        public Program()
        {
            server = new N.Sockets.TcpListener(port);
            while (true)
            {
                server.Start();
                if (server.Pending())
                {
                    N.Sockets.TcpClient connection = server.AcceptTcpClient();
                    Console.WriteLine("Connection created");
                    //Custom
                }
            }
        }
    }

    private class Messenger
    {
        N.Sockets.TcpClient client;
        System.IO.StreamReader sr;
        System.IO.StreamWriter sw;
        string handle;

        public Messenger(System.Net.Sockets.TcpClient c)
        {
            client = c;
            Thread t = new Thread(new ThreadStart(init));
            t.Start();
        }
        private string GetHandle()
        {
            sw.WriteLine("HANDLE?");
            sw.Flush();
            return sr.ReadLine();
        }
        private void run()
        {
            try
            {
                string l = "";
                while (true)
                {
                    l = sr.ReadLine();
                    Program.sendToAll(handle, l);
                }
            }
            catch ( Exception e44 )
            {
                Console.WriteLine(e44);
            }
        }
        private void init()
        {
            sr = new System.IO.StringReader(client.GetStream());
            sw = new System.IO.StreamWriter(client.GetStream());
            sw.WriteLine("HELLO");
            handle = GetHandle();
            while (Program.handles.Contains(handle))
            {
                sw.WriteLine("PILOTINUSE");
                Thread.CurrentThread.Abort();
            }
            Program.handles.Add(handle, client);
            Program.handlesByConnect.Add(client, handle);
            sw.WriteLine("CONNECTED");
            sw.Flush();
            Thread t = new Thread(new ThreadStart(run));
            t.Start();
        }
    }
}
