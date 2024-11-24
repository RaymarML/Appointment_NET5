using Appointment.Application.Common.Mappings;
using Appointment.Domain.Entities;
using System.Collections.Generic;

namespace Appointment.Application.Dtos
{
  public class ServiceDto : IMapFrom<Service>
  {
    public ServiceDto()
    {
      ServiceRequestDtos = new List<ServiceRequestDto>();
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public int DurationInMinutes { get; set; }
    public float Price { get; set; }
    public IList<ServiceRequestDto> ServiceRequestDtos { get; set; }  
  }
}