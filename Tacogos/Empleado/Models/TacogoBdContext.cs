using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Empleado.Models;

public partial class TacogoBdContext : DbContext
{
    public TacogoBdContext()
    {
    }

    public TacogoBdContext(DbContextOptions<TacogoBdContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<ElementoCartum> ElementoCarta { get; set; }

    public virtual DbSet<ElementoPedido> ElementoPedidos { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-70SOPIUJ\\SQLEXPRESS;Initial Catalog=TacogoBD;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente);

            entity.ToTable("Cliente");

            entity.Property(e => e.IdCliente).HasColumnName("idCliente");
            entity.Property(e => e.ClaveCliente)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("claveCliente");
            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("fechaCreacion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<ElementoCartum>(entity =>
        {
            entity.HasKey(e => e.IdElemento);

            entity.Property(e => e.IdElemento).HasColumnName("idElemento");
            entity.Property(e => e.Descripcion)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio");
        });

        modelBuilder.Entity<ElementoPedido>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ElementoPedido");

            entity.Property(e => e.IdElemento).HasColumnName("idElemento");
            entity.Property(e => e.IdPedido)
                .ValueGeneratedOnAdd()
                .HasColumnName("idPedido");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio");

            entity.HasOne(d => d.IdElementoNavigation).WithMany()
                .HasForeignKey(d => d.IdElemento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ElementoPedido_ElementoCarta");

            entity.HasOne(d => d.IdPedidoNavigation).WithMany()
                .HasForeignKey(d => d.IdPedido)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ElementoPedido_Pedido");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.IdEmpleado);

            entity.ToTable("Empleado");

            entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");
            entity.Property(e => e.ClaveEmpleado)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("claveEmpleado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Estado>(entity =>
        {
            entity.HasKey(e => e.IdEstado);

            entity.ToTable("Estado");

            entity.Property(e => e.IdEstado).HasColumnName("idEstado");
            entity.Property(e => e.Estado1)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("estado");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.IdPedido);

            entity.ToTable("Pedido");

            entity.Property(e => e.IdPedido).HasColumnName("idPedido");
            entity.Property(e => e.FechaPedido)
                .HasColumnType("datetime")
                .HasColumnName("fechaPedido");
            entity.Property(e => e.IdCliente).HasColumnName("idCliente");
            entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");
            entity.Property(e => e.IdEstado).HasColumnName("idEstado");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pedido_Cliente");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdEmpleado)
                .HasConstraintName("FK_Pedido_Empleado");

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdEstado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pedido_Estado");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
