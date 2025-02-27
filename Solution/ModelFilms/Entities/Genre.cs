using System.ComponentModel.DataAnnotations;

namespace ModelFilms.Entities;
public class Genre
{
    public int Id { get; set; }

    [StringLength(80)]
    public string Label { get; set; } = null!;
}
