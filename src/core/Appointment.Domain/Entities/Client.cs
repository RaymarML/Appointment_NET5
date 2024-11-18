using System.Collections.Generic;

namespace Appointment.Domain.Entities
{
  public class Client
  {
    public Client()
    {
      Bookings = new List<Booking>();
    }

    public int Id { get; set; }
    public IList<Booking> Bookings { get; set; }
    public string Name { get; set; }
    public string Mobile { get; set; }
    public string Email { get; set; }
  }
}