﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(TinhThanhContext))]
    partial class TinhThanhContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApplication1.Models.QuanHuyen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TenQuanHuyen")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ThanhPhoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ThanhPhoId");

                    b.HasIndex("TenQuanHuyen", "ThanhPhoId")
                        .IsUnique();

                    b.ToTable("QuanHuyens");
                });

            modelBuilder.Entity("WebApplication1.Models.ThanhPho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TenThanhPho")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("TenThanhPho")
                        .IsUnique();

                    b.ToTable("ThanhPhos");
                });

            modelBuilder.Entity("WebApplication1.Models.QuanHuyen", b =>
                {
                    b.HasOne("WebApplication1.Models.ThanhPho", "ThanhPho")
                        .WithMany("QuanHuyen")
                        .HasForeignKey("ThanhPhoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ThanhPho");
                });

            modelBuilder.Entity("WebApplication1.Models.ThanhPho", b =>
                {
                    b.Navigation("QuanHuyen");
                });
#pragma warning restore 612, 618
        }
    }
}