namespace MenuPlanner.Repository.Sql.Models
{
    using System;

    public class SqlEvent
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int EventTypeId { get; set; }

        public int ClientId { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public int MenuId { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }
    }
}
