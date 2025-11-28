


using Microsoft.AspNetCore.Mvc;

namespace Syncline.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoom([FromBody] CreateRoomDto dto)
        {
            var room = await _roomService.CreateRoomAsync(dto.Name);
            return Ok(room);
        }
    }

    public class CreateRoomDto
    {
        public string Name { get; set; }
    }
}
    