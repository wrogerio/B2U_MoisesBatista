using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace B2U.DAL.Domain;

public class Transacao
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(128)]
    public string Historico { get; set; }

    [Required]
    public DateTime Data { get; set; }

    [Required]
    public decimal Debito { get; set; }

    [Required]
    public decimal Credito { get; set; }

    [Required]
    public bool Conciliado { get; set; }

    [Required]
    public string Notas { get; set; }

    // Relacionamentos
    [Required]
    public Guid CategoriaId { get; set; }
    [ForeignKey("CategoriaId")]
    public virtual Categoria Categoria { get; set; }

    [Required]
    public Guid ContaId { get; set; }
    [ForeignKey("ContaId")]
    public virtual Conta Conta { get; set; }
}