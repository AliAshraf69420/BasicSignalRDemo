using Microsoft.AspNetCore.SignalR;

public class MyHub : Hub
{
    public async Task SendOrdersToClients(string message) {
    await Clients.All.SendAsync("ReceiveOrderUpdate",message);
    }
}