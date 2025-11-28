


using System.Reflection.Metadata;
using Syncline.Domain.Entities;
using Syncline.Api.Hubs;
using Syncline.Application.DTOs;
using Microsoft.AspNetCore.SignalR;

public class MessageService : IMessageService
{

    private readonly IMessageRepository _messageRepository;
    private readonly IHubContext<ChatHub> _hubContext;
    public MessageService(IMessageRepository messageRepository, IHubContext<ChatHub> hubContext)
    {
        _messageRepository = messageRepository;
        _hubContext = hubContext;

    }

    public async Task<ChatMessage> CreateMessage(string roomId, string user, string message)
    {
        var ChatMessage = new ChatMessage
        {
            Id = Guid.NewGuid(),
            RoomId = roomId,
            UserId = user,
            Message = message,
            SentAt = DateTime.UtcNow
        };
        
        var saved = await _messageRepository.CreateMessageAsync(ChatMessage);

        await _hubContext.Clients.Group(roomId).SendAsync("ReceiveMessage", saved);

        return saved;
    }

    public async Task<List<ChatMessage>> GetMessagesByRoomId(string roomId)
    {
        return await _messageRepository.GetMessageByRoomIdAaync(roomId);
    }
}