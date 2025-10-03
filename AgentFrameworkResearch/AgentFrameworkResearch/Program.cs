using GeminiDotnet;
using GeminiDotnet.Extensions.AI;
using Microsoft.Extensions.AI;

var options = new GeminiClientOptions { ApiKey = Environment.GetEnvironmentVariable("googleAiStudioApiKey")!, ModelId = "gemini-2.5-flash" };
IChatClient client =
    new GeminiChatClient(options);

Console.WriteLine(await client.GetResponseAsync("What is AI?"));
Console.ReadLine();