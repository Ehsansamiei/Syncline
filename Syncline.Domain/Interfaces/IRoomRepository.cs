

public interface IRoomRepository
{
    Task JoinRoomAsync(string ConnectionId, string roomId);
    Task LeaveRoomAsync(string ConnectionId, string roomId);
}