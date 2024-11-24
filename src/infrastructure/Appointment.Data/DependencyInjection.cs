using Appointment.Data.Contexts;
using Appointment.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Appointment.Data
{
  public static class DependencyInjection
  {
    public static IServiceCollection AddInfrastructureData(this IServiceCollection services)
    {
      services.AddDbContext<ApplicationDbContext>(options
        => options.UseSqlite("DataSource=AppointmentDatabase.sqlite3")
      );
      services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());
      return services;
    }
  }
}