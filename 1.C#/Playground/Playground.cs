using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Program
{
    private static readonly HttpClient client = new HttpClient();

    static async Task Main(string[] args)
    {
        // API endpoint URL
        string apiUrl = "http://127.0.0.1:5000/hf_models";

        // Request payload
        var requestData = new
        {
            Provider = "sambanova",
            HFToken = "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",
            ModelName = "Qwen/Qwen2.5-Coder-32B-Instruct",
            Content = "You are an intelligent code assistant.  Your task is to autocomplete code snippets. Return only the remaining part of the code needed to complete the input, without explanations, comments, or any extra text. Do not repeat the input or add unnecessary details. Strictly provide the continuation. The uncompleted code is \\nprint('hello, \\n\"",
            Role = "user",
            MaxTokens = 10
        };

        // Serialize the request data to JSON
        string jsonRequest = JsonConvert.SerializeObject(requestData);
        var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

        // Send the POST request
        HttpResponseMessage response = await client.PostAsync(apiUrl, content);

        // Check if the request was successful
        if (response.IsSuccessStatusCode)
        {
            // Read the response content
            string jsonResponse = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Response from API:");
            Console.WriteLine(jsonResponse);
        }
        else
        {
            Console.WriteLine($"Error: {response.StatusCode}");
            string errorResponse = await response.Content.ReadAsStringAsync();
            Console.WriteLine(errorResponse);
        }
    }
}