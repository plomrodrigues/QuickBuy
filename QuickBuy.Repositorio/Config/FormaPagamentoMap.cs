using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.ObjetoDeValor;

namespace QuickBuy.Repositorio.Config
{
    public class FormaPagamentoMap : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(f => f.Id);

            builder.Property(f => f.Nome).IsRequired().HasMaxLength(60);
            builder.Property(f => f.Descricao).IsRequired().HasMaxLength(60);
        }
    }
}
