using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Appointment.Application.Common.Interfaces;
using Appointment.Shared.Services;

namespace Appointment.Shared
{
  public static class DependencyInjection
  {
    public static IServiceCollection AddInfrastructureShared(this IServiceCollection services, IConfiguration config)
    {
      services.AddTransient<IDateTime, DateTimeService>();
      return services;
    }
  }
}