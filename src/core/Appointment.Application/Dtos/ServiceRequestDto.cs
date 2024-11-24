using Appointment.Application.Common.Mappings;

namespace Appointment.Application.Dtos
{
  public class ServiceRequestDto : IMapFrom<ServiceRequestDto>
  {
    public int Id { get; set; }
    public int ServiceId { get; set; }
    public int BookingId { get; set; }
    public float Price { get; set; }
    public bool Done { get; set; }
  }
}