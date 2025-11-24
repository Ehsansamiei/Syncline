

using Microsoft.EntityFrameworkCore;
using Syncline.Domain.Entities;
using Syncline.Persistence.Context;

namespace Syncline.Persistence.Repositories;

public class MessageRepository : IMessageRepository
{

    private readonly SynclineDbContext _context;

    public MessageRepository(SynclineDbContext context)
    {
        _context = context;
    }

    public async Task<ChatMessage> CreateMessageAsync(ChatMessage message)
    {
        await _context.ChatMessages.AddAsync(message);
        await _context.SaveChangesAsync();
        return message;
    }

    public async Task<List<ChatMessage>> GetMessageByRoomIdAaync(string roomId)
    {
        return await _context.ChatMessages
            .Where(m => m.RoomId == roomId)
            .OrderBy(m => m.SentAt)
            .ToListAsync();
    }
}