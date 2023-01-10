using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;


var connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5000/hubs/NotificationHub")
                .AddMessagePackProtocol()
                .ConfigureLogging(x =>
                {
                    x.AddConsole();
                    x.SetMinimumLevel(LogLevel.Error);
                })
                .Build();

Console.WriteLine("Podaj Nazwę użytkownika");
var username = Console.ReadLine();




connection.On<string, string>("ShowMessage", (username, message) =>
{

    Console.WriteLine($"{username}: {message}");
});

await connection.StartAsync();




while (true)
{

    var message = Console.ReadLine();
    await connection.InvokeAsync("SendMessageToAllClients", username, message);

}

