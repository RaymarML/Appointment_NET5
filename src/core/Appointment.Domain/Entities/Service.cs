using System.Collections.Generic;

namespace Appointment.Domain.Entities
{
  public class Service
  {
    public Service()
    {
      ServiceRequests = new List<ServiceRequest>();
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public int DurationInMinutes { get; set; }
    public float Price { get; set; }
    public IList<ServiceRequest> ServiceRequests { get; set; }
      
  }
}