using System.ComponentModel.DataAnnotations;

namespace ModelFilms.Entities;
public abstract class Personne
{
    public int Id { get; set; }

    [StringLength(80)]
    public string Name { get; set; } = null!;
}
