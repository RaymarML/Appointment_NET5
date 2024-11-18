using System;

namespace Appointment.Domain.Entities
{
  public class Schedule
  {
    public int Id { get; set; }
    public Employee Employee { get; set; }
    public DateTime From { get; set; }
    public DateTime To { get; set; }  
    public Booking Booking { get; set; }
  }
}