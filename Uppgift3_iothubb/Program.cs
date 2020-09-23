using System;
using System.Threading.Tasks;
using Microsoft.Azure.Devices.Client;
using SharedLibraries.Models;
using SharedLibraries.Services;

namespace Uppgift3_iothubb
{
    class Program
    {
        private static readonly string _conn = "HostName=EC-WIN20-MB-IoT-hubb-1.azure-devices.net;DeviceId=ConsoleApp;SharedAccessKey=KhOzfu1bdjGysi3hmNSD+lA7RBVHjjtoaThZ+c0RIyY=";
        private static readonly DeviceClient deviceClient = DeviceClient.CreateFromConnectionString(_conn, TransportType.Mqtt);

        static void Main(string[] args)
        {
            DeviceService.SendMessageAsync(deviceClient).GetAwaiter();

            Console.ReadKey();
        }
    }
}
