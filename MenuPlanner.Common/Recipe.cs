namespace MenuPlanner.Common
{
    using System.Collections.Generic;

    public class Recipe
    {
        public string Name { get; set; }

        public RecipeSource Source { get; set; }

        public List<Ingredient> Ingredients { get; set; }

        public string CookingInstructions { get; set; }

        public string ReheatingInstructions { get; set; }
    }
}
