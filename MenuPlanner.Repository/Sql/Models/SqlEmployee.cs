﻿namespace MenuPlanner.Repository.Sql.Models
{
    public class SqlEmployee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string EmailAddress { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public string Title { get; set; }

        public int JobTypeId { get; set; }
    }
}
