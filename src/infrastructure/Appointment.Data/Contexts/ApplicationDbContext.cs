using Appointment.Application.Common.Interfaces;
using Appointment.Domain.Entities;
using System.Data;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Appointment.Data.Contexts
{
  public class ApplicationDbContext : DbContext, IApplicationDbContext
  {
    private readonly IDateTime _dateTime;
    private IDbContextTransaction _currentTransaction;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
    {
    }

    public ApplicationDbContext(
      DbContextOptions<ApplicationDbContext> options,
      IDateTime dateTime) : base(options)
    {
      _dateTime = dateTime;
    }

    public DbSet<Schedule> Schedules { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<ServiceRequest> ServiceRequests { get; set; }


    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
      return base.SaveChangesAsync(cancellationToken);
    }

    public async Task BeginTransactionAsync()
    {
      if (_currentTransaction != null)
      {
        return;
      }

      _currentTransaction = await base.Database.BeginTransactionAsync(IsolationLevel.ReadCommitted).ConfigureAwait(false);
    }

    public async Task CommitTransactionAsync()
    {
      try
      {
        await SaveChangesAsync().ConfigureAwait(false);

        _currentTransaction?.Commit();
      }
      catch
      {
        RollbackTransaction();
        throw;
      }
      finally
      {
        if (_currentTransaction != null)
        {
          _currentTransaction.Dispose();
          _currentTransaction = null;
        }
      }
    }

    public void RollbackTransaction()
    {
      try
      {
        _currentTransaction?.Rollback();
      }
      finally
      {
        if (_currentTransaction != null)
        {
          _currentTransaction.Dispose();
          _currentTransaction = null;
        }
      }
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

      base.OnModelCreating(builder);
    }
  }
}