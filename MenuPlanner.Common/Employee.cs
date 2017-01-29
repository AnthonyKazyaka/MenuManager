namespace MenuPlanner.Common
{
    public class Employee : Person
    {
        public LocationInformation LocationInformation { get; set; }

        public string Title { get; set; }

        public JobType JobType { get; set; }
    }
}
