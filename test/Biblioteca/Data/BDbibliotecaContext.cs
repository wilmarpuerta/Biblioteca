using Microsoft.EntityFrameworkCore;
using Biblioteca.Models;
namespace Biblioteca.Data;

public class BDbibliotecaContext : DbContext
{
    public BDbibliotecaContext(DbContextOptions<BDbibliotecaContext> options) : base(options)
    {
    }
    
    public DbSet<Libro> Libros { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
}