using Syncline.Domain.Entities;

public class ChatRoom
{
    public string Id { get; set; }
    public List<ChatMessage> Messages { get; set; }
}