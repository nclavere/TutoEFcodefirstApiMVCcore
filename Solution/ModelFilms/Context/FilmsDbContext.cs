using Microsoft.EntityFrameworkCore;
using ModelFilms.Entities;

namespace ModelFilms.Context;
public class FilmsDbContext : DbContext
{
    public virtual DbSet<Genre> Genres { get; set; } = null!;
    public virtual DbSet<Film> Films { get; set; } = null!;
    public virtual DbSet<Personne> Personnes { get; set; } = null!;
    public virtual DbSet<Realisateur> Realisateurs { get; set; } = null!;
    public virtual DbSet<Acteur> Acteurs { get; set; } = null!;
    public FilmsDbContext(DbContextOptions<FilmsDbContext> options)
       : base(options)
    {
    }
}

