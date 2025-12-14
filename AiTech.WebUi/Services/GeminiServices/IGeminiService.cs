namespace AiTech.WebUi.Services.GeminiServices
{
    public interface IGeminiService
    {
        Task<string> GetGeminiDataAsync(string prompt);
    }
}
