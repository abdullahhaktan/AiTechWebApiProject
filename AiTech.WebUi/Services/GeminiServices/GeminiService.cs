using AiTech.WebUi.DTOs.GeminiDtos;
using Newtonsoft.Json;
using System.Text;

namespace AiTech.WebUi.Services.GeminiServices
{
    public class GeminiService : IGeminiService
    {
        // HTTP client for API calls and configuration values
        private readonly HttpClient _client;
        private readonly string _apiKey;
        private const string Model = "gemini-2.5-flash";
        private const string BaseUrl = "https://generativelanguage.googleapis.com/v1beta/models/";

        public GeminiService(HttpClient client, IConfiguration configuration)
        {
            _client = client;
            _apiKey = configuration["Gemini:ApiKey"]; // Get API key from app configuration
        }

        // Main method to get response from Gemini AI
        public async Task<string> GetGeminiDataAsync(string prompt)
        {
            // Construct request body according to Gemini API structure
            var requestBody = new GeminiRequestDto
            {
                contents = new List<Content>
                {
                    new Content
                    {
                        role="user", // User role for the prompt
                        parts = new List<Part>
                        {
                            new Part
                            {
                                text = prompt // User's input prompt
                            }
                        }
                    }
                },
                generationConfig = new GenerationConfig
                {
                    temperature = 1f, // Controls randomness (1.0 = default)
                    maxOutputTokens = 5000 // Maximum response length
                }
            };

            // Serialize request to JSON
            var jsonContent = JsonConvert.SerializeObject(requestBody);

            // Create HTTP content with proper encoding and content type
            var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            // Build API URL with model and API key
            var url = $"{BaseUrl}{Model}:generateContent?key={_apiKey}";

            // Send POST request to Gemini API
            var response = await _client.PostAsync(url, httpContent);

            // Check if request was successful
            if (!response.IsSuccessStatusCode)
            {
                var message = await response.Content.ReadAsStringAsync();
                return message; // Return error message
            }

            // Read and parse successful response
            var responseString = await response.Content.ReadAsStringAsync();

            // Deserialize JSON response to DTO
            var geminiResponse = JsonConvert.DeserializeObject<GeminiResponseDto>(responseString);

            // Extract text from nested response structure
            var resultText = geminiResponse.candidates.FirstOrDefault().content.parts.FirstOrDefault().text;

            return resultText ?? "Yanıt Alınamadı"; // Return result or default message
        }
    }
}