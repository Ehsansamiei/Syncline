

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

[ApiController]
[Route("api/[controller]")]
public class MessageController : ControllerBase
{
    private readonly IMessageService _messageService;

    public MessageController(IMessageService messageService)
    {
        _messageService = messageService;
    }


    [HttpPost]
    public async Task<IActionResult> CreateMessage([FromBody] CreateMessageDto dto)
    {
        var msg = await _messageService.CreateMessage(
            dto.RoomId,
            dto.User,
            dto.Message
        );
        return Ok(msg);
    }
}

public class CreateMessageDto
{
    public string RoomId { get; set; }
    public string User { get; set; }    
    public string Message { get; set; }
}