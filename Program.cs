using Azure;
using Azure.AI.OpenAI;
using Azure.Identity;
using Microsoft.Extensions.AI;

var endpoint = new Uri("https://cocoe-m2ae1t7j-swedencentral.openai.azure.com/");
var credentials = new AzureKeyCredential("");
var deploymentName = "gpt-4o";

IChatClient client = new AzureOpenAIClient(endpoint, credentials).AsChatClient(deploymentName);

var response = await client.CompleteAsync("What is AI?");

Console.WriteLine(response.Message);

