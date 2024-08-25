// See https://aka.ms/new-console-template for more information
using Microsoft.AspNetCore.SignalR.Client;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var connection = new HubConnectionBuilder()
            .WithUrl("http://localhost:5226/hub/streaming")
            .Build();
        connection.On<string>("ReceiveOrderUpdate", HandleTraffic);
        connection.StartAsync();
        Console.ReadLine();
    }

    private static void HandleTraffic(string obj)
    {
        Console.WriteLine($"Message Received: {obj}");
    }
}