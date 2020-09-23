using Microsoft.Azure.Devices.Client;
using System;
using Uppgift3_1.Services;

namespace Uppgift3_1
{
    class Program
    {
        private static readonly string _conn = "HostName=EC-WIN20-MB-IoT-hubb-1.azure-devices.net;DeviceId=ConsoleApp;SharedAccessKey=KhOzfu1bdjGysi3hmNSD+lA7RBVHjjtoaThZ+c0RIyY=";
        private static readonly DeviceClient deviceClient = DeviceClient.CreateFromConnectionString(_conn, TransportType.Mqtt);

        static void Main(string[] args)
        {
            DeviceServices.SendMessageAsync(deviceClient).GetAwaiter();

            Console.ReadKey();
            
        }
    }
}
