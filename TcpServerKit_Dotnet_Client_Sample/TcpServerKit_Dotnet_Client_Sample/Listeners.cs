using System;
using System.Collections.Generic;
using System.Text;

namespace TcpServerKit_Dotnet_Client_Sample
{
    public static class Listeners
    {
        internal static void Join(string data)
        {
            Console.WriteLine($"{data} from Joint");
        }
    }
}
