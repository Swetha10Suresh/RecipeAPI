namespace RecipeAPI.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string? Comment { get; set; }
        public int RecipeId { get; set; }
        public Recipe? Recipe { get; set; }
    }
}
