using csharpef.Models;
using Microsoft.EntityFrameworkCore;

namespace csharpef;

public class TareasContext : DbContext
{
    public TareasContext(DbContextOptions<TareasContext> options) : base(options) { }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Tarea> Tareas { get; set; }

}