using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Appointment.Application
{
  public static class DependencyInjection
  {
    public static IServiceCollection AddCoreApplication(this IServiceCollection services)
    {
      services.AddAutoMapper(Assembly.GetExecutingAssembly());
      return services;
    }
  }
}