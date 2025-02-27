using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelFilms.Entities;
public class Acteur : Personne
{
    [InverseProperty(nameof(Film.Acteurs))]
    public List<Film>? Films { get; set; }
}
