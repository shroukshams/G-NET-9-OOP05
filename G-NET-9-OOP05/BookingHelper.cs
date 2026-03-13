using G_NET_9_OOP05;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace G_NET_9_OOP05
{


    public static class BookingHelper
    {
        public static void PrintAll(IPrintable[] printables)
        {
            Console.WriteLine("\n--- BookingHelper.PrintAll ---");
            foreach (var item in printables)
            {
                Console.WriteLine(item.Print());
            }
        }
    }
}
        

