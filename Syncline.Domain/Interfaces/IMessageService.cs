using Syncline.Domain.Entities;

public interface IMessageService
{
    Task<ChatMessage> CreateMessage(string roomId, string user, string message);
    Task<List<ChatMessage>> GetMessagesByRoomId(string roomId);
}
