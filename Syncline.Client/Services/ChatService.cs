using Microsoft.AspNetCore.SignalR.Client;
using Syncline.Client.Models;

namespace Syncline.Client.Services;
public class ChatService
{
    private HubConnection _hubConnection;

    public event Action<ChatMessageDto>? OnMessageReceived;

    public async Task Connect(string roomId)
    {
        _hubConnection = new HubConnectionBuilder()
            .WithUrl("http://localhost:5068/chatHub")
            .WithAutomaticReconnect()
            .Build();

        _hubConnection.On<ChatMessageDto>("ReceiveMessage", (msg) =>
        {
            OnMessageReceived?.Invoke(msg);
        });

        await _hubConnection.StartAsync();
        await _hubConnection.InvokeAsync("JoinRoom", roomId);
    }

    public async Task SendMessage(string roomId, string user, string text)
    {
        await _hubConnection.InvokeAsync("SendMessage", roomId, user, text);
    }
}
