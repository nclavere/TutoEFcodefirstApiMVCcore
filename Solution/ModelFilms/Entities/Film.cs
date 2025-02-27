using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelFilms.Entities;
public class Film
{
    public int Id { get; set; }

    [StringLength(80)]
    public string Title { get; set; } = null!;

    [StringLength(400)]
    public string? resume { get; set; }

    [ForeignKey(nameof(Genre))]
    public int GenreId { get; set; }

    [DeleteBehavior(DeleteBehavior.Restrict)]
    public virtual Genre? Genre { get; set; }

    [ForeignKey(nameof(Realisateur))]
    public int RealisateurId { get; set; }

    [DeleteBehavior(DeleteBehavior.Restrict)]
    public virtual Realisateur? Realisateur { get; set; }

    [InverseProperty(nameof(Acteur.Films))]
    public List<Acteur>? Acteurs { get; set; }
}
