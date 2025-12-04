namespace Syncline.Client.Models
{
    public class ChatMessageDto
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public string RoomId { get; set; }
        public string Message { get; set; }
        public DateTime SentAt { get; set; }
    }
}
