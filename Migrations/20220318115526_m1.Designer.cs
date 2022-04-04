﻿// <auto-generated />
using System;
using Dropdown.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dropdown.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20220318115526_m1")]
    partial class m1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dropdown.Models.Country", b =>
                {
                    b.Property<int>("c_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("c_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("c_id");

                    b.ToTable("countries");
                });

            modelBuilder.Entity("Dropdown.Models.Emp1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Age")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("First_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sur_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("emp1s");
                });

            modelBuilder.Entity("Dropdown.Models.State", b =>
                {
                    b.Property<int>("s_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("countryc_id")
                        .HasColumnType("int");

                    b.Property<string>("s_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("s_id");

                    b.HasIndex("countryc_id");

                    b.ToTable("states");
                });

            modelBuilder.Entity("Dropdown.Models.State", b =>
                {
                    b.HasOne("Dropdown.Models.Country", "country")
                        .WithMany()
                        .HasForeignKey("countryc_id");

                    b.Navigation("country");
                });
#pragma warning restore 612, 618
        }
    }
}
