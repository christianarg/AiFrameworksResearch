using System.Threading.Tasks;
using GeminiDotnet;
using GeminiDotnet.Extensions.AI;
using Microsoft.Extensions.AI;
using Microsoft.Agents.AI;

var options = new GeminiClientOptions { ApiKey = Environment.GetEnvironmentVariable("googleAiStudioApiKey")!, ModelId = "gemini-2.5-flash" };
IChatClient client = new GeminiChatClient(options);
GeminiAIAgent agent = new GeminiAIAgent(client);
Console.WriteLine(await agent.RunAsync("what is AI?. Be very concise."));
Console.ReadLine();