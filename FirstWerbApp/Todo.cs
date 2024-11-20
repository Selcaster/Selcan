using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FirstWerbApp
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsDone { get; set; }
        public string Status
        {
            get
            {
                if (IsDone && DateTime.Now <= Deadline) return "bitib";
                if (!IsDone && DateTime.Now > Deadline) return "yerinə yetirilmədi";
                return "gözlənilir";
            }
        }
    }
    
    public class TodoContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-MM13K7H\\SQLEXPRESS;Database=TodoApp;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }

}
