﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Data;

#nullable disable

namespace Persistence.Data.Migrations
{
    [DbContext(typeof(GardenContext))]
    partial class GardenContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("ApellidoContacto")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("apellido_contacto");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("ciudad");

                    b.Property<int?>("CodigoEmpleadoRepVentas")
                        .HasColumnType("int")
                        .HasColumnName("codigo_empleado_rep_ventas");

                    b.Property<string>("CodigoPostal")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("codigo_postal");

                    b.Property<string>("Fax")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("fax");

                    b.Property<decimal?>("LimiteCredito")
                        .HasPrecision(15, 2)
                        .HasColumnType("decimal(15,2)")
                        .HasColumnName("limite_credito");

                    b.Property<string>("LineaDireccion1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("linea_direccion1");

                    b.Property<string>("LineaDireccion2")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("linea_direccion2");

                    b.Property<string>("NombreCliente")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre_cliente");

                    b.Property<string>("NombreContacto")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("nombre_contacto");

                    b.Property<string>("Pais")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("pais");

                    b.Property<string>("Region")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("region");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("telefono");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "CodigoEmpleadoRepVentas" }, "codigo_empleado_rep_ventas");

                    b.ToTable("cliente", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.DetallePedido", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("CodigoProducto")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("codigo_producto");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int")
                        .HasColumnName("cantidad");

                    b.Property<short>("NumeroLinea")
                        .HasColumnType("smallint")
                        .HasColumnName("numero_linea");

                    b.Property<decimal>("PrecioUnidad")
                        .HasPrecision(15, 2)
                        .HasColumnType("decimal(15,2)")
                        .HasColumnName("precio_unidad");

                    b.HasKey("Id", "CodigoProducto")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.HasIndex(new[] { "CodigoProducto" }, "codigo_producto");

                    b.ToTable("detalle_pedido", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Apellido1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("apellido1");

                    b.Property<string>("Apellido2")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("apellido2");

                    b.Property<int?>("CodigoJefe")
                        .HasColumnType("int")
                        .HasColumnName("codigo_jefe");

                    b.Property<string>("CodigoOficina")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("codigo_oficina");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("Extension")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("extension");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.Property<string>("Puesto")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("puesto");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "CodigoJefe" }, "codigo_jefe");

                    b.HasIndex(new[] { "CodigoOficina" }, "codigo_oficina");

                    b.ToTable("empleado", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.GamaProducto", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("id");

                    b.Property<string>("DescripcionHtml")
                        .HasColumnType("text")
                        .HasColumnName("descripcion_html");

                    b.Property<string>("DescripcionTexto")
                        .HasColumnType("text")
                        .HasColumnName("descripcion_texto");

                    b.Property<string>("Imagen")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("imagen");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("gama_producto", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Oficina", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("id");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("ciudad");

                    b.Property<string>("CodigoPostal")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("codigo_postal");

                    b.Property<string>("LineaDireccion1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("linea_direccion1");

                    b.Property<string>("LineaDireccion2")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("linea_direccion2");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("pais");

                    b.Property<string>("Region")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("region");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("telefono");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("oficina", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Pago", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("IdTransaccion")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("id_transaccion");

                    b.Property<DateOnly>("FechaPago")
                        .HasColumnType("date")
                        .HasColumnName("fecha_pago");

                    b.Property<string>("FormaPago")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("forma_pago");

                    b.Property<decimal>("Total")
                        .HasPrecision(15, 2)
                        .HasColumnType("decimal(15,2)")
                        .HasColumnName("total");

                    b.HasKey("Id", "IdTransaccion")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.ToTable("pago", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("CodigoCliente")
                        .HasColumnType("int")
                        .HasColumnName("codigo_cliente");

                    b.Property<string>("Comentarios")
                        .HasColumnType("text")
                        .HasColumnName("comentarios");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("estado");

                    b.Property<DateOnly?>("FechaEntrega")
                        .HasColumnType("date")
                        .HasColumnName("fecha_entrega");

                    b.Property<DateOnly>("FechaEsperada")
                        .HasColumnType("date")
                        .HasColumnName("fecha_esperada");

                    b.Property<DateOnly>("FechaPedido")
                        .HasColumnType("date")
                        .HasColumnName("fecha_pedido");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "CodigoCliente" }, "codigo_cliente");

                    b.ToTable("pedido", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Producto", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("id");

                    b.Property<short>("CantidadEnStock")
                        .HasColumnType("smallint")
                        .HasColumnName("cantidad_en_stock");

                    b.Property<string>("Descripcion")
                        .HasColumnType("text")
                        .HasColumnName("descripcion");

                    b.Property<string>("Dimensiones")
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("dimensiones");

                    b.Property<string>("Gama")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("gama");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("varchar(70)")
                        .HasColumnName("nombre");

                    b.Property<decimal?>("PrecioProveedor")
                        .HasPrecision(15, 2)
                        .HasColumnType("decimal(15,2)")
                        .HasColumnName("precio_proveedor");

                    b.Property<decimal>("PrecioVenta")
                        .HasPrecision(15, 2)
                        .HasColumnType("decimal(15,2)")
                        .HasColumnName("precio_venta");

                    b.Property<string>("Proveedor")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("proveedor");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Gama" }, "gama");

                    b.ToTable("producto", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Cliente", b =>
                {
                    b.HasOne("Domain.Entities.Empleado", "CodigoEmpleadoRepVentasNavigation")
                        .WithMany("Clientes")
                        .HasForeignKey("CodigoEmpleadoRepVentas")
                        .HasConstraintName("cliente_ibfk_1");

                    b.Navigation("CodigoEmpleadoRepVentasNavigation");
                });

            modelBuilder.Entity("Domain.Entities.DetallePedido", b =>
                {
                    b.HasOne("Domain.Entities.Producto", "CodigoProductoNavigation")
                        .WithMany("DetallePedidos")
                        .HasForeignKey("CodigoProducto")
                        .IsRequired()
                        .HasConstraintName("detalle_pedido_ibfk_2");

                    b.HasOne("Domain.Entities.Pedido", "IdNavigation")
                        .WithMany("DetallePedidos")
                        .HasForeignKey("Id")
                        .IsRequired()
                        .HasConstraintName("detalle_pedido_ibfk_1");

                    b.Navigation("CodigoProductoNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Empleado", b =>
                {
                    b.HasOne("Domain.Entities.Empleado", "CodigoJefeNavigation")
                        .WithMany("InverseCodigoJefeNavigation")
                        .HasForeignKey("CodigoJefe")
                        .HasConstraintName("empleado_ibfk_2");

                    b.HasOne("Domain.Entities.Oficina", "CodigoOficinaNavigation")
                        .WithMany("Empleados")
                        .HasForeignKey("CodigoOficina")
                        .IsRequired()
                        .HasConstraintName("empleado_ibfk_1");

                    b.Navigation("CodigoJefeNavigation");

                    b.Navigation("CodigoOficinaNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Pago", b =>
                {
                    b.HasOne("Domain.Entities.Cliente", "IdNavigation")
                        .WithMany("Pagos")
                        .HasForeignKey("Id")
                        .IsRequired()
                        .HasConstraintName("pago_ibfk_1");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Pedido", b =>
                {
                    b.HasOne("Domain.Entities.Cliente", "CodigoClienteNavigation")
                        .WithMany("Pedidos")
                        .HasForeignKey("CodigoCliente")
                        .IsRequired()
                        .HasConstraintName("pedido_ibfk_1");

                    b.Navigation("CodigoClienteNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Producto", b =>
                {
                    b.HasOne("Domain.Entities.GamaProducto", "GamaNavigation")
                        .WithMany("Productos")
                        .HasForeignKey("Gama")
                        .IsRequired()
                        .HasConstraintName("producto_ibfk_1");

                    b.Navigation("GamaNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Cliente", b =>
                {
                    b.Navigation("Pagos");

                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("Domain.Entities.Empleado", b =>
                {
                    b.Navigation("Clientes");

                    b.Navigation("InverseCodigoJefeNavigation");
                });

            modelBuilder.Entity("Domain.Entities.GamaProducto", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Domain.Entities.Oficina", b =>
                {
                    b.Navigation("Empleados");
                });

            modelBuilder.Entity("Domain.Entities.Pedido", b =>
                {
                    b.Navigation("DetallePedidos");
                });

            modelBuilder.Entity("Domain.Entities.Producto", b =>
                {
                    b.Navigation("DetallePedidos");
                });
#pragma warning restore 612, 618
        }
    }
}