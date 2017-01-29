namespace MenuPlanner.Repository.Sql.Models
{
    public class SqlRecipe
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string SourceName { get; set; }

        public string SourceDescription { get; set; }

        public int SourceTypeId { get; set; }

        public string SourceWebsite { get; set; }

        public string CookingInstructions { get; set; }

        public string ReheatingInstructions { get; set; }
    }
}
