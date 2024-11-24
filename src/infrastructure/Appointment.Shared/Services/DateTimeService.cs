using System;
using Appointment.Application.Common.Interfaces;

namespace Appointment.Shared.Services
{
  public class DateTimeService : IDateTime
  {
    public DateTime NowUtc => DateTime.UtcNow;
  }
}