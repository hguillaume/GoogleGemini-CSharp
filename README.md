# GoogleGemini-CSharp
Using Google Gemini AI in C#

Create Google Gemini API Key Here: https://aistudio.google.com/app/api-keys

Install the Google Generative AI NuGet package:
```
dotnet add package Google_GenerativeAI
```

Create a cs file named "GoogleGeminiAPIKey.cs" and add the following code with your API Key:
```csharp
namespace GoogleGeminiAPIKey
{
    static class GoogleGeminiAPIKey
    {
        public const string APIKey = "abcdef"; // Replace with your actual API key
    }
}
```