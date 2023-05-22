using System.ComponentModel.DataAnnotations;

namespace B2U.DAL.Domain;

public class Categoria
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(128)]
    public string Nome { get; set; }

    [Required]
    public int Tipo { get; set; }
}