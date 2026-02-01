namespace AiTech.WebUi.DTOs.GeminiDtos
{
    // Main request DTO for Gemini AI API
    public class GeminiRequestDto
    {
        public List<Content> contents { get; set; } // List of conversation contents
        public GenerationConfig? generationConfig { get; set; } // Optional generation settings
    }

    // Represents a message in the conversation
    public class Content
    {
        public string role { get; set; } // Role: "user", "assistant", or "system"
        public List<Part> parts { get; set; } // Content parts (text, images, etc.)
    }

    // Represents a part of content (typically text)
    public class Part
    {
        public string text { get; set; } // Text content for the part
    }

    // Configuration for response generation
    public class GenerationConfig
    {
        public float? temperature { get; set; } // Controls randomness: 0 = deterministic, 1 = creative
        public int? maxOutputTokens { get; set; } // Maximum tokens in response
    }
}