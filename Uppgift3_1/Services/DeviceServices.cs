﻿using Microsoft.Azure.Amqp.Framing;
using Microsoft.Azure.Devices.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Uppgift3_1.Models;

namespace Uppgift3_1.Services
{
    public static class DeviceServices
    {
        private static readonly Random rnd = new Random();
        public static async Task SendMessageAsync(DeviceClient deviceClient)
        {
            while (true)
            {
                var data = new TemperatureModel
                {
                    Temperature = rnd.Next(40),
                    Humidity = rnd.Next(30, 80)
                };

                var json = JsonConvert.SerializeObject(data);

                var payload = new Message(Encoding.UTF8.GetBytes(json));
                await deviceClient.SendEventAsync(payload);

                Console.WriteLine($"Message sent {json}");
                await Task.Delay(15 * 1000);
            }       
        }
    }
}
