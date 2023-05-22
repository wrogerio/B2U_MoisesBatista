using System.ComponentModel.DataAnnotations;

namespace B2U.DAL.Domain;

public class Conta
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(8)]
    public string Codigo { get; set; }

    [Required]
    [MaxLength(128)]
    public string Nome { get; set; }
}