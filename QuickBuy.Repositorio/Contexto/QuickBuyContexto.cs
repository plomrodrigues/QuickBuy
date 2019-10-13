using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.ObjetoDeValor;
using QuickBuy.Repositorio.Config;

namespace QuickBuy.Repositorio.Contexto
{
    public class QuickBuyContexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItemPedido { get; set; }
        public DbSet<FormaPagamento> FormaPagamentos { get; set; }

        public QuickBuyContexto(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new PedidoMap());
            modelBuilder.ApplyConfiguration(new ItemPedidoMap());
            modelBuilder.ApplyConfiguration(new FormaPagamentoMap());

            modelBuilder.Entity<FormaPagamento>().HasData(new FormaPagamento(){ Id = 1, Nome = "Boleto", Descricao = "Forma de pagamento Boleto" });
            modelBuilder.Entity<FormaPagamento>().HasData(new FormaPagamento() { Id = 2, Nome = "Cartão de Crédito", Descricao = "Forma de pagamento cartão de crédito" });
            modelBuilder.Entity<FormaPagamento>().HasData(new FormaPagamento() { Id = 3, Nome = "Depósito", Descricao = "Forma de pagamento depósito" });

            base.OnModelCreating(modelBuilder);
        }
    }
}
