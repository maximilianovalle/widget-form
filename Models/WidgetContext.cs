using Microsoft.EntityFrameworkCore;

namespace WidgetForm.Models {
    public class WidgetContext : DbContext {
        public WidgetContext(DbContextOptions<WidgetContext> options) : base(options) { }
        public DbSet<Widget> Widgets { get; set; } = null!;
    }
}