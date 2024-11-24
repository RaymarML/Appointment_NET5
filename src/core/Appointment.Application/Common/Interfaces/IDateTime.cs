using System;

namespace Appointment.Application.Common.Interfaces
{
  public interface IDateTime
  {
    DateTime NowUtc { get; }
  }
}