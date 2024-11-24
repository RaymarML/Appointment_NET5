using AutoMapper;

namespace Appointment.Application.Common.Mappings
{
  public interface IMapFrom<T>
  {
    void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
  }
}