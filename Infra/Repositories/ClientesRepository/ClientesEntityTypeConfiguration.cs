using Domain.Models.Cliente;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositories.ClientesRepository
{
    public class ClientesEntityTypeConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {

            builder.ToTable("Clientes");
            builder.HasKey(c => c.Codigo);
            builder.Property(c => c.Codigo).ValueGeneratedOnAdd();
            builder.Property(c => c.Nome).HasColumnName("Nome").IsRequired();
            builder.Property(c => c.Documento).HasColumnName("Documento").IsRequired();
            builder.Property(c => c.Telefone).HasColumnName("Telefone").IsRequired();
            builder.OwnsOne(c => c.Endereco, end =>
            {
                end.ToTable("Enderecos");

                end.HasIndex(e => e.Codigo);
                end.Property(e => e.Codigo).ValueGeneratedOnAdd();
                end.Property(e => e.Logradouro).HasColumnName("Logradouro").IsRequired();
                end.Property(e => e.Numero).HasColumnName("Numero").IsRequired();
                end.Property(e => e.Bairro).HasColumnName("Bairro").IsRequired();
                end.Property(e => e.Cidade).HasColumnName("Cidade").IsRequired();
                end.Property(e => e.Uf).HasColumnName("Uf").IsRequired();

                end.HasForeignKey("CodigoCliente");
            });
        }
    }
}
