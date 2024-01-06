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
    [Migration("20240106065352_Create_table_TranThiMaiAnh")]
    partial class Create_table_TranThiMaiAnh
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

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
#pragma warning restore 612, 618
        }
    }
}
