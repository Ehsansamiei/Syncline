using Microsoft.EntityFrameworkCore;
using Syncline.Persistence.Context;
using Syncline.Persistence.Repositories;
using Syncline.Api.Hubs;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

builder.Services.AddSignalR();

builder.Services.AddScoped<IMessageService, MessageService>();
builder.Services.AddScoped<IMessageRepository, MessageRepository>();

builder.Services.AddScoped<IRoomService, RoomService>();
builder.Services.AddScoped<IRoomRepository, RoomRepository>();

builder.Services.AddDbContext<SynclineDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));


var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.MapHub<ChatHub>("/chatHub");
app.UseHttpsRedirection();
app.Run();
