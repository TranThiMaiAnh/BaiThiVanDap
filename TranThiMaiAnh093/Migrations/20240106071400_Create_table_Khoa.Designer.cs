﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TranThiMaiAnh093.Data;

#nullable disable

namespace TranThiMaiAnh093.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240106071400_Create_table_Khoa")]
    partial class Create_table_Khoa
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("TranThiMaiAnh093.Khoa", b =>
                {
                    b.Property<string>("MaKhoa")
                        .HasColumnType("TEXT");

                    b.Property<string>("Hovaten")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TenKhoa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaKhoa");

                    b.HasIndex("Hovaten");

                    b.ToTable("Khoa");
                });

            modelBuilder.Entity("TranThiMaiAnh093.TranThiMaiAnh", b =>
                {
                    b.Property<string>("Hovaten")
                        .HasColumnType("TEXT");

                    b.Property<float>("Diem")
                        .HasColumnType("REAL");

                    b.Property<int>("Tuoi")
                        .HasColumnType("INTEGER");

                    b.HasKey("Hovaten");

                    b.ToTable("TranThiMaiAnh");
                });

            modelBuilder.Entity("TranThiMaiAnh093.Khoa", b =>
                {
                    b.HasOne("TranThiMaiAnh093.TranThiMaiAnh", "Hoten")
                        .WithMany()
                        .HasForeignKey("Hovaten")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hoten");
                });
#pragma warning restore 612, 618
        }
    }
}
