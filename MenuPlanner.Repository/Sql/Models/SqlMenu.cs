namespace MenuPlanner.Repository.Sql.Models
{
    using System.Collections.Generic;

    public class SqlMenu
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<int> Recipes { get; set; }
    }
}
