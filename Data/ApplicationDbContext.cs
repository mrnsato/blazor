using Microsoft.EntityFrameworkCore;
using ProdutosCrud.Models;

namespace ProdutosCrud.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Produto> Produtos { get; set; }
}