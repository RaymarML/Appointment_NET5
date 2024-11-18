using System.Collections.Generic;

namespace Appointment.Domain.Entities
{
  public class Employee
  {
    public Employee ()
    {
      // CreatedBookings = new List<Booking>();
      AssignedBookings = new List<Booking>();
      Schedules = new List<Schedule>();
    }

    public int Id { get; set; }
    public int FirstName { get; set; }
    public int LastName { get; set; }
    // public IList<Booking> CreatedBookings { get; set; }
    public IList<Booking> AssignedBookings { get; set; }
    public IList<Schedule> Schedules { get; set; }
  }
}