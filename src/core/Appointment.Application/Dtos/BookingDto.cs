using System;
using System.Collections.Generic;
using Appointment.Application.Dtos;

namespace Appointment.Domain.Entities
{
  public class BookingDto
  {
    public BookingDto()
    {
      ServiceRequestDtos = new List<ServiceRequestDto>();
    }

    public int Id { get; set; }
    public int AssignedEmployeeId { get; set; }
    public int ClientId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime From { get; set; }
    public DateTime To { get; set; }
    public float ExpectedPrice { get; set; }
    public float FinalPrice { get; set; }
    public float Discount { get; set; }
    public bool Cancelled { get; set; }
    public string CancellationReason { get; set; }
    public IList<ServiceRequestDto> ServiceRequestDtos { get; set; }
  }
}