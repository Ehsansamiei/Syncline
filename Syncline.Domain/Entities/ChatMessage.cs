

namespace Syncline.Domain.Entities
{
    public class ChatMessage
    {
        public Guid Id { get; set; }
        public string UserId { get; set; } = default;
        public string Message { get; set; } = default;
        public DateTime CreatedAt { get; set; }
    }
}