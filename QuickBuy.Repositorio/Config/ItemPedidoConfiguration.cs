using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Quick.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasKey(i => i.Id);
            builder.
                Property(i => i.ProdutoId)
                .IsRequired();
            builder.
                Property(i => i.Quantidade)
                .IsRequired();


        }
                
        
    }
}
