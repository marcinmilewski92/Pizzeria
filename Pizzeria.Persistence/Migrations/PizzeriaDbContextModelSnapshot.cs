﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pizzeria.Persistence;

#nullable disable

namespace Pizzeria.Persistence.Migrations
{
    [DbContext(typeof(PizzeriaDbContext))]
    partial class PizzeriaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AdditionalIngredientSinglePizzaOrder", b =>
                {
                    b.Property<int>("AdditionalIngredientsAdditionalIngredientId")
                        .HasColumnType("int");

                    b.Property<int>("SinglePizzaOrdersSinglePizzaOrderId")
                        .HasColumnType("int");

                    b.HasKey("AdditionalIngredientsAdditionalIngredientId", "SinglePizzaOrdersSinglePizzaOrderId");

                    b.HasIndex("SinglePizzaOrdersSinglePizzaOrderId");

                    b.ToTable("AdditionalIngredientSinglePizzaOrder");
                });

            modelBuilder.Entity("BaseIngredientPizza", b =>
                {
                    b.Property<int>("PizzaId")
                        .HasColumnType("int");

                    b.Property<int>("BaseIngredientId")
                        .HasColumnType("int");

                    b.HasKey("PizzaId", "BaseIngredientId");

                    b.HasIndex("BaseIngredientId");

                    b.ToTable("BaseIngredientPizza");

                    b.HasData(
                        new
                        {
                            PizzaId = 1,
                            BaseIngredientId = 1
                        },
                        new
                        {
                            PizzaId = 1,
                            BaseIngredientId = 2
                        },
                        new
                        {
                            PizzaId = 2,
                            BaseIngredientId = 1
                        },
                        new
                        {
                            PizzaId = 2,
                            BaseIngredientId = 2
                        },
                        new
                        {
                            PizzaId = 2,
                            BaseIngredientId = 6
                        },
                        new
                        {
                            PizzaId = 2,
                            BaseIngredientId = 8
                        },
                        new
                        {
                            PizzaId = 2,
                            BaseIngredientId = 10
                        },
                        new
                        {
                            PizzaId = 3,
                            BaseIngredientId = 1
                        },
                        new
                        {
                            PizzaId = 3,
                            BaseIngredientId = 2
                        },
                        new
                        {
                            PizzaId = 3,
                            BaseIngredientId = 3
                        },
                        new
                        {
                            PizzaId = 3,
                            BaseIngredientId = 11
                        },
                        new
                        {
                            PizzaId = 3,
                            BaseIngredientId = 12
                        },
                        new
                        {
                            PizzaId = 3,
                            BaseIngredientId = 13
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "b1f97c6d-6b0f-4f27-b6c7-aa9a27ed8b0d",
                            ConcurrencyStamp = "7c2792da-e8e4-426d-858a-7204c4e77c10",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "5b2d14fc-852b-4e0b-81f9-3ac8393b0637",
                            ConcurrencyStamp = "054f2dd7-1120-4d02-8a87-ac338bec5318",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "b1f97c6d-6b0f-4f27-b6c7-aa9a27ed8b0e",
                            RoleId = "b1f97c6d-6b0f-4f27-b6c7-aa9a27ed8b0d"
                        },
                        new
                        {
                            UserId = "5b2d14fc-852b-4e0b-81f9-3ac8393b0638",
                            RoleId = "5b2d14fc-852b-4e0b-81f9-3ac8393b0637"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Pizzeria.Domain.Entities.AdditionalIngredient", b =>
                {
                    b.Property<int>("AdditionalIngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdditionalIngredientId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("AdditionalIngredientId");

                    b.ToTable("AdditionalIngredients");

                    b.HasData(
                        new
                        {
                            AdditionalIngredientId = 1,
                            Name = "Sausage",
                            Price = 3m
                        },
                        new
                        {
                            AdditionalIngredientId = 2,
                            Name = "Bacon",
                            Price = 4m
                        },
                        new
                        {
                            AdditionalIngredientId = 3,
                            Name = "Parsley",
                            Price = 2m
                        });
                });

            modelBuilder.Entity("Pizzeria.Domain.Entities.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"), 1L, 1);

                    b.Property<string>("ApartmentNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HouseNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressId");

                    b.ToTable("Addresses");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Address");
                });

            modelBuilder.Entity("Pizzeria.Domain.Entities.BaseIngredient", b =>
                {
                    b.Property<int>("BaseIngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BaseIngredientId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BaseIngredientId");

                    b.ToTable("BaseIngredients");

                    b.HasData(
                        new
                        {
                            BaseIngredientId = 1,
                            Name = "Tomato sauce"
                        },
                        new
                        {
                            BaseIngredientId = 2,
                            Name = "Mozzarella"
                        },
                        new
                        {
                            BaseIngredientId = 3,
                            Name = "Prosciutto"
                        },
                        new
                        {
                            BaseIngredientId = 4,
                            Name = "Mushrooms"
                        },
                        new
                        {
                            BaseIngredientId = 5,
                            Name = "Basil"
                        },
                        new
                        {
                            BaseIngredientId = 6,
                            Name = "Grana Padano"
                        },
                        new
                        {
                            BaseIngredientId = 7,
                            Name = "Jalapeno"
                        },
                        new
                        {
                            BaseIngredientId = 8,
                            Name = "Cherry tomatoes"
                        },
                        new
                        {
                            BaseIngredientId = 10,
                            Name = "Arugula"
                        },
                        new
                        {
                            BaseIngredientId = 11,
                            Name = "Capers"
                        },
                        new
                        {
                            BaseIngredientId = 12,
                            Name = "Dried tomatoes"
                        },
                        new
                        {
                            BaseIngredientId = 13,
                            Name = "Olives"
                        });
                });

            modelBuilder.Entity("Pizzeria.Domain.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeliveryAddressAddressId")
                        .HasColumnType("int");

                    b.Property<bool>("IsCancelled")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDelivered")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("OrderId");

                    b.HasIndex("DeliveryAddressAddressId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Pizzeria.Domain.Entities.Pizza", b =>
                {
                    b.Property<int>("PizzaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PizzaId"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PizzaId");

                    b.ToTable("Pizzas");

                    b.HasData(
                        new
                        {
                            PizzaId = 1,
                            Description = "Classic Italian pizza.",
                            IsAvailable = true,
                            Name = "Margherita",
                            Price = 25.50m
                        },
                        new
                        {
                            PizzaId = 2,
                            Description = "Delicious pizza with highest queality, fresh ingredients.",
                            IsAvailable = true,
                            Name = "Parma",
                            Price = 28m
                        },
                        new
                        {
                            PizzaId = 3,
                            Description = "Delicious, saulty pizza. Perfect when you are very hungry.",
                            IsAvailable = true,
                            Name = "Capperi",
                            Price = 27.50m
                        });
                });

            modelBuilder.Entity("Pizzeria.Domain.Entities.SinglePizzaOrder", b =>
                {
                    b.Property<int>("SinglePizzaOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SinglePizzaOrderId"), 1L, 1);

                    b.Property<decimal>("CurrentPizzaPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("PizzaId")
                        .HasColumnType("int");

                    b.HasKey("SinglePizzaOrderId");

                    b.HasIndex("OrderId");

                    b.HasIndex("PizzaId");

                    b.ToTable("SinglePizzaOrders");
                });

            modelBuilder.Entity("Pizzeria.Domain.Identity.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "b1f97c6d-6b0f-4f27-b6c7-aa9a27ed8b0e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8816298a-eecc-4828-a3ef-29ae879fc174",
                            Email = "user@pizza.com",
                            EmailConfirmed = false,
                            FirstName = "",
                            LastName = "",
                            LockoutEnabled = false,
                            NormalizedUserName = "USER@PIZZA.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEAtO+NnczwINpeoj1erXPTwTf6NrP8iBDdL/NYj+xiVqnkznu3E2P/gEE+ZnwQoRjA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "45464b65-a2ec-43d6-9e6a-eb631b1f722c",
                            TwoFactorEnabled = false,
                            UserName = "user@pizza.com"
                        },
                        new
                        {
                            Id = "5b2d14fc-852b-4e0b-81f9-3ac8393b0638",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a6d87c60-9bf5-4961-b374-bcf7273acadd",
                            Email = "admin@pizza.com",
                            EmailConfirmed = false,
                            FirstName = "",
                            LastName = "",
                            LockoutEnabled = false,
                            NormalizedUserName = "ADMIN@PIZZA.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEAtO+NnczwINpeoj1erXPTwTf6NrP8iBDdL/NYj+xiVqnkznu3E2P/gEE+ZnwQoRjA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9d3c37b2-d097-4fbc-b8a5-732fae30c06d",
                            TwoFactorEnabled = false,
                            UserName = "admin@pizza.com"
                        });
                });

            modelBuilder.Entity("Pizzeria.Domain.Identity.UserAddress", b =>
                {
                    b.HasBaseType("Pizzeria.Domain.Entities.Address");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.HasDiscriminator().HasValue("UserAddress");

                    b.HasData(
                        new
                        {
                            AddressId = 1,
                            ApartmentNumber = "default",
                            City = "default",
                            HouseNumber = "default",
                            PhoneNumber = "default",
                            PostalCode = "default",
                            StreetName = "default",
                            UserId = "b1f97c6d-6b0f-4f27-b6c7-aa9a27ed8b0e"
                        },
                        new
                        {
                            AddressId = 2,
                            ApartmentNumber = "default",
                            City = "default",
                            HouseNumber = "default",
                            PhoneNumber = "default",
                            PostalCode = "default",
                            StreetName = "default",
                            UserId = "5b2d14fc-852b-4e0b-81f9-3ac8393b0638"
                        });
                });

            modelBuilder.Entity("AdditionalIngredientSinglePizzaOrder", b =>
                {
                    b.HasOne("Pizzeria.Domain.Entities.AdditionalIngredient", null)
                        .WithMany()
                        .HasForeignKey("AdditionalIngredientsAdditionalIngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pizzeria.Domain.Entities.SinglePizzaOrder", null)
                        .WithMany()
                        .HasForeignKey("SinglePizzaOrdersSinglePizzaOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BaseIngredientPizza", b =>
                {
                    b.HasOne("Pizzeria.Domain.Entities.BaseIngredient", null)
                        .WithMany()
                        .HasForeignKey("BaseIngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pizzeria.Domain.Entities.Pizza", null)
                        .WithMany()
                        .HasForeignKey("PizzaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Pizzeria.Domain.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Pizzeria.Domain.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pizzeria.Domain.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Pizzeria.Domain.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Pizzeria.Domain.Entities.Order", b =>
                {
                    b.HasOne("Pizzeria.Domain.Entities.Address", "DeliveryAddress")
                        .WithMany("Orders")
                        .HasForeignKey("DeliveryAddressAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pizzeria.Domain.Identity.User", null)
                        .WithMany("Orders")
                        .HasForeignKey("UserId");

                    b.Navigation("DeliveryAddress");
                });

            modelBuilder.Entity("Pizzeria.Domain.Entities.SinglePizzaOrder", b =>
                {
                    b.HasOne("Pizzeria.Domain.Entities.Order", null)
                        .WithMany("SinglePizzaOrders")
                        .HasForeignKey("OrderId");

                    b.HasOne("Pizzeria.Domain.Entities.Pizza", "Pizza")
                        .WithMany()
                        .HasForeignKey("PizzaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pizza");
                });

            modelBuilder.Entity("Pizzeria.Domain.Identity.UserAddress", b =>
                {
                    b.HasOne("Pizzeria.Domain.Identity.User", null)
                        .WithOne("UserAddress")
                        .HasForeignKey("Pizzeria.Domain.Identity.UserAddress", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Pizzeria.Domain.Entities.Address", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Pizzeria.Domain.Entities.Order", b =>
                {
                    b.Navigation("SinglePizzaOrders");
                });

            modelBuilder.Entity("Pizzeria.Domain.Identity.User", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("UserAddress");
                });
#pragma warning restore 612, 618
        }
    }
}
