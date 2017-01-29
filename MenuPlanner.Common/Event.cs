namespace MenuPlanner.Common
{
    using System;
    using System.Collections.Generic;

    public class Event
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public EventType Type { get; set; }

        public Client Client { get; set; }

        public LocationInformation Location { get; set; }

        public Menu Menu { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
