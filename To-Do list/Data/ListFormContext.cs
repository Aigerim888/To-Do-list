using Microsoft.EntityFrameworkCore;
using To_Do_list.Models;

namespace To_Do_list.Data
{
    public class ListFormContext : DbContext
    {
        public ListFormContext(DbContextOptions<ListFormContext> options) : base(options)
        {

        }
        public DbSet<Issue> Issues {get;set;}      
        public DbSet<Priority> Priorities { get;set;}
        public DbSet<Status> Statuses { get;set;}
    }
}
