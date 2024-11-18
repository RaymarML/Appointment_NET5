using System;
using System.Collections.Generic;

namespace Appointment.Domain.Entities
{
  public class Booking
  {
    public Booking()
    {
      ServiceRequests = new List<ServiceRequest>();
    }

    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    // public Employee Creator { get; set; }
    public Employee AssignedEmployee { get; set; }
    public Client Client { get; set; }
    public DateTime From { get; set; }
    public DateTime To { get; set; }
    public float ExpectedPrice { get; set; }
    public float FinalPrice { get; set; }
    public float Discount { get; set; }
    public bool Cancelled { get; set; }
    public string CancellationReason { get; set; }
    public IList<ServiceRequest> ServiceRequests { get; set; }
    // public Schedule Schedule { get; set; }
  }
}