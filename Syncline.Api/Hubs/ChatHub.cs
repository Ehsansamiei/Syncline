
using Microsoft.AspNetCore.SignalR;

public class ChatHub : Hub
{
    private readonly IMessageService _messageService;
    private readonly IRoomService _roomService;

    public ChatHub(IMessageService messageService, IRoomService roomService)
    {
        _messageService = messageService;
        _roomService = roomService;
    }


    public async Task SendMessage(string roomId, string user, string message)
    {
        var chatMessage = await _messageService.CreateMessage(roomId, user, message);
        await Clients.Group(roomId).SendAsync("ReceiveMessage", chatMessage);
    }

    public async Task JoinRoom(string roomId)
    {
        await _roomService.JoinRoom(Context.ConnectionId, roomId);
        await Groups.AddToGroupAsync(Context.ConnectionId, roomId);
    }



}