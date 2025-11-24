


using System.Reflection.Metadata;
using Syncline.Domain.Entities;

public class MessageService : IMessageService
{

    private readonly IMessageRepository _messageRepository;
    public MessageService(IMessageRepository messageRepository)
    {
        _messageRepository = messageRepository;
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
        return await _messageRepository.CreateMessageAsync(ChatMessage);
    }

    public async Task<List<ChatMessage>> GetMessagesByRoomId(string roomId)
    {
        return await _messageRepository.GetMessageByRoomIdAaync(roomId);
    }
}