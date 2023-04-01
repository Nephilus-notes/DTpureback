using Microsoft.EntityFrameworkCore;

    namespace DTpureback.Models
{
    public class ToDoContext: DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) 
            : base(options) 
        {
        }
        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}
