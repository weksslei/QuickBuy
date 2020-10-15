using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Quick.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);
            builder
                .Property(p => p.DataPedido)
                .IsRequired();
            builder
                .Property(p => p.DataPrevisaoEntrega)
                .IsRequired();
            builder
                .Property(p => p.CEP)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(p => p.Estado)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(p => p.Cidade)
                .IsRequired()
                .HasMaxLength(100);
            builder
                .Property(p => p.EnderecoCompleto)
                .IsRequired()
                .HasMaxLength(200);
            builder
                .Property(p => p.NumeroEndereco)
                .IsRequired();
                


        }
    }
}
