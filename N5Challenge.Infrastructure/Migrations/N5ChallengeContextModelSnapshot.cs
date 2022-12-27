﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using N5Challenge.Infrastructure;

#nullable disable

namespace N5Challenge.Infrastructure.Migrations
{
    [DbContext(typeof(N5ChallengeContext))]
    partial class N5ChallengeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("N5Challenge.Domain.Entities.PermissionsEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("DateOfPermission")
                        .HasColumnType("datetime")
                        .HasColumnName("FechaPermiso");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("NombreEmpleado");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("ApellidoEmpleado");

                    b.Property<long>("TypeId")
                        .HasColumnType("bigint")
                        .HasColumnName("TipoPermiso");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("Permisos", "dbo");
                });

            modelBuilder.Entity("N5Challenge.Domain.Entities.TypeEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("Descripcion");

                    b.HasKey("Id");

                    b.ToTable("TipoPermisos", "dbo");
                });

            modelBuilder.Entity("N5Challenge.Domain.Entities.PermissionsEntity", b =>
                {
                    b.HasOne("N5Challenge.Domain.Entities.TypeEntity", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type");
                });
#pragma warning restore 612, 618
        }
    }
}