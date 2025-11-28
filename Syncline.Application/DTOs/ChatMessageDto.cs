public class ChatMessageDto
{
    public Guid Id { get; set; }
    public string RoomId { get; set; } = string.Empty;
    public string User { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public DateTime SentAt { get; set; }    
}