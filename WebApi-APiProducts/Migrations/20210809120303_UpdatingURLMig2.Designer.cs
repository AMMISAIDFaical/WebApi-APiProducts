﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi_APiProducts.Context;

namespace WebApi_APiProducts.Migrations
{
    [DbContext(typeof(ProductApiContext))]
    [Migration("20210809120303_UpdatingURLMig2")]
    partial class UpdatingURLMig2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApi_APiProducts.Entities.ContributereEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("OwnerEntityId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OwnerEntityId");

                    b.ToTable("Contributeres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "faicalammisaid2000@gmail.com",
                            OwnerEntityId = 3,
                            Password = "0123azerty"
                        },
                        new
                        {
                            Id = 2,
                            Email = "slumerican@oulook.com",
                            OwnerEntityId = 2,
                            Password = "mudmouth21"
                        },
                        new
                        {
                            Id = 3,
                            Email = "facebook@oulook.com",
                            OwnerEntityId = 1,
                            Password = "facebook21"
                        });
                });

            modelBuilder.Entity("WebApi_APiProducts.Entities.OwnersEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Owners");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin1@gmail.com",
                            Password = "admin1234"
                        },
                        new
                        {
                            Id = 2,
                            Email = "admin2@oulook.com",
                            Password = "admin9876"
                        },
                        new
                        {
                            Id = 3,
                            Email = "admin3@oulook.com",
                            Password = "admin5544"
                        });
                });

            modelBuilder.Entity("WebApi_APiProducts.Entities.ProductEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContributerId")
                        .HasColumnType("int");

                    b.Property<string>("LinkApi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkDoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContributerId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ContributerId = 1,
                            LinkApi = "www.facebookApi.com",
                            LinkDoc = "www.facebookApi-doc.com",
                            Name = "FacebookAPI",
                            Status = "active"
                        },
                        new
                        {
                            Id = 2,
                            ContributerId = 2,
                            LinkApi = "www.GoogleMapsAPI.com",
                            LinkDoc = "www.GoogleMapsAPI-doc.com",
                            Name = "GoogleMapsAPI",
                            Status = "paused"
                        },
                        new
                        {
                            Id = 3,
                            ContributerId = 3,
                            LinkApi = "www.YoutubeAPI.com",
                            LinkDoc = "www.YoutubeAPI-doc.com",
                            Name = "YoutubeAPI",
                            Status = "active"
                        });
                });

            modelBuilder.Entity("WebApi_APiProducts.Entities.ContributereEntity", b =>
                {
                    b.HasOne("WebApi_APiProducts.Entities.OwnersEntity", "OwnerEntity")
                        .WithMany()
                        .HasForeignKey("OwnerEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApi_APiProducts.Entities.ProductEntity", b =>
                {
                    b.HasOne("WebApi_APiProducts.Entities.ContributereEntity", "ContributerEntity")
                        .WithMany()
                        .HasForeignKey("ContributerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
