using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace vitamedica.Models.ConexionBD;

public partial class VitamedicaContext : DbContext
{
    public string tipoApi;

    public IConfiguration Configuration { get; }

    public VitamedicaContext()
    {
    }

    public VitamedicaContext(DbContextOptions<VitamedicaContext> options, IConfiguration configuration)
        : base(options)
    {
        Configuration = configuration;
    }

    public virtual DbSet<VitBadTransaccione> VitBadTransacciones { get; set; }

    public virtual DbSet<VitBitError> VitBitErrors { get; set; }

    public virtual DbSet<VitColote> VitColotes { get; set; }

    public virtual DbSet<VitComission> VitComissions { get; set; }

    public virtual DbSet<VitConsulta> VitConsultas { get; set; }

    public virtual DbSet<VitFolio> VitFolios { get; set; }

    public virtual DbSet<VitHeader> VitHeaders { get; set; }

    public virtual DbSet<VitInfopaciente> VitInfopacientes { get; set; }

    public virtual DbSet<VitLote> VitLotes { get; set; }

    public virtual DbSet<VitPlantillaParamsw> VitPlantillaParamsws { get; set; }

    public virtual DbSet<VitService> VitServices { get; set; }

    public virtual DbSet<VitServicioParam> VitServicioParams { get; set; }

    public virtual DbSet<VitTransaccione> VitTransacciones { get; set; }

    public virtual DbSet<VitTrx0> VitTrx0s { get; set; }

    public virtual DbSet<VitTrx1> VitTrx1s { get; set; }

    public virtual DbSet<VitTrx2> VitTrx2s { get; set; }

    public virtual DbSet<VitTrx3> VitTrx3s { get; set; }

    public virtual DbSet<VitTrx4> VitTrx4s { get; set; }

    public virtual DbSet<VitTrx5> VitTrx5s { get; set; }

    public virtual DbSet<VitVfd> VitVfds { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<VitBadTransaccione>(entity =>
        {
            entity.HasKey(e => e.IdPropio).HasName("PRIMARY");

            entity.ToTable("vit_bad_transacciones");

            entity.HasIndex(e => new { e.IdLote, e.IdFolio, e.Originador }, "lote").IsUnique();

            entity.HasIndex(e => new { e.Originador, e.Nodo, e.ReferTrans }, "originador").IsUnique();

            entity.Property(e => e.IdPropio)
                .HasColumnType("int(11)")
                .HasColumnName("idPropio");
            entity.Property(e => e.Afectado)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("afectado");
            entity.Property(e => e.Concepto)
                .HasColumnType("smallint(6)")
                .HasColumnName("concepto");
            entity.Property(e => e.Estatus)
                .HasColumnType("smallint(6)")
                .HasColumnName("estatus");
            entity.Property(e => e.FEstatus)
                .HasColumnType("datetime")
                .HasColumnName("fEstatus");
            entity.Property(e => e.Fecha)
                .HasColumnType("date")
                .HasColumnName("fecha");
            entity.Property(e => e.Fee)
                .HasPrecision(9)
                .HasComment("Tarifa o comision")
                .HasColumnName("fee");
            entity.Property(e => e.FinInserta)
                .HasColumnType("datetime")
                .HasColumnName("finInserta");
            entity.Property(e => e.Hora)
                .HasColumnType("datetime")
                .HasColumnName("hora");
            entity.Property(e => e.IdColote)
                .HasColumnType("int(11)")
                .HasColumnName("idColote");
            entity.Property(e => e.IdDia)
                .HasColumnType("int(11)")
                .HasColumnName("idDia");
            entity.Property(e => e.IdFolio)
                .HasColumnType("int(11)")
                .HasColumnName("idFolio");
            entity.Property(e => e.IdLote)
                .HasColumnType("int(11)")
                .HasColumnName("idLote");
            entity.Property(e => e.Monto)
                .HasPrecision(9)
                .HasColumnName("monto");
            entity.Property(e => e.Nodo)
                .HasColumnType("smallint(6)")
                .HasColumnName("nodo");
            entity.Property(e => e.Originador)
                .HasColumnType("smallint(6)")
                .HasColumnName("originador");
            entity.Property(e => e.ReferTrans)
                .HasMaxLength(20)
                .HasColumnName("referTrans");
            entity.Property(e => e.Referenciafg)
                .HasMaxLength(20)
                .HasColumnName("referenciafg");
            entity.Property(e => e.Ticket)
                .HasColumnType("int(11)")
                .HasColumnName("ticket");
            entity.Property(e => e.Trxsubtype)
                .HasColumnType("smallint(6)")
                .HasColumnName("trxsubtype");
            entity.Property(e => e.Trxtype)
                .HasColumnType("smallint(6)")
                .HasColumnName("trxtype");
            entity.Property(e => e.Vitaccount)
                .HasMaxLength(50)
                .HasColumnName("vitaccount");
            entity.Property(e => e.Vitacount)
                .HasMaxLength(255)
                .HasColumnName("vitacount");
            entity.Property(e => e.Vitauth)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("vitauth");
            entity.Property(e => e.Vitcode)
                .HasColumnType("int(11)")
                .HasColumnName("vitcode");
            entity.Property(e => e.Vitidtransaccion)
                .HasMaxLength(45)
                .HasColumnName("vitidtransaccion");
            entity.Property(e => e.Vitrefer)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("vitrefer");
            entity.Property(e => e.Vittype)
                .HasColumnType("smallint(6)")
                .HasColumnName("vittype");
        });

        modelBuilder.Entity<VitBitError>(entity =>
        {
            entity.HasKey(e => e.IdPropio).HasName("PRIMARY");

            entity.ToTable("vit_bit_error");

            entity.Property(e => e.IdPropio)
                .HasColumnType("int(11)")
                .HasColumnName("idPropio");
            entity.Property(e => e.DescError)
                .HasMaxLength(50)
                .HasColumnName("descError");
            entity.Property(e => e.Error)
                .HasMaxLength(10)
                .HasComment("1 - Interno\\\\n2 - Proveedor")
                .HasColumnName("error");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Nodo)
                .HasColumnType("smallint(6)")
                .HasColumnName("nodo");
            entity.Property(e => e.Origen)
                .HasColumnType("smallint(6)")
                .HasColumnName("origen");
            entity.Property(e => e.ReferTrans)
                .HasMaxLength(20)
                .HasColumnName("referTrans");
            entity.Property(e => e.Type)
                .HasMaxLength(25)
                .HasColumnName("type");
        });

        modelBuilder.Entity<VitColote>(entity =>
        {
            entity.HasKey(e => e.IdPropio).HasName("PRIMARY");

            entity.ToTable("vit_colotes");

            entity.Property(e => e.IdPropio)
                .HasColumnType("int(11)")
                .HasColumnName("idPropio");
            entity.Property(e => e.Colote)
                .HasColumnType("int(11)")
                .HasColumnName("colote");
            entity.Property(e => e.Fecha)
                .HasColumnType("date")
                .HasColumnName("fecha");
            entity.Property(e => e.FechaHora)
                .HasColumnType("datetime")
                .HasColumnName("fechaHora");
        });

        modelBuilder.Entity<VitComission>(entity =>
        {
            entity.HasKey(e => e.IdPropio).HasName("PRIMARY");

            entity.ToTable("vit_comission");

            entity.Property(e => e.IdPropio)
                .HasColumnType("int(11)")
                .HasColumnName("idPropio");
            entity.Property(e => e.Amount)
                .HasPrecision(9)
                .HasColumnName("amount");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("startDate");
            entity.Property(e => e.Vitatype)
                .HasColumnType("smallint(6)")
                .HasColumnName("vitatype");
        });

        modelBuilder.Entity<VitConsulta>(entity =>
        {
            entity.HasKey(e => e.IdVitconsultas).HasName("PRIMARY");

            entity.ToTable("vit_consultas");

            entity.Property(e => e.IdVitconsultas)
                .HasColumnType("int(11)")
                .HasColumnName("id_vitconsultas");
            entity.Property(e => e.Codigoerror)
                .HasColumnType("int(11)")
                .HasColumnName("codigoerror");
            entity.Property(e => e.FechaInsert)
                .HasColumnType("date")
                .HasColumnName("fechaInsert");
            entity.Property(e => e.FechaUpdate)
                .HasColumnType("date")
                .HasColumnName("fechaUpdate");
            entity.Property(e => e.Folio)
                .HasMaxLength(45)
                .HasColumnName("folio");
            entity.Property(e => e.Mensajeerror)
                .HasMaxLength(200)
                .HasColumnName("mensajeerror");
            entity.Property(e => e.PrprId)
                .HasMaxLength(45)
                .HasColumnName("prpr_id");
            entity.Property(e => e.Tipoconsulta)
                .HasMaxLength(45)
                .HasColumnName("tipoconsulta");
        });

        modelBuilder.Entity<VitFolio>(entity =>
        {
            entity.HasKey(e => new { e.Folio, e.Sucursal }).HasName("PRIMARY");

            entity.ToTable("vit_folios");

            entity.HasIndex(e => new { e.Folio, e.Sucursal }, "folio01");

            entity.Property(e => e.Folio)
                .ValueGeneratedOnAdd()
                .HasColumnType("int(11)")
                .HasColumnName("folio");
            entity.Property(e => e.Sucursal)
                .HasColumnType("int(11)")
                .HasColumnName("sucursal");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .HasDefaultValueSql("'A'")
                .HasColumnName("estatus");
            entity.Property(e => e.Fecha)
                .HasColumnType("date")
                .HasColumnName("fecha");
            entity.Property(e => e.SerFolio)
                .HasMaxLength(3)
                .HasColumnName("serFolio");
        });

        modelBuilder.Entity<VitHeader>(entity =>
        {
            entity.HasKey(e => e.IdPropio).HasName("PRIMARY");

            entity.ToTable("vit_headers");

            entity.Property(e => e.IdPropio)
                .HasColumnType("int(11)")
                .HasColumnName("idPropio");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Descerror)
                .HasMaxLength(50)
                .HasColumnName("descerror");
            entity.Property(e => e.Error)
                .HasMaxLength(15)
                .HasColumnName("error");
            entity.Property(e => e.FolioProceso)
                .HasColumnType("int(11)")
                .HasColumnName("folioProceso");
            entity.Property(e => e.Lote)
                .HasMaxLength(25)
                .HasColumnName("lote");
            entity.Property(e => e.Nodo)
                .HasMaxLength(20)
                .HasColumnName("nodo");
            entity.Property(e => e.Origen)
                .HasMaxLength(30)
                .HasColumnName("origen");
            entity.Property(e => e.Origenresp)
                .HasMaxLength(20)
                .HasColumnName("origenresp");
            entity.Property(e => e.Refertrans)
                .HasMaxLength(20)
                .HasColumnName("refertrans");
            entity.Property(e => e.Transaccion)
                .HasMaxLength(25)
                .HasColumnName("transaccion");
            entity.Property(e => e.Trxsubtype)
                .HasMaxLength(5)
                .HasColumnName("trxsubtype");
            entity.Property(e => e.Txttype)
                .HasMaxLength(5)
                .HasColumnName("txttype");
            entity.Property(e => e.Type)
                .HasMaxLength(30)
                .HasColumnName("type");
        });

        modelBuilder.Entity<VitInfopaciente>(entity =>
        {
            entity.HasKey(e => e.IdVitinfoPaciente).HasName("PRIMARY");

            entity.ToTable("vit_infopaciente");

            entity.Property(e => e.IdVitinfoPaciente)
                .HasColumnType("int(11)")
                .HasColumnName("id_vitinfoPaciente");
            entity.Property(e => e.ApeMaterno)
                .HasMaxLength(100)
                .HasColumnName("ape_materno");
            entity.Property(e => e.ApePaterno)
                .HasMaxLength(100)
                .HasColumnName("ape_paterno");
            entity.Property(e => e.Cedula)
                .HasMaxLength(20)
                .HasColumnName("cedula");
            entity.Property(e => e.Elegibilidad)
                .HasMaxLength(15)
                .HasColumnName("elegibilidad");
            entity.Property(e => e.EstatusEmpleado)
                .HasColumnType("int(11)")
                .HasColumnName("estatus_empleado");
            entity.Property(e => e.FechaConsulta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_consulta");
            entity.Property(e => e.IdPersona)
                .HasMaxLength(20)
                .HasColumnName("id_persona");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.NumCredencial)
                .HasMaxLength(20)
                .HasColumnName("numCredencial");
            entity.Property(e => e.NumReceta)
                .HasMaxLength(15)
                .HasColumnName("num_receta");
            entity.Property(e => e.TipoEmpleado)
                .HasColumnType("int(11)")
                .HasColumnName("tipo_empleado");
        });

        modelBuilder.Entity<VitLote>(entity =>
        {
            entity.HasKey(e => new { e.Lote, e.Sucursal }).HasName("PRIMARY");

            entity.ToTable("vit_lotes");

            entity.HasIndex(e => new { e.Lote, e.Fecha, e.Sucursal }, "lote01");

            entity.HasIndex(e => new { e.Sucursal, e.Colote }, "lote02");

            entity.HasIndex(e => new { e.Colote, e.Fecha }, "lote03");

            entity.Property(e => e.Lote)
                .ValueGeneratedOnAdd()
                .HasColumnType("int(11)")
                .HasColumnName("lote");
            entity.Property(e => e.Sucursal)
                .HasColumnType("int(11)")
                .HasColumnName("sucursal");
            entity.Property(e => e.Colote)
                .HasColumnType("int(11)")
                .HasColumnName("colote");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .HasDefaultValueSql("'A'")
                .HasColumnName("estatus");
            entity.Property(e => e.Fecha)
                .HasColumnType("date")
                .HasColumnName("fecha");
            entity.Property(e => e.FechaHora)
                .HasColumnType("datetime")
                .HasColumnName("fechaHora");
            entity.Property(e => e.SerLote)
                .HasMaxLength(3)
                .HasColumnName("serLote");
        });

        modelBuilder.Entity<VitPlantillaParamsw>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("vit_plantilla_paramsws");

            entity.Property(e => e.IdPlantilla)
                .HasColumnType("int(11)")
                .HasColumnName("id_plantilla");
            entity.Property(e => e.IdPlantillaParamws)
                .HasColumnType("int(11)")
                .HasColumnName("id_plantilla_paramws");
            entity.Property(e => e.NombreTrx)
                .HasMaxLength(200)
                .HasColumnName("nombreTrx");
            entity.Property(e => e.Parametro)
                .HasMaxLength(100)
                .HasColumnName("parametro");
            entity.Property(e => e.RestServicios)
                .HasColumnType("int(11)")
                .HasColumnName("REST_SERVICIOS");
            entity.Property(e => e.RestUrls)
                .HasColumnType("int(11)")
                .HasColumnName("REST_URLS");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<VitService>(entity =>
        {
            entity.HasKey(e => e.IdvitServices).HasName("PRIMARY");

            entity.ToTable("vit_services");

            entity.Property(e => e.IdvitServices)
                .HasColumnType("int(11)")
                .HasColumnName("idvit_services");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(45)
                .HasColumnName("descripcion");
            entity.Property(e => e.Idmensaje)
                .HasColumnType("int(11)")
                .HasColumnName("idmensaje");
            entity.Property(e => e.Time)
                .HasColumnType("int(11)")
                .HasColumnName("time");
            entity.Property(e => e.Url)
                .HasMaxLength(250)
                .HasColumnName("url");
        });

        modelBuilder.Entity<VitServicioParam>(entity =>
        {
            entity.HasKey(e => e.IdVitservicioParams).HasName("PRIMARY");

            entity.ToTable("vit_servicio_params");

            entity.Property(e => e.IdVitservicioParams)
                .HasColumnType("int(11)")
                .HasColumnName("id_vitservicio_params");
            entity.Property(e => e.Estatus)
                .HasColumnType("int(11)")
                .HasColumnName("estatus");
            entity.Property(e => e.PrprIdProducion)
                .HasMaxLength(20)
                .HasColumnName("prpr_id_producion");
            entity.Property(e => e.PrprIdQa)
                .HasMaxLength(20)
                .HasColumnName("prpr_id_QA");
            entity.Property(e => e.Sucursal)
                .HasMaxLength(20)
                .HasColumnName("sucursal");
        });

        modelBuilder.Entity<VitTransaccione>(entity =>
        {
            entity.HasKey(e => e.IdPropio).HasName("PRIMARY");

            entity.ToTable("vit_transacciones");

            entity.HasIndex(e => new { e.IdLote, e.IdFolio, e.Originador }, "lote").IsUnique();

            entity.HasIndex(e => new { e.Originador, e.Nodo, e.ReferTrans }, "originador").IsUnique();

            entity.Property(e => e.IdPropio)
                .HasColumnType("int(11)")
                .HasColumnName("idPropio");
            entity.Property(e => e.Afectado)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("afectado");
            entity.Property(e => e.Concepto)
                .HasColumnType("smallint(6)")
                .HasColumnName("concepto");
            entity.Property(e => e.Estatus)
                .HasColumnType("smallint(6)")
                .HasColumnName("estatus");
            entity.Property(e => e.FEstatus)
                .HasColumnType("datetime")
                .HasColumnName("fEstatus");
            entity.Property(e => e.Fecha)
                .HasColumnType("date")
                .HasColumnName("fecha");
            entity.Property(e => e.Fee)
                .HasPrecision(9)
                .HasComment("Tarifa o comision")
                .HasColumnName("fee");
            entity.Property(e => e.FinInserta)
                .HasColumnType("datetime")
                .HasColumnName("finInserta");
            entity.Property(e => e.Hora)
                .HasColumnType("datetime")
                .HasColumnName("hora");
            entity.Property(e => e.IdColote)
                .HasColumnType("int(11)")
                .HasColumnName("idColote");
            entity.Property(e => e.IdDia)
                .HasColumnType("int(11)")
                .HasColumnName("idDia");
            entity.Property(e => e.IdFolio)
                .HasColumnType("int(11)")
                .HasColumnName("idFolio");
            entity.Property(e => e.IdLote)
                .HasColumnType("int(11)")
                .HasColumnName("idLote");
            entity.Property(e => e.Monto)
                .HasPrecision(9)
                .HasColumnName("monto");
            entity.Property(e => e.Nodo)
                .HasColumnType("smallint(6)")
                .HasColumnName("nodo");
            entity.Property(e => e.Originador)
                .HasColumnType("smallint(6)")
                .HasColumnName("originador");
            entity.Property(e => e.ReferTrans)
                .HasMaxLength(20)
                .HasColumnName("referTrans");
            entity.Property(e => e.Referenciafg)
                .HasMaxLength(20)
                .HasColumnName("referenciafg");
            entity.Property(e => e.Ticket)
                .HasColumnType("int(11)")
                .HasColumnName("ticket");
            entity.Property(e => e.Trxsubtype)
                .HasColumnType("smallint(6)")
                .HasColumnName("trxsubtype");
            entity.Property(e => e.Trxtype)
                .HasColumnType("smallint(6)")
                .HasColumnName("trxtype");
            entity.Property(e => e.Vitaccount)
                .HasMaxLength(50)
                .HasColumnName("vitaccount");
            entity.Property(e => e.Vitacount)
                .HasMaxLength(255)
                .HasColumnName("vitacount");
            entity.Property(e => e.Vitauth)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("vitauth");
            entity.Property(e => e.Vitcode)
                .HasColumnType("int(11)")
                .HasColumnName("vitcode");
            entity.Property(e => e.Vitidtransaccion)
                .HasMaxLength(45)
                .HasColumnName("vitidtransaccion");
            entity.Property(e => e.Vitrefer)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("vitrefer");
            entity.Property(e => e.Vittype)
                .HasColumnType("smallint(6)")
                .HasColumnName("vittype");
        });

        modelBuilder.Entity<VitTrx0>(entity =>
        {
            entity.HasKey(e => e.IdVittrx0).HasName("PRIMARY");

            entity.ToTable("vit_trx0");

            entity.Property(e => e.IdVittrx0)
                .HasColumnType("int(11)")
                .HasColumnName("id_vittrx0");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Error)
                .HasMaxLength(45)
                .HasColumnName("ERROR");
            entity.Property(e => e.Folio).HasMaxLength(45);
            entity.Property(e => e.PrIdenCade)
                .HasMaxLength(45)
                .HasColumnName("prIdenCade");
            entity.Property(e => e.PrIdenSucu)
                .HasMaxLength(100)
                .HasColumnName("prIdenSucu");
            entity.Property(e => e.Seciniventa)
                .HasMaxLength(45)
                .HasColumnName("SECINIVENTA");
            entity.Property(e => e.UpdateAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<VitTrx1>(entity =>
        {
            entity.HasKey(e => e.IdVittrx1).HasName("PRIMARY");

            entity.ToTable("vit_trx1");

            entity.Property(e => e.IdVittrx1)
                .HasColumnType("int(11)")
                .HasColumnName("id_vittrx1");
            entity.Property(e => e.Ca1)
                .HasMaxLength(45)
                .HasColumnName("CA1");
            entity.Property(e => e.Cliente)
                .HasMaxLength(45)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Edad)
                .HasMaxLength(45)
                .HasColumnName("EDAD");
            entity.Property(e => e.Error)
                .HasMaxLength(45)
                .HasColumnName("ERROR");
            entity.Property(e => e.Grupo)
                .HasMaxLength(45)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Mens)
                .HasMaxLength(45)
                .HasColumnName("MENS");
            entity.Property(e => e.Nomb)
                .HasMaxLength(45)
                .HasColumnName("NOMB");
            entity.Property(e => e.PrCopia)
                .HasMaxLength(45)
                .HasColumnName("prCopia");
            entity.Property(e => e.PrFolioReceta)
                .HasMaxLength(45)
                .HasColumnName("prFolioReceta");
            entity.Property(e => e.PrIdenCade)
                .HasMaxLength(45)
                .HasColumnName("prIdenCade");
            entity.Property(e => e.PrIdenSucu)
                .HasMaxLength(45)
                .HasColumnName("prIdenSucu");
            entity.Property(e => e.PrNumElegibilidad)
                .HasMaxLength(45)
                .HasColumnName("prNumElegibilidad");
            entity.Property(e => e.PrNumPreautorizacion)
                .HasMaxLength(45)
                .HasColumnName("prNumPreautorizacion");
            entity.Property(e => e.PrSecIniVenta)
                .HasMaxLength(45)
                .HasColumnName("prSecIniVenta");
            entity.Property(e => e.PrSecuencia)
                .HasMaxLength(45)
                .HasColumnName("prSecuencia");
            entity.Property(e => e.Primapel)
                .HasMaxLength(45)
                .HasColumnName("PRIMAPEL");
            entity.Property(e => e.Seguapel)
                .HasMaxLength(45)
                .HasColumnName("SEGUAPEL");
            entity.Property(e => e.Sexo)
                .HasMaxLength(45)
                .HasColumnName("SEXO");
            entity.Property(e => e.Tiporeceta)
                .HasMaxLength(45)
                .HasColumnName("TIPORECETA");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
            entity.Property(e => e.Valivent)
                .HasMaxLength(45)
                .HasColumnName("VALIVENT");
        });

        modelBuilder.Entity<VitTrx2>(entity =>
        {
            entity.HasKey(e => e.IdVittrx2).HasName("PRIMARY");

            entity.ToTable("vit_trx2");

            entity.Property(e => e.IdVittrx2)
                .HasColumnType("int(11)")
                .HasColumnName("id_vittrx2");
            entity.Property(e => e.Ca1)
                .HasMaxLength(45)
                .HasColumnName("CA1");
            entity.Property(e => e.Ca2)
                .HasMaxLength(45)
                .HasColumnName("CA2");
            entity.Property(e => e.CantProdAuto).HasMaxLength(45);
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Error)
                .HasMaxLength(45)
                .HasColumnName("ERROR");
            entity.Property(e => e.MensajeSeg).HasMaxLength(45);
            entity.Property(e => e.MtoTotalCopa).HasMaxLength(45);
            entity.Property(e => e.MtoTotalCred).HasMaxLength(45);
            entity.Property(e => e.PrCantSurt)
                .HasMaxLength(45)
                .HasColumnName("prCantSurt");
            entity.Property(e => e.PrCantToma)
                .HasMaxLength(45)
                .HasColumnName("prCantToma");
            entity.Property(e => e.PrDesc)
                .HasMaxLength(45)
                .HasColumnName("prDesc");
            entity.Property(e => e.PrDesglva)
                .HasMaxLength(45)
                .HasColumnName("prDesglva");
            entity.Property(e => e.PrDias)
                .HasMaxLength(45)
                .HasColumnName("prDias");
            entity.Property(e => e.PrIdenCade)
                .HasMaxLength(45)
                .HasColumnName("prIdenCade");
            entity.Property(e => e.PrIdenProd)
                .HasMaxLength(45)
                .HasColumnName("prIdenProd");
            entity.Property(e => e.PrIdenSucu)
                .HasMaxLength(45)
                .HasColumnName("prIdenSucu");
            entity.Property(e => e.PrPmp)
                .HasMaxLength(45)
                .HasColumnName("prPMP");
            entity.Property(e => e.PrSecuencia)
                .HasMaxLength(45)
                .HasColumnName("prSecuencia");
            entity.Property(e => e.PrValorTotalVenta)
                .HasMaxLength(45)
                .HasColumnName("prValorTotalVenta");
            entity.Property(e => e.PrValorUnitVenta)
                .HasMaxLength(45)
                .HasColumnName("prValorUnitVenta");
            entity.Property(e => e.PrVecesDia)
                .HasMaxLength(45)
                .HasColumnName("prVecesDia");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
        });

        modelBuilder.Entity<VitTrx3>(entity =>
        {
            entity.HasKey(e => e.IdVittrx3).HasName("PRIMARY");

            entity.ToTable("vit_trx3");

            entity.Property(e => e.IdVittrx3)
                .HasColumnType("int(11)")
                .HasColumnName("id_vittrx3");
            entity.Property(e => e.Ca1)
                .HasMaxLength(45)
                .HasColumnName("CA1");
            entity.Property(e => e.Ca2)
                .HasMaxLength(45)
                .HasColumnName("CA2");
            entity.Property(e => e.Ca3)
                .HasMaxLength(45)
                .HasColumnName("CA3");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Error)
                .HasMaxLength(45)
                .HasColumnName("ERROR");
            entity.Property(e => e.PrIdenCade)
                .HasMaxLength(45)
                .HasColumnName("prIdenCade");
            entity.Property(e => e.PrIdenSucu)
                .HasMaxLength(45)
                .HasColumnName("prIdenSucu");
            entity.Property(e => e.PrSecuencia)
                .HasMaxLength(45)
                .HasColumnName("prSecuencia");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
        });

        modelBuilder.Entity<VitTrx4>(entity =>
        {
            entity.HasKey(e => e.IdVittrx4).HasName("PRIMARY");

            entity.ToTable("vit_trx4");

            entity.Property(e => e.IdVittrx4)
                .HasColumnType("int(11)")
                .HasColumnName("id_vittrx4");
            entity.Property(e => e.Ca1)
                .HasMaxLength(45)
                .HasColumnName("CA1");
            entity.Property(e => e.Ca4)
                .HasMaxLength(45)
                .HasColumnName("CA4");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Error)
                .HasMaxLength(45)
                .HasColumnName("ERROR");
            entity.Property(e => e.PrCodiAcep)
                .HasMaxLength(45)
                .HasColumnName("prCodiAcep");
            entity.Property(e => e.PrDesglIva)
                .HasMaxLength(45)
                .HasColumnName("prDesglIva");
            entity.Property(e => e.PrIdenCade)
                .HasMaxLength(45)
                .HasColumnName("prIdenCade");
            entity.Property(e => e.PrIdenSucu)
                .HasMaxLength(45)
                .HasColumnName("prIdenSucu");
            entity.Property(e => e.PrNumFact)
                .HasMaxLength(45)
                .HasColumnName("prNumFact");
            entity.Property(e => e.PrSecuencia)
                .HasMaxLength(45)
                .HasColumnName("prSecuencia");
            entity.Property(e => e.PrVentTotal)
                .HasMaxLength(45)
                .HasColumnName("prVentTotal");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
        });

        modelBuilder.Entity<VitTrx5>(entity =>
        {
            entity.HasKey(e => e.IdVittrx5).HasName("PRIMARY");

            entity.ToTable("vit_trx5");

            entity.Property(e => e.IdVittrx5)
                .HasColumnType("int(11)")
                .HasColumnName("id_vittrx5");
            entity.Property(e => e.Ca4)
                .HasMaxLength(45)
                .HasColumnName("CA4");
            entity.Property(e => e.Ca5)
                .HasMaxLength(45)
                .HasColumnName("CA5");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Error)
                .HasMaxLength(45)
                .HasColumnName("ERROR");
            entity.Property(e => e.PrIdenCade)
                .HasMaxLength(45)
                .HasColumnName("prIdenCade");
            entity.Property(e => e.PrIdenSucu)
                .HasMaxLength(45)
                .HasColumnName("prIdenSucu");
            entity.Property(e => e.PrNumFact)
                .HasMaxLength(45)
                .HasColumnName("prNumFact");
            entity.Property(e => e.PrSecuencia)
                .HasMaxLength(45)
                .HasColumnName("prSecuencia");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
        });

        modelBuilder.Entity<VitVfd>(entity =>
        {
            entity.HasKey(e => e.IdVitVfd).HasName("PRIMARY");

            entity.ToTable("vit_vfd");

            entity.Property(e => e.IdVitVfd)
                .HasColumnType("int(11)")
                .HasColumnName("id_vitVfd");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Elegibilidad)
                .HasMaxLength(20)
                .HasColumnName("elegibilidad");
            entity.Property(e => e.FirmaDigital)
                .HasMaxLength(20)
                .HasColumnName("firma_digital");
            entity.Property(e => e.FirmaValida)
                .HasColumnType("bigint(20)")
                .HasColumnName("firma_valida");
            entity.Property(e => e.IdProveedor)
                .HasMaxLength(20)
                .HasColumnName("id_proveedor");
            entity.Property(e => e.Mensaje)
                .HasMaxLength(200)
                .HasColumnName("mensaje");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
