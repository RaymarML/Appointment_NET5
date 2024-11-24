using System.Collections.Generic;
using Appointment.Application.Common.Mappings;
using Appointment.Domain.Entities;

namespace Appointment.Application.Dtos
{
  public class ClientDto : IMapFrom<Client>
  {
    public ClientDto()
    {
      BookingDtos = new List<BookingDto>();
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public string Mobile { get; set; }
    public string Email { get; set; }
    public IList<BookingDto> BookingDtos { get; set; }
  }
}