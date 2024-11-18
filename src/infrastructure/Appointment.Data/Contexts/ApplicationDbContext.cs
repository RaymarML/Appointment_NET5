using Microsoft.EntityFrameworkCore;
using Appointment.Domain.Entities;

namespace Appointment.Data.Contexts
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext
        (DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Schedule> Schedules { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<ServiceRequest> ServiceRequests { get; set; }
  }
}