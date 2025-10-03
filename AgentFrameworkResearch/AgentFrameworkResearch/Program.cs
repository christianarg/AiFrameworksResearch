using System.Threading.Tasks;
using GeminiDotnet;
using GeminiDotnet.Extensions.AI;
using Microsoft.Extensions.AI;
using Microsoft.Agents.AI;
using System.ComponentModel;

[Description("Get the current time")]
DateTimeOffset GetCurrentTime() => DateTimeOffset.UtcNow;

var options = new GeminiClientOptions { ApiKey = Environment.GetEnvironmentVariable("googleAiStudioApiKey")!, ModelId = "gemini-2.5-flash" };
IChatClient client = new GeminiChatClient(options);
var chatOptions = new ChatOptions { Tools = [AIFunctionFactory.Create(GetCurrentTime)] };
GeminiAIAgent agent = new GeminiAIAgent(client, chatOptions);
Console.WriteLine(await agent.RunAsync("What time is it?"));
Console.ReadLine();