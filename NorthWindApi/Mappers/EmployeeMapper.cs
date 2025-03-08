using NorthWindApi.Dtos;
using NorthWindApi.Models;

namespace NorthWindApi.Mappers
{
    public static class EmployeeMapper
    {
        public static EmployeeDto EmployeeDto(Employee employee)
        {
            return new EmployeeDto
            {
                EmployeeId = employee.EmployeeId,
                LastName = employee.LastName,
                FirstName = employee.FirstName,
                Title = employee.Title,
                BirthDate = employee.BirthDate,
                HireDate = employee.HireDate
            };
        }
    }
}
