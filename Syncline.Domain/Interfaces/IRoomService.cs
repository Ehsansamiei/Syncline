public interface IRoomService
{
    Task JoinRoom(string ConnectionId, string roomId);
    Task LeaveRoom(string ConnectionId, string roomId);
}