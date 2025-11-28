

using Microsoft.AspNetCore.Mvc;

namespace Syncline.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly IMessageService _messageService;

        public ChatController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpGet("messages/{roomId}")]
        public async Task<IActionResult> GetMessages(string roomId)
        {
            var messages = await _messageService.GetMessagesByRoomId(roomId);
            return Ok(messages);
        }
    }
}