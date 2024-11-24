using Appointment.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Appointment.Application.Common.Interfaces
{
  public interface IApplicationDbContext
  {
    DbSet<Schedule> Schedules { get; set; }
    DbSet<Employee> Employees { get; set; }
    DbSet<Client> Clients { get; set; }
    DbSet<Booking> Bookings { get; set; }
    DbSet<Service> Services { get; set; }
    DbSet<ServiceRequest> ServiceRequests { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
  }
}