// Services/PostService.cs
using System.Net.Http.Json;
using BlazorWasmDemo.Models;

namespace BlazorWasmDemo.Services
{
    public class PostService
    {
        private readonly HttpClient _httpClient;

        public PostService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Post>> GetPostsAsync()
        {
            try
            {
                var posts = await _httpClient.GetFromJsonAsync<List<Post>>(
                    "https://jsonplaceholder.typicode.com/posts"
                );
                return posts ?? new List<Post>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching posts: {ex.Message}");
                return new List<Post>();
            }
        }
    }
}
