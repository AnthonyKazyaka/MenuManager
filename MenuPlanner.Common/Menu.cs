﻿namespace MenuPlanner.Common
{
    using System.Collections.Generic;

    public class Menu
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Recipe> Recipes { get; set; }
    }
}
