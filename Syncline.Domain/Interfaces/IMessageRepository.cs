

using Syncline.Domain.Entities;

public interface IMessageRepository
{
    Task<ChatMessage> CreateMessageAsync(ChatMessage message);
    Task<List<ChatMessage>> GetMessageByRoomIdAaync(string roomId);
}