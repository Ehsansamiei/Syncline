
using Microsoft.AspNetCore.SignalR;
namespace Syncline.Api.Hubs;

public class ChatHub : Hub
{
    private readonly IMessageService _messageService;
    private readonly IRoomService _roomService;

    public ChatHub(IMessageService messageService, IRoomService roomService)
    {
        _messageService = messageService;
        _roomService = roomService;
    }

    public override Task OnConnectedAsync()
    {
        return base.OnConnectedAsync();
    }

    public override Task OnDisconnectedAsync(Exception? exception)
    {
        return base.OnDisconnectedAsync(exception);
    }


    public async Task SendMessage(string roomId, string user, string message)
    {
        var saved = await _messageService.CreateMessage(roomId, user, message);

    }

    public async Task JoinRoom(string roomId)
    {
        await _roomService.JoinRoom(Context.ConnectionId, roomId);
        await Groups.AddToGroupAsync(Context.ConnectionId, roomId);
    }

    public async Task LeaveRoom(string roomId)
    {
        await Groups.RemoveFromGroupAsync(Context.ConnectionId, roomId);
        await _roomService.LeaveRoom(Context.ConnectionId, roomId);
    }


}