using System.Collections.Generic;
using Appointment.Application.Common.Mappings;
using Appointment.Domain.Entities;

namespace Appointment.Application.Dtos
{
  public class EmployeeDto : IMapFrom<Employee>
  {
    public EmployeeDto ()
    {
      AssignedBookingDtos = new List<BookingDto>();
      ScheduleDtos = new List<ScheduleDto>();
    }

    public int Id { get; set; }
    public int FirstName { get; set; }
    public int LastName { get; set; }
    public IList<BookingDto> AssignedBookingDtos { get; set; }
    public IList<ScheduleDto> ScheduleDtos { get; set; }
  }
}