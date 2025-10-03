using System.Text.Json;
using Microsoft.Agents.AI;
using Microsoft.Extensions.AI;

public class GeminiAIAgent(IChatClient chatClient) : AIAgent
{
    public override AgentThread DeserializeThread(JsonElement serializedThread, JsonSerializerOptions? jsonSerializerOptions = null)
    {
        throw new NotImplementedException();
    }

    public override AgentThread GetNewThread()
    {
        throw new NotImplementedException();
    }

    public override async Task<AgentRunResponse> RunAsync(IEnumerable<ChatMessage> messages, AgentThread? thread = null, AgentRunOptions? options = null, CancellationToken cancellationToken = default)
    {
        var response = await chatClient.GetResponseAsync(messages, cancellationToken: cancellationToken);
        return new AgentRunResponse(response);
    }

    public override IAsyncEnumerable<AgentRunResponseUpdate> RunStreamingAsync(IEnumerable<ChatMessage> messages, AgentThread? thread = null, AgentRunOptions? options = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}