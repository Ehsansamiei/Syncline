using Microsoft.EntityFrameworkCore;
using Syncline.Domain.Entities;


namespace Syncline.Persistence.Context;

public class SynclineDbContext : DbContext
{
    public SynclineDbContext(DbContextOptions<SynclineDbContext> options) : base(options)
    {
    }

    public DbSet<ChatMessage> ChatMessages => Set<ChatMessage>();
}