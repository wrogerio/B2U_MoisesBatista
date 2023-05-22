using B2U.DAL.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace B2U.WebUI.Models
{
    public class TransacaoViewModel
    {
        public Guid Id { get; set; }
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
        public string CorTransacao { get; set; }

        public Guid CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        [Required]
        public Guid ContaId { get; set; }
        public virtual Conta Conta { get; set; }
    }
}
