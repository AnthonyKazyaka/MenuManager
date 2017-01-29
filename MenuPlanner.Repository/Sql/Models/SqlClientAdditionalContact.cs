namespace MenuPlanner.Repository.Sql.Models
{
    public class SqlClientAdditionalContact
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string EmailAddress { get; set; }
    }
}
