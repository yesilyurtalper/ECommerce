﻿// <auto-generated />
using System;
using ECommerce.ItemService.Infra.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ECommerce.ItemService.Infrastructure.Migrations
{
    [DbContext(typeof(ItemAPIDbContext))]
    partial class ItemAPIDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ECommerce.ItemService.Domain.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "admin",
                            DateCreated = new DateTime(2023, 6, 20, 20, 0, 35, 817, DateTimeKind.Local).AddTicks(4826),
                            DateModified = new DateTime(2023, 6, 20, 20, 0, 35, 817, DateTimeKind.Local).AddTicks(4834),
                            Description = "BraA",
                            ModifiedBy = "admin",
                            Name = "BraA"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "admin",
                            DateCreated = new DateTime(2023, 6, 20, 20, 0, 35, 817, DateTimeKind.Local).AddTicks(4836),
                            DateModified = new DateTime(2023, 6, 20, 20, 0, 35, 817, DateTimeKind.Local).AddTicks(4836),
                            Description = "BraB",
                            ModifiedBy = "admin",
                            Name = "BraB"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "admin",
                            DateCreated = new DateTime(2023, 6, 20, 20, 0, 35, 817, DateTimeKind.Local).AddTicks(4838),
                            DateModified = new DateTime(2023, 6, 20, 20, 0, 35, 817, DateTimeKind.Local).AddTicks(4838),
                            Description = "BraC",
                            ModifiedBy = "admin",
                            Name = "BraC"
                        });
                });

            modelBuilder.Entity("ECommerce.ItemService.Domain.BrandCategory", b =>
                {
                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("BrandId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("BrandCategories");

                    b.HasData(
                        new
                        {
                            BrandId = 1,
                            CategoryId = 1
                        },
                        new
                        {
                            BrandId = 1,
                            CategoryId = 2
                        },
                        new
                        {
                            BrandId = 1,
                            CategoryId = 3
                        },
                        new
                        {
                            BrandId = 2,
                            CategoryId = 3
                        },
                        new
                        {
                            BrandId = 3,
                            CategoryId = 2
                        },
                        new
                        {
                            BrandId = 3,
                            CategoryId = 1
                        });
                });

            modelBuilder.Entity("ECommerce.ItemService.Domain.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "admin",
                            DateCreated = new DateTime(2023, 6, 20, 20, 0, 35, 817, DateTimeKind.Local).AddTicks(5008),
                            DateModified = new DateTime(2023, 6, 20, 20, 0, 35, 817, DateTimeKind.Local).AddTicks(5009),
                            Description = "CatA",
                            ModifiedBy = "admin",
                            Name = "CatA"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "admin",
                            DateCreated = new DateTime(2023, 6, 20, 20, 0, 35, 817, DateTimeKind.Local).AddTicks(5010),
                            DateModified = new DateTime(2023, 6, 20, 20, 0, 35, 817, DateTimeKind.Local).AddTicks(5010),
                            Description = "CatB",
                            ModifiedBy = "admin",
                            Name = "CatB"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "admin",
                            DateCreated = new DateTime(2023, 6, 20, 20, 0, 35, 817, DateTimeKind.Local).AddTicks(5011),
                            DateModified = new DateTime(2023, 6, 20, 20, 0, 35, 817, DateTimeKind.Local).AddTicks(5012),
                            Description = "CatC",
                            ModifiedBy = "admin",
                            Name = "CatC"
                        });
                });

            modelBuilder.Entity("ECommerce.ItemService.Domain.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            CategoryId = 1,
                            CreatedBy = "admin",
                            DateCreated = new DateTime(2023, 6, 20, 20, 0, 35, 817, DateTimeKind.Local).AddTicks(5240),
                            DateModified = new DateTime(2023, 6, 20, 20, 0, 35, 817, DateTimeKind.Local).AddTicks(5241),
                            Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                            ImageUrl = "https://alperazurestorage.blob.core.windows.net/mango/14.jpg",
                            ModifiedBy = "admin",
                            Name = "ProA",
                            Price = 15.0
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 2,
                            CategoryId = 2,
                            CreatedBy = "admin",
                            DateCreated = new DateTime(2023, 6, 20, 20, 0, 35, 817, DateTimeKind.Local).AddTicks(5245),
                            DateModified = new DateTime(2023, 6, 20, 20, 0, 35, 817, DateTimeKind.Local).AddTicks(5246),
                            Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                            ImageUrl = "https://alperazurestorage.blob.core.windows.net/mango/11.jpg",
                            ModifiedBy = "admin",
                            Name = "ProB",
                            Price = 13.99
                        },
                        new
                        {
                            Id = 3,
                            BrandId = 1,
                            CategoryId = 1,
                            CreatedBy = "admin",
                            DateCreated = new DateTime(2023, 6, 20, 20, 0, 35, 817, DateTimeKind.Local).AddTicks(5248),
                            DateModified = new DateTime(2023, 6, 20, 20, 0, 35, 817, DateTimeKind.Local).AddTicks(5249),
                            Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                            ImageUrl = "https://alperazurestorage.blob.core.windows.net/mango/12.jpg",
                            ModifiedBy = "admin",
                            Name = "ProC",
                            Price = 10.99
                        },
                        new
                        {
                            Id = 4,
                            BrandId = 3,
                            CategoryId = 3,
                            CreatedBy = "admin",
                            DateCreated = new DateTime(2023, 6, 20, 20, 0, 35, 817, DateTimeKind.Local).AddTicks(5251),
                            DateModified = new DateTime(2023, 6, 20, 20, 0, 35, 817, DateTimeKind.Local).AddTicks(5252),
                            Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                            ImageUrl = "https://alperazurestorage.blob.core.windows.net/mango/13.jpg",
                            ModifiedBy = "admin",
                            Name = "Pro4",
                            Price = 15.0
                        });
                });

            modelBuilder.Entity("ECommerce.ItemService.Domain.BrandCategory", b =>
                {
                    b.HasOne("ECommerce.ItemService.Domain.Brand", "Brand")
                        .WithMany("BrandCategories")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECommerce.ItemService.Domain.Category", "Category")
                        .WithMany("BrandCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ECommerce.ItemService.Domain.Product", b =>
                {
                    b.HasOne("ECommerce.ItemService.Domain.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECommerce.ItemService.Domain.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ECommerce.ItemService.Domain.Brand", b =>
                {
                    b.Navigation("BrandCategories");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("ECommerce.ItemService.Domain.Category", b =>
                {
                    b.Navigation("BrandCategories");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
