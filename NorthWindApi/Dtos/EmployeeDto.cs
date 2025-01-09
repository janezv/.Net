﻿namespace NorthWindApi.Dtos
{
    public class EmployeeDto
    {
        public int EmployeeId { get; set; }

        public string LastName { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string? Title { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime? HireDate { get; set; }
    }
}
