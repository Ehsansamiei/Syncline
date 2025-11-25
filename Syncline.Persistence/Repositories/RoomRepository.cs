
using Syncline.Persistence.Context;

public class RoomRepository : IRoomRepository
{

    private readonly SynclineDbContext _context;

    public RoomRepository(SynclineDbContext context)
    {
        _context = context;
    }

    public async Task<ChatRoom> CreateRoomAsync(ChatRoom room)
    {
        _context.ChatRooms.Add(room);
        await _context.SaveChangesAsync();
        return room;
    }

    public Task JoinRoomAsync(string ConnectionId, string roomId)
    {
        return Task.CompletedTask;
    }

    public Task LeaveRoomAsync(string ConnectionId, string roomId)
    {
        return Task.CompletedTask;
    }
}