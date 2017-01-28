namespace MenuPlanner.Common
{
    using System.Collections.Generic;

    public class Recipe
    {
        public string Name { get; }

        public List<Ingredient> Ingredients { get; set; }

        public Dictionary<int, string> CookingInstructions { get; set; }

        public Dictionary<int, string> ReheatingInstructions { get; set; }
    }
}
