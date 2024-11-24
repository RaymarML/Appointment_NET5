using System;
using Appointment.Application.Common.Mappings;
using Appointment.Domain.Entities;

namespace Appointment.Application.Dtos
{
  public class ScheduleDto : IMapFrom<Schedule>
  {
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public int BookingId { get; set; }
    public DateTime From { get; set; }
    public DateTime To { get; set; }  
  }
}