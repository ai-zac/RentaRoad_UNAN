using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RentaRoad_Semestre3.CapaPresentacion.Modelos;

public partial class RentaRoadDbContext : DbContext
{
    public RentaRoadDbContext()
    {
    }

    public RentaRoadDbContext(DbContextOptions<RentaRoadDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Adquisicion> Adquisicions { get; set; }

    public virtual DbSet<Auto> Autos { get; set; }

    public virtual DbSet<CargoEmpleado> CargoEmpleados { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Color> Colors { get; set; }

    public virtual DbSet<Contrato> Contratos { get; set; }

    public virtual DbSet<DetalleAdquisicion> DetalleAdquisicions { get; set; }

    public virtual DbSet<EntregaAuto> EntregaAutos { get; set; }

    public virtual DbSet<Marca> Marcas { get; set; }

    public virtual DbSet<Modelo> Modelos { get; set; }

    public virtual DbSet<MultaContrato> MultaContratos { get; set; }

    public virtual DbSet<Proveedor> Proveedors { get; set; }

    public virtual DbSet<RegistrosCaja> RegistrosCajas { get; set; }

    public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=RentaRoad_DBOLD;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Adquisicion>(entity =>
        {
            entity.HasKey(e => new { e.IdAdquisicion, e.FkProveedor }).HasName("PK8");

            entity.ToTable("Adquisicion");

            entity.HasIndex(e => e.FkProveedor, "Ref926");

            entity.Property(e => e.IdAdquisicion)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_Adquisicion");
            entity.Property(e => e.FkProveedor).HasColumnName("Fk_Proveedor");
            entity.Property(e => e.FechaAdquisicion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_adquisicion");
            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Creacion");
            entity.Property(e => e.FechaModificacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Modificacion");
            entity.Property(e => e.PrecioTotal)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("precio_total");

            entity.HasOne(d => d.FkProveedorNavigation).WithMany(p => p.Adquisicions)
                .HasForeignKey(d => d.FkProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefProveedor26");
        });

        modelBuilder.Entity<Auto>(entity =>
        {
            entity.HasKey(e => new { e.IdAuto, e.FkDetalleAdquisicion, e.FkMarca, e.FkModelo, e.FkColor }).HasName("PK10");

            entity.ToTable("Auto");

            entity.HasIndex(e => new { e.FkMarca, e.FkColor, e.FkModelo, e.FkDetalleAdquisicion }, "Ref2475");

            entity.Property(e => e.IdAuto)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_Auto");
            entity.Property(e => e.FkDetalleAdquisicion).HasColumnName("Fk_Detalle_Adquisicion");
            entity.Property(e => e.FkMarca).HasColumnName("Fk_Marca");
            entity.Property(e => e.FkModelo).HasColumnName("Fk_Modelo");
            entity.Property(e => e.FkColor).HasColumnName("Fk_Color");
            entity.Property(e => e.AñoSalida).HasColumnName("año_salida");
            entity.Property(e => e.CostoRenta)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("costo_renta");
            entity.Property(e => e.Disponibilidad)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("disponibilidad");
            entity.Property(e => e.Estado)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EstadoAuto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado_auto");
            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_creacion");
            entity.Property(e => e.FechaModficacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Modficacion");
            entity.Property(e => e.NumeroAsientos).HasColumnName("numero_asientos");
            entity.Property(e => e.Placa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("placa");
            entity.Property(e => e.VerificacionPendiente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("verificacion_pendiente");
        });

        modelBuilder.Entity<CargoEmpleado>(entity =>
        {
            entity.HasKey(e => e.IdCargoEmpleado).HasName("PK14");

            entity.ToTable("Cargo_Empleado");

            entity.Property(e => e.IdCargoEmpleado).HasColumnName("Id_Cargo_empleado");
            entity.Property(e => e.Cargo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cargo");
            entity.Property(e => e.Estado)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Creacion");
            entity.Property(e => e.FechaModificacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Modificacion");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.CedulaCliente).HasName("PK3");

            entity.ToTable("Cliente");

            entity.Property(e => e.CedulaCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cedula_cliente");
            entity.Property(e => e.CodigoLicencia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codigo_licencia");
            entity.Property(e => e.DireccionCliente)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("direccion_cliente");
            entity.Property(e => e.Estado)
                .HasColumnType("datetime")
                .HasColumnName("estado");
            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_creacion");
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_cliente");
            entity.Property(e => e.TelefonoCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("telefono_cliente");
        });

        modelBuilder.Entity<Color>(entity =>
        {
            entity.HasKey(e => e.IdColor).HasName("PK20_1_1");

            entity.ToTable("Color");

            entity.Property(e => e.IdColor).HasColumnName("Id_Color");
            entity.Property(e => e.Color1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Color");
            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Creacion");
            entity.Property(e => e.FechaModificado)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Modificado");
        });

        modelBuilder.Entity<Contrato>(entity =>
        {
            entity.HasKey(e => new { e.IdContrato, e.FkCedulaCliente, e.FkAuto, e.IdUsuario }).HasName("PK4");

            entity.ToTable("Contrato");

            entity.HasIndex(e => e.FkAuto, "Ref1023");

            entity.HasIndex(e => e.IdUsuario, "Ref159");

            entity.HasIndex(e => e.FkCedulaCliente, "Ref362");

            entity.Property(e => e.IdContrato)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_Contrato");
            entity.Property(e => e.FkCedulaCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Fk_Cedula_Cliente");
            entity.Property(e => e.FkAuto).HasColumnName("Fk_Auto");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.EstadoContrato)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Estado_Contrato");
            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_creacion");
            entity.Property(e => e.FechaModificacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Modificacion");
            entity.Property(e => e.MontoGarantiaContrato)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("Monto_Garantia_Contrato");
            entity.Property(e => e.MontoTotal)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("monto_total");
            entity.Property(e => e.PlazoAlquiler).HasColumnName("plazo_alquiler");
            entity.Property(e => e.PorcentajeDescuento)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("porcentaje_descuento");
            entity.Property(e => e.RutaFirma)
                .HasMaxLength(100)
                .HasColumnName("ruta_firma");
            entity.Property(e => e.TipoPago)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("tipo_pago");

            entity.HasOne(d => d.FkCedulaClienteNavigation).WithMany(p => p.Contratos)
                .HasForeignKey(d => d.FkCedulaCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefCliente62");
        });

        modelBuilder.Entity<DetalleAdquisicion>(entity =>
        {
            entity.HasKey(e => new { e.IdDetalleAdquisicion, e.FkAdquisicion, e.FkMarca, e.FkModelo, e.FkColor }).HasName("PK24");

            entity.ToTable("Detalle_Adquisicion");

            entity.HasIndex(e => e.FkMarca, "Ref2070");

            entity.HasIndex(e => e.FkModelo, "Ref2171");

            entity.HasIndex(e => e.FkColor, "Ref2274");

            entity.HasIndex(e => e.FkAdquisicion, "Ref872");

            entity.Property(e => e.IdDetalleAdquisicion)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_Detalle_Adquisicion");
            entity.Property(e => e.FkAdquisicion).HasColumnName("Fk_Adquisicion");
            entity.Property(e => e.FkMarca).HasColumnName("Fk_Marca");
            entity.Property(e => e.FkModelo).HasColumnName("Fk_Modelo");
            entity.Property(e => e.FkColor).HasColumnName("Fk_Color");
            entity.Property(e => e.CantidadAuto).HasColumnName("Cantidad_Auto");
            entity.Property(e => e.PrecioGrupalAuto)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Precio_Grupal_Auto");
            entity.Property(e => e.PrecioUnidadAuto)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Precio_Unidad_Auto");

            entity.HasOne(d => d.FkColorNavigation).WithMany(p => p.DetalleAdquisicions)
                .HasForeignKey(d => d.FkColor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefColor74");

            entity.HasOne(d => d.FkMarcaNavigation).WithMany(p => p.DetalleAdquisicions)
                .HasForeignKey(d => d.FkMarca)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefMarca70");

            entity.HasOne(d => d.FkModeloNavigation).WithMany(p => p.DetalleAdquisicions)
                .HasForeignKey(d => d.FkModelo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefModelo71");
        });

        modelBuilder.Entity<EntregaAuto>(entity =>
        {
            entity.HasKey(e => new { e.IdEntregaAuto, e.FkAuto }).HasName("PK26");

            entity.ToTable("Entrega_Auto");

            entity.HasIndex(e => e.FkAuto, "Ref1079");

            entity.Property(e => e.IdEntregaAuto)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_Entrega_Auto");
            entity.Property(e => e.FkAuto).HasColumnName("Fk_Auto");
            entity.Property(e => e.CostoMantenimiento)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Costo_Mantenimiento");
            entity.Property(e => e.EstadoAuto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Estado_Auto");
            entity.Property(e => e.FechaEntrega)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Entrega");
            entity.Property(e => e.MotivoEntrega)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Motivo_Entrega");
        });

        modelBuilder.Entity<Marca>(entity =>
        {
            entity.HasKey(e => e.IdMarca).HasName("PK20");

            entity.ToTable("Marca");

            entity.Property(e => e.IdMarca).HasColumnName("Id_Marca");
            entity.Property(e => e.Estado)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Creacion");
            entity.Property(e => e.FechaModificacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Modificacion");
            entity.Property(e => e.Marca1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("marca");
        });

        modelBuilder.Entity<Modelo>(entity =>
        {
            entity.HasKey(e => e.IdModelo).HasName("PK20_1");

            entity.ToTable("Modelo");

            entity.Property(e => e.IdModelo).HasColumnName("Id_Modelo");
            entity.Property(e => e.Estado)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Creacion");
            entity.Property(e => e.FechaModificacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Modificacion");
            entity.Property(e => e.Modelo1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("modelo");
        });

        modelBuilder.Entity<MultaContrato>(entity =>
        {
            entity.HasKey(e => new { e.IdMultaContrato, e.FkContrato, e.IdUsuario }).HasName("PK25");

            entity.ToTable("Multa_Contrato");

            entity.HasIndex(e => new { e.IdUsuario, e.FkContrato }, "Ref477");

            entity.Property(e => e.IdMultaContrato)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_Multa_Contrato");
            entity.Property(e => e.FkContrato).HasColumnName("Fk_Contrato");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.CantidadDiasDemora).HasColumnName("Cantidad_Dias_Demora");
            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Creacion");
            entity.Property(e => e.FechaModificacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Modificacion");
            entity.Property(e => e.MontoMora)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("Monto_Mora");
            entity.Property(e => e.MotivoMulta)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Motivo_Multa");
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.HasKey(e => e.IdProveedor).HasName("PK9");

            entity.ToTable("Proveedor");

            entity.Property(e => e.IdProveedor).HasColumnName("Id_Proveedor");
            entity.Property(e => e.CorreoProveedor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("correo_Proveedor");
            entity.Property(e => e.Estado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_creacion");
            entity.Property(e => e.FechaModificacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Modificacion");
            entity.Property(e => e.NombreProveedor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre_Proveedor");
            entity.Property(e => e.TelefonoProveedor)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("telefono_Proveedor");
        });

        modelBuilder.Entity<RegistrosCaja>(entity =>
        {
            entity.HasKey(e => new { e.IdRegistroCaja, e.IdUsuario }).HasName("PK27");

            entity.ToTable("Registros_Caja");

            entity.HasIndex(e => e.IdUsuario, "Ref180");

            entity.Property(e => e.IdRegistroCaja)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_Registro_Caja");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.DesgloseTotalCordobas)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("Desglose_Total_Cordobas");
            entity.Property(e => e.DesgloseTotalDolares)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("Desglose_Total_Dolares");
            entity.Property(e => e.EgresoTotalCordobas)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("Egreso_Total_Cordobas");
            entity.Property(e => e.EgresoTotalDolares)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("Egreso_Total_Dolares");
            entity.Property(e => e.FechaRegistroCaja)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro_Caja");
            entity.Property(e => e.MontoEgresado)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("Monto_Egresado");
            entity.Property(e => e.MontoFacturado)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("Monto_Facturado");
            entity.Property(e => e.MontoInicial)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("Monto_Inicial");
        });

        modelBuilder.Entity<TipoUsuario>(entity =>
        {
            entity.HasKey(e => e.IdTipoUsuario).HasName("PK13");

            entity.ToTable("Tipo_Usuario");

            entity.Property(e => e.IdTipoUsuario).HasColumnName("Id_Tipo_usuario");
            entity.Property(e => e.Estado)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Creacion");
            entity.Property(e => e.FechaModificacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Modificacion");
            entity.Property(e => e.Tipo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => new { e.FkTipoUsuario, e.IdUsuario, e.FkCargoEmpleado }).HasName("PK1");

            entity.ToTable("Usuario");

            entity.HasIndex(e => e.FkTipoUsuario, "Ref1350");

            entity.HasIndex(e => e.FkCargoEmpleado, "Ref1460");

            entity.Property(e => e.FkTipoUsuario).HasColumnName("Fk_Tipo_usuario");
            entity.Property(e => e.IdUsuario)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_Usuario");
            entity.Property(e => e.FkCargoEmpleado).HasColumnName("Fk_Cargo_empleado");
            entity.Property(e => e.CedulaUsuario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Cedula_Usuario");
            entity.Property(e => e.Contraseña)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("contraseña");
            entity.Property(e => e.Correo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.Estado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Creacion");
            entity.Property(e => e.FechaModificacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Modificacion");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_usuario");
            entity.Property(e => e.TelefonoUsuario).HasColumnName("Telefono_Usuario");

            entity.HasOne(d => d.FkCargoEmpleadoNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.FkCargoEmpleado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefCargo_Empleado60");

            entity.HasOne(d => d.FkTipoUsuarioNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.FkTipoUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefTipo_Usuario50");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
