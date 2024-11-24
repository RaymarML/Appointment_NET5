using System;

namespace Appointment.Domain.Entities
{
  public class Schedule
  {
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public int BookingId { get; set; }
    public DateTime From { get; set; }
    public DateTime To { get; set; }  
    public Employee Employee { get; set; }
    public Booking Booking { get; set; }
  }
}