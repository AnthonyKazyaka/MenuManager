namespace MenuPlanner.Common
{
    using System.Collections.Generic;

    public class Client : Person
    {
        public List<Person> AdditionalContacts { get; set; }

        public LocationInformation LocationInformation { get; set; }
    }
}
