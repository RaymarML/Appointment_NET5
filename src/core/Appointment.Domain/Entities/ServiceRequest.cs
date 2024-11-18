namespace Appointment.Domain.Entities
{
  public class ServiceRequest
  {
    public int Id { get; set; }
    public Service Service { get; set; }
    public Booking Booking { get; set; }
    public float Price { get; set; }
    public bool Done { get; set; }
  }
}