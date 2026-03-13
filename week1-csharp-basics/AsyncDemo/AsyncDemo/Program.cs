using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
    static readonly HttpClient _client = new HttpClient();

    static async Task Main()
    {
        //await WriteFileAsync("hello.txt", "안녕하세요, 비동기!");
        //string content = await ReadFileAsync("hello.txt");
        //Console.WriteLine("읽은 내용: "+content);

        //string result = await FetchAsync("https://jsonplaceholder.typicode.com/posts/1");
        //Console.WriteLine(result);

        Task<string> user = GetUserAsync();
        Task<string> order = GetOrderAsync();

        string[] results = await Task.WhenAll(user, order);

        Console.WriteLine(results[0]); 
        Console.WriteLine(results[1]);
    }

    static async Task WriteFileAsync(string path, string content)
    {
        await File.WriteAllTextAsync(path, content);
    }

    static async Task<string> ReadFileAsync(string path)
    {
        return await File.ReadAllTextAsync(path);
    }

    static async Task<string> FetchAsync(string url)
    {
        HttpResponseMessage response = await _client.GetAsync(url);
        return await response.Content.ReadAsStringAsync();
    }

    static async Task<string> GetUserAsync()
    {
        await Task.Delay(2000);
        return "유저: 홍길동";
    }

    static async Task<string> GetOrderAsync()
    {
        await Task.Delay(2000);
        return "주문: 아메리카노";
    }
}