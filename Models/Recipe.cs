using System.ComponentModel;

namespace RecipeAPI.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Instructions { get; set; }
        public int CookingTimeInMinutes { get; set; }
        public ICollection<Ingredient>? Ingredients { get; set; }
        public ICollection<Category>? Categories { get; set; }
        public ICollection<Rating>? Ratings { get; set; }
        public ICollection<Review>? Reviews { get; set; }
    }
}
