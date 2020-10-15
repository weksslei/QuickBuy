
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Quick.Dominio.Entidades;
using Quick.Dominio.ObjetoDe;

namespace QuickBuy.Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            //builder.HasKey
            builder.HasKey(f => f.Id);

            builder.Property(f => f.Nome)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(f => f.Descricao)
                .IsRequired()
                .HasMaxLength(100);

        }
    }
}