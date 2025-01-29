using System;
using System.Text.Json;
using Online_Assessment;
using Online_Assessment.Shared.Model;

namespace Online_Assessment.Shared.Services
{

public class QuestionService
{
    private readonly HttpClient _httpClient;

    public QuestionService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Question>> GetQuestionsAsync()
    {
        var response = await _httpClient.GetStringAsync("questions.json");
        return JsonSerializer.Deserialize<List<Question>>(response, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
    }
}
}
