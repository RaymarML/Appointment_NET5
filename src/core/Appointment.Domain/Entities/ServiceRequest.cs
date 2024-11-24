namespace Appointment.Domain.Entities
{
  public class ServiceRequest
  {
    public int Id { get; set; }
    public int ServiceId { get; set; }
    public int BookingId { get; set; }
    public float Price { get; set; }
    public bool Done { get; set; }
    public Service Service { get; set; }
    public Booking Booking { get; set; }
  }
}