using System;
using System.Threading.Tasks;
using Microsoft.Azure.Devices.Client;
using SharedLibaries.Models;
using SharedLibaries.Services;

namespace ConsoleApp_4
{
    class Program
    {

        private static readonly string _conn = "HostName=ec-win20-iothubida.azure-devices.net;DeviceId=consoleapp;SharedAccessKey=ejgLOFauDEcazZlOsZ4DJQ/QJsSIZ0O1j6EmKwcpKdI=";
        
        private static readonly DeviceClient deviceClient = DeviceClient.CreateFromConnectionString(_conn, TransportType.Mqtt);

        static void Main(string[] args)
        {

            DeviceService.SendMessageAsync(deviceClient).GetAwaiter();
            DeviceService.ReceiveMessageAsync(deviceClient).GetAwaiter();

            Console.ReadKey();
        }
    }
}
