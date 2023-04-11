using Microsoft.EntityFrameworkCore;
using ToDoList_11._04._2023.Models;

namespace ToDoList_11._04._2023.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<ToDo> ToDo { get; set; }
    }
}
