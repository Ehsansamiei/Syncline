
public class RoomService : IRoomService
{

    private readonly IRoomRepository _roomRepository;

    public RoomService(IRoomRepository roomRepository)
    {
        _roomRepository = roomRepository;
    }

    public async Task JoinRoom(string ConnectionId, string roomId)
    {
        await _roomRepository.JoinRoomAsync(ConnectionId, roomId);
    }

    public async Task LeaveRoom(string ConnectionId, string roomId)
    {
        await _roomRepository.LeaveRoomAsync(ConnectionId, roomId);
    }
}