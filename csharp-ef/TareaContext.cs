using csharpef.Models;
using Microsoft.EntityFrameworkCore;

namespace csharpef;

public class TareasContext : DbContext
{
    public TareasContext(DbContextOptions<TareasContext> options) : base(options) { }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Tarea> Tareas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        List<Categoria> categoriasInit = new List<Categoria>();
        categoriasInit.Add(new Categoria()
        {
            CategoriaId = Guid.Parse("97228498-368d-424c-810a-4f9b60bf81f0"),
            Nombre = "Actividades pendientes",
            Peso = 20
        });
        categoriasInit.Add(new Categoria()
        {
            CategoriaId = Guid.Parse("97228498-368d-424c-810a-4f9b60bf8102"),
            Nombre = "Actividades personales",
            Peso = 50
        });

        modelBuilder.Entity<Categoria>(categoria =>
        {
            categoria.ToTable("Categoria");
            categoria.HasKey(p => p.CategoriaId);

            categoria.Property(p => p.Nombre).IsRequired().HasMaxLength(150);

            categoria.Property(p => p.Descripcion).IsRequired(false);

            categoria.Property(p => p.Peso);

            categoria.HasData(categoriasInit);
        });

        var tareasInit = new List<Tarea>();
        tareasInit.Add(new Tarea()
        {
            TareaId = Guid.Parse("97228498-368d-424c-810a-4f9b60bf8110"),
            CategoriaId = Guid.Parse("97228498-368d-424c-810a-4f9b60bf81f0"),
            PrioridadTarea = Prioridad.Media,
            Titulo = "Pago de servicios públicos",
            FechaCreacion = DateTime.Now

        });

        modelBuilder.Entity<Tarea>(tarea =>
        {
            tarea.ToTable("Tarea");
            tarea.HasKey(p => p.TareaId);

            tarea.HasOne(p => p.Categoria).WithMany(p => p.Tareas).HasForeignKey(p => p.CategoriaId);

            tarea.Property(p => p.Titulo).IsRequired().HasMaxLength(200);

            tarea.Property(p => p.Descripcion).IsRequired(false);
            tarea.Property(p => p.PrioridadTarea);
            tarea.Property(p => p.FechaCreacion);

            tarea.Ignore(p => p.Resumen);

            tarea.HasData(tareasInit);

        });
    }

}