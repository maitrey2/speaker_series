﻿using College.Service.Protos;
using Grpc.Net.Client;
using System;
using System.Threading.Tasks;

namespace College.ServiceClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new AddressBookService.AddressBookServiceClient(channel);

            var userAddress = new AddressAdditionRequest { Name = "22 Feb 2020", Address = "Webinar" };
            var reply = await client.AddUserAddressAsync(userAddress);
            Console.WriteLine("Greeting: " + reply.Message);

            // Health Data
            var healthData = new HealthRequest { Name = "Test Name", HealthParameter1 = 100, HealthParameter2 = 120};
            var results = await client.AddPersonHealthDataAsync(healthData);
            
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
