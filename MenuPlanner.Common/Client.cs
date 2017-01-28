namespace MenuPlanner.Common
{
    using System.Collections.Generic;

    public class Client : Person
    {
        public List<Person> AdditionalContact { get; set; }
    }
}
