using B2U.DAL.Domain;
using Microsoft.EntityFrameworkCore;

namespace B2U.DAL.Context;

public class B2UContext : DbContext
{
	public B2UContext() { }

	public B2UContext(DbContextOptions<B2UContext> options) : base(options) { }

	public DbSet<Conta> Conta { get; set; }
	public DbSet<Categoria> Categoria { get; set; }
	public DbSet<Transacao> Transacao { get; set; }
}