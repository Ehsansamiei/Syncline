using System.Net.Http.Json;
using Syncline.Client.Models;

public class MessageApiService
{
    private readonly HttpClient _http;

    public MessageApiService(HttpClient http)
    {
        _http = http;
    }

    public async Task<ChatMessageDto> SendMessage(ChatMessageDto dto)
    {
        var res = await _http.PostAsJsonAsync("api/message", dto);
        return await res.Content.ReadFromJsonAsync<ChatMessageDto>();
    }
}
