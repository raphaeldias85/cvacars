using System;
using System.Collections.Generic;
using System.Text;
using FsuipcSdk;

namespace cvacars
{
    class FSInterface
    {
        Fsuipc fsuipc = new Fsuipc();

        bool connected = false;
        bool result = false;
        int dwFSReq = FsuipcSdk.Fsuipc.SIM_ANY;
        int dwOffset = 0x0000;
        int dwSize = 4;
        int token = 0;
        int dwResult = 0;

        struct dwOffsets
        {
            static int timeHour = 0x0238;
            static int timeMinute = 0x0239;
            static int timeSecond = 0x023A;
            static int timeOffset = 0x0246; //mins
            static int pause = 0x0262;
            static int paused = 0x264;
            static int ias = 0x2bc; //kts*128
        }
        struct dwSize
        {
            static int timeHour = 1;
            static int timeMinute = 1;
            static int timeSecond = 1;
            static int timeOffset = 2;
            static int pause = 2;
            static int paused = 2;
            static int ias = 4;
        }
        
        public FSInterface()
        {
            try
            {
                fsuipc.FSUIPC_Initialization();
                System.Threading.Thread connectT = new System.Threading.Thread(new System.Threading.ThreadStart(_waitConnect));
            }
            catch (Exception ex)
            {
                System.Console.Out.WriteLine("EXCEPTION THROWN:");
                System.Console.Out.WriteLine(ex.ToString());
                System.Console.Out.WriteLine(ex.Source);
                System.Console.Out.WriteLine(ex.StackTrace);
            }
            return;
        }
        private void _waitConnect()
        {
            while (!connected)
            {
                connected = (bool)fsuipc.FSUIPC_Open(dwFSReq, ref dwResult);
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}
