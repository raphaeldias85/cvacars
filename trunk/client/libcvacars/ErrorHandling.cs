using System;
using System.Collections.Generic;
using System.Text;

namespace libcvacars
{
    static class ErrorHandling
    {
        public bool logConsole = true;
        public bool logFile = false;

        public static void error ( Exception ex )
        {
            error(ex, false);
        }
        public static void error(Exception ex, bool fatal)
        {
            if (logConsole)
                System.Console.WriteLine("Error: " + ex.Message);
            if (fatal)
                System.Console.WriteLine("ERROR WAS FATAL!\n" + ex.StackTrace);
            Environment.Exit(1);
        }
    }
}
