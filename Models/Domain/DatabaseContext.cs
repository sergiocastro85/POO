using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore.Models.Domain;
public class DatabaseContext : IdentityDbContext<AplitaionUser>
{

    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
        
    }

    //relacion de muchos a muchos
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<Libro>()
            .HasMany(x => x.CategoriaRelationList)
            .WithMany(y => y.LibroRelationList) 
            .UsingEntity<LibroCategoria>(
              j => j
                .HasOne(p=>p.categoria)
                .WithMany(p => p.LibroCategoriaRelationList)
                 .HasForeignKey(p => p.CategoriaId),
              j => j
                .HasOne(p => p.libro)
                .WithMany(y => y.LibroCategoriaRelationList)
                .HasForeignKey(p => p.LibroId),

                j => 
                {
                    j.HasKey (t => new {t.LibroId, t.CategoriaId});
                }


            ) ; 
    }

    public DbSet<Categoria> Categorias {get; set;}
    public DbSet<Libro> Libros {get; set;}

    public DbSet<LibroCategoria>? LibroCategorias;

}