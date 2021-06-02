﻿// <auto-generated />
using AspCoreCRUD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace aspCoreCrud.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspCoreCRUD.Models.Employee", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("balance")
                        .HasColumnType("int");

                    b.Property<int>("cardNumber")
                        .HasColumnType("int");

                    b.Property<int>("cvv")
                        .HasColumnType("int");

                    b.Property<string>("expiryDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("grandTotal")
                        .HasColumnType("int");

                    b.Property<int>("handlingCost")
                        .HasColumnType("int");

                    b.Property<string>("orderDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("orderStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("payAmount")
                        .HasColumnType("int");

                    b.Property<string>("paymentEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shipAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shipAddressEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shippedDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("shippingCost")
                        .HasColumnType("int");

                    b.Property<int>("subtotal")
                        .HasColumnType("int");

                    b.Property<int>("trackingNumber")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("AspCoreCRUD.Models.Employer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("orderid")
                        .HasColumnType("int");

                    b.Property<string>("productId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Employers");
                });
#pragma warning restore 612, 618
        }
    }
}
