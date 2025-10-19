// Models/Post.cs
namespace BlazorWasmDemo.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? Title { get; set; }
        public string? Body { get; set; }
    }
}
