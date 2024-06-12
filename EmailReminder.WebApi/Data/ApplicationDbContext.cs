using EmailReminder.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace EmailReminder.WebApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Reminder> Reminders { get; set; }
    }
}
