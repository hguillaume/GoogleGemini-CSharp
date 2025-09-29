// Create Google Gemini API Key Here: https://aistudio.google.com/app/api-keys
// dotnet add package Google_GenerativeAI

using GenerativeAI;
using GoogleGeminiAPIKey;

var apiKey = GoogleGeminiAPIKey.GoogleGeminiAPIKey.APIKey;

var googleAI = new GoogleAi(apiKey);

// List of Google Gemini models:  https://ai.google.dev/gemini-api/docs/models#gemini-2.0-flash
var model = googleAI.CreateGenerativeModel("models/gemini-2.0-flash-001");
//var model = googleAI.CreateGenerativeModel("models/gemini-2.5-flash");
//var model = googleAI.CreateGenerativeModel("models/gemini-2.5-flash-lite");
//var model = googleAI.CreateGenerativeModel("models/gemini-2.5-pro");

var response = await model.GenerateContentAsync("Why is the sky blue?");
Console.WriteLine(response.Text());
Console.ReadLine();