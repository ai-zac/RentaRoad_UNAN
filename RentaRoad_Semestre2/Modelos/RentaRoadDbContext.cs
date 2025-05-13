using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RentaRoad_Semestre3.Modelos;

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

    public virtual DbSet<Egreso> Egresos { get; set; }

    public virtual DbSet<EntregaAuto> EntregaAutos { get; set; }

    public virtual DbSet<Marca> Marcas { get; set; }

    public virtual DbSet<Modelo> Modelos { get; set; }

    public virtual DbSet<MultaContrato> MultaContratos { get; set; }

    public virtual DbSet<Proveedor> Proveedors { get; set; }

    public virtual DbSet<RegistrosAperturasCaja> RegistrosAperturasCajas { get; set; }

    public virtual DbSet<RegistrosArqueosCaja> RegistrosArqueosCajas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ANDERSON\\MSSQLSERVER01;Database=RentaRoad_DB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Modern_Spanish_CI_AS");

        modelBuilder.Entity<Adquisicion>(entity =>
        {
            entity.HasKey(e => e.IdAdquisicion).HasName("PK8");

            entity.ToTable("Adquisicion");

            entity.Property(e => e.IdAdquisicion).HasColumnName("Id_Adquisicion");
            entity.Property(e => e.FechaAdquisicion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Adquisicion");
            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Creacion");
            entity.Property(e => e.FechaModificacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Modificacion");
            entity.Property(e => e.PrecioTotalAdquisicion)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Precio_Total_Adquisicion");
            entity.Property(e => e.RucProveedor)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RUC_Proveedor");

            entity.HasOne(d => d.RucProveedorNavigation).WithMany(p => p.Adquisicions)
                .HasForeignKey(d => d.RucProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefProveedor84");
        });

        modelBuilder.Entity<Auto>(entity =>
        {
            entity.HasKey(e => e.IdAuto).HasName("PK10");

            entity.ToTable("Auto");

            entity.HasIndex(e => e.FkDetalleAdquisicion, "Ref2475");

            entity.Property(e => e.IdAuto).HasColumnName("Id_Auto");
            entity.Property(e => e.AñoSalidaAuto).HasColumnName("Año_Salida_Auto");
            entity.Property(e => e.CantidadAsientosAuto).HasColumnName("Cantidad_Asientos_Auto");
            entity.Property(e => e.CostoRentaAuto)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Costo_Renta_Auto");
            entity.Property(e => e.EstaDisponibleAuto).HasColumnName("estaDisponible_Auto");
            entity.Property(e => e.EstaHabilitado).HasColumnName("estaHabilitado");
            entity.Property(e => e.EstaVerificadaPlacaAuto).HasColumnName("estaVerificada_Placa_Auto");
            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Creacion");
            entity.Property(e => e.FechaModficacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Modficacion");
            entity.Property(e => e.FkAdquisicion).HasColumnName("Fk_Adquisicion");
            entity.Property(e => e.FkColor).HasColumnName("Fk_Color");
            entity.Property(e => e.FkDetalleAdquisicion).HasColumnName("Fk_Detalle_Adquisicion");
            entity.Property(e => e.FkMarca).HasColumnName("Fk_Marca");
            entity.Property(e => e.FkModelo).HasColumnName("Fk_Modelo");
            entity.Property(e => e.ImagenAuto)
                .HasMaxLength(100)
                .HasColumnName("Imagen_Auto");
            entity.Property(e => e.NecesitaMantenimiento).HasColumnName("necesitaMantenimiento");
            entity.Property(e => e.PlacaAuto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Placa_Auto");

            entity.HasOne(d => d.DetalleAdquisicion).WithMany(p => p.Autos)
                .HasForeignKey(d => new { d.FkDetalleAdquisicion, d.FkAdquisicion, d.FkMarca, d.FkModelo, d.FkColor })
                .HasConstraintName("RefDetalle_Adquisicion75");
        });

        modelBuilder.Entity<CargoEmpleado>(entity =>
        {
            entity.HasKey(e => e.IdCargoEmpleado).HasName("PK14");

            entity.ToTable("Cargo_Empleado");

            entity.Property(e => e.IdCargoEmpleado).HasColumnName("Id_Cargo_empleado");
            entity.Property(e => e.EstaHabilitado).HasColumnName("estaHabilitado");
            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Creacion");
            entity.Property(e => e.FechaModificacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Modificacion");
            entity.Property(e => e.NombreCargo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Cargo");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.CedulaCliente).HasName("PK3");

            entity.ToTable("Cliente");

            entity.Property(e => e.CedulaCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cedula_Cliente");
            entity.Property(e => e.CodigoLicenciaConducir)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Codigo_Licencia_Conducir");
            entity.Property(e => e.DireccionViviendaCliente)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Direccion_Vivienda_Cliente");
            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Creacion");
            entity.Property(e => e.FechaModificacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_Modificacion");
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Cliente");
            entity.Property(e => e.TelefonoCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Telefono_Cliente");
        });

        modelBuilder.Entity<Color>(entity =>
        {
            entity.HasKey(e => e.IdColor).HasName("PK20_1_1");

            entity.ToTable("Color");

            entity.Property(e => e.IdColor).HasColumnName("Id_Color");
            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Creacion");
            entity.Property(e => e.FechaModificado)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Modificado");
            entity.Property(e => e.NombreColor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Color");
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
            entity.Property(e => e.CantidadDiasRentaContrato).HasColumnName("Cantidad_Dias_Renta_Contrato");
            entity.Property(e => e.EstaFinalizadoContrato).HasColumnName("estaFinalizadoContrato");
            entity.Property(e => e.FechaCreacionContrato)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Creacion_Contrato");
            entity.Property(e => e.MontoGarantiaContrato)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Monto_Garantia_Contrato");
            entity.Property(e => e.MontoTotalContrato)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Monto_Total_Contrato");
            entity.Property(e => e.PorcentajeDescuentoContrato)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Porcentaje_Descuento_Contrato");
            entity.Property(e => e.RutaFirmaContrato)
                .HasMaxLength(100)
                .HasColumnName("Ruta_Firma_Contrato");
            entity.Property(e => e.TipoPagoContrato)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Tipo_Pago_Contrato");

            entity.HasOne(d => d.FkAutoNavigation).WithMany(p => p.Contratos)
                .HasForeignKey(d => d.FkAuto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefAuto23");

            entity.HasOne(d => d.FkCedulaClienteNavigation).WithMany(p => p.Contratos)
                .HasForeignKey(d => d.FkCedulaCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefCliente62");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Contratos)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefUsuario59");
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
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Precio_Grupal_Auto");
            entity.Property(e => e.PrecioUnidadAuto)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Precio_Unidad_Auto");

            entity.HasOne(d => d.FkAdquisicionNavigation).WithMany(p => p.DetalleAdquisicions)
                .HasForeignKey(d => d.FkAdquisicion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefAdquisicion72");

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

        modelBuilder.Entity<Egreso>(entity =>
        {
            entity.HasKey(e => e.IdEgresos);

            entity.Property(e => e.IdEgresos).HasColumnName("Id_Egresos");
            entity.Property(e => e.DescripcionEgresos)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Descripcion_Egresos");
            entity.Property(e => e.FechaAgreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_Agreso");
            entity.Property(e => e.MontoEgreso).HasColumnName("Monto_Egreso");
            entity.Property(e => e.NombreEgreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Egreso");
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

            entity.HasOne(d => d.FkAutoNavigation).WithMany(p => p.EntregaAutos)
                .HasForeignKey(d => d.FkAuto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefAuto79");
        });

        modelBuilder.Entity<Marca>(entity =>
        {
            entity.HasKey(e => e.IdMarca).HasName("PK20");

            entity.ToTable("Marca");

            entity.Property(e => e.IdMarca).HasColumnName("Id_Marca");
            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Creacion");
            entity.Property(e => e.FechaModificacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Modificacion");
            entity.Property(e => e.NombreMarca)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Marca");
        });

        modelBuilder.Entity<Modelo>(entity =>
        {
            entity.HasKey(e => e.IdModelo).HasName("PK20_1");

            entity.ToTable("Modelo");

            entity.Property(e => e.IdModelo).HasColumnName("Id_Modelo");
            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Creacion");
            entity.Property(e => e.FechaModificacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Modificacion");
            entity.Property(e => e.NombreModelo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Modelo");
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
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Monto_Mora");
            entity.Property(e => e.MotivoMulta)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Motivo_Multa");
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.HasKey(e => e.RucProveedor).HasName("PK9");

            entity.ToTable("Proveedor");

            entity.Property(e => e.RucProveedor)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RUC_Proveedor");
            entity.Property(e => e.CorreoProveedor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Correo_Proveedor");
            entity.Property(e => e.EstaHabilitado).HasColumnName("estaHabilitado");
            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_creacion");
            entity.Property(e => e.FechaModificacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Modificacion");
            entity.Property(e => e.NombreProveedor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Proveedor");
            entity.Property(e => e.TelefonoProveedor)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("Telefono_Proveedor");
        });

        modelBuilder.Entity<RegistrosAperturasCaja>(entity =>
        {
            entity.HasKey(e => e.IdRegistroAperturaCaja)
                .HasName("PK28")
                .IsClustered(false);

            entity.ToTable("Registros_Aperturas_Caja");

            entity.Property(e => e.IdRegistroAperturaCaja).HasColumnName("Id_Registro_Apertura_Caja");
            entity.Property(e => e.FechaAperturaCaja)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Apertura_Caja");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.MontoInicial)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Monto_Inicial");
            entity.Property(e => e.TazaCambio).HasColumnName("Taza_Cambio");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.RegistrosAperturasCajas)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefUsuario85");
        });

        modelBuilder.Entity<RegistrosArqueosCaja>(entity =>
        {
            entity.HasKey(e => e.IdRegistroArqueoCaja).HasName("PK27");

            entity.ToTable("Registros_Arqueos_Caja");

            entity.HasIndex(e => e.IdUsuario, "Ref180");

            entity.Property(e => e.IdRegistroArqueoCaja).HasColumnName("Id_Registro_Arqueo_Caja");
            entity.Property(e => e.DesgloseTotalCordobas)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Desglose_Total_Cordobas");
            entity.Property(e => e.DesgloseTotalDolares)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Desglose_Total_Dolares");
            entity.Property(e => e.EgresoTotalCordobas)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Egreso_Total_Cordobas");
            entity.Property(e => e.EgresoTotalDolares)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Egreso_Total_Dolares");
            entity.Property(e => e.FechaRegistroCaja)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro_Caja");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.MontoEgresado)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Monto_Egresado");
            entity.Property(e => e.MontoFacturado)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Monto_Facturado");
            entity.Property(e => e.MontoInicial)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Monto_Inicial");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.RegistrosArqueosCajas)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefUsuario80");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK1");

            entity.ToTable("Usuario");

            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.CedulaUsuario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Cedula_Usuario");
            entity.Property(e => e.ContraseñaUsuario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Contraseña_Usuario");
            entity.Property(e => e.CorreoUsuario)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Correo_Usuario");
            entity.Property(e => e.EsAdministrador).HasColumnName("esAdministrador");
            entity.Property(e => e.EstaHabilitado).HasColumnName("estaHabilitado");
            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Creacion");
            entity.Property(e => e.FechaLimiteRecuperacion).HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Modificacion");
            entity.Property(e => e.IdCargoEmpleado).HasColumnName("Id_Cargo_empleado");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_usuario");
            entity.Property(e => e.TelefonoUsuario).HasColumnName("Telefono_Usuario");
            entity.Property(e => e.TokenRecuperacion)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.IdCargoEmpleadoNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdCargoEmpleado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefCargo_Empleado83");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
