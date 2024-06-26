﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pimpochki.Infrastructure.Persistence;

#nullable disable

namespace Pimpochki.Infrastructure.Migrations
{
    [DbContext(typeof(PimpochkiDbContext))]
    partial class PimpochkiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Pimpochki.Domain.Entities.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ProductId = 1,
                            Url = "https://www.clearlypayments.com/wp-content/uploads/2020/05/Ingenico-Desk-5000-Clearly-Payments.png"
                        },
                        new
                        {
                            Id = 2,
                            ProductId = 1,
                            Url = "https://www.clearlypayments.com/wp-content/uploads/2020/05/desk_5000_470_470px_mobile.png"
                        },
                        new
                        {
                            Id = 3,
                            ProductId = 2,
                            Url = "https://www.clearlypayments.com/wp-content/uploads/2020/05/ingenico-move-5000-0.jpg"
                        },
                        new
                        {
                            Id = 4,
                            ProductId = 2,
                            Url = "https://www.clearlypayments.com/wp-content/uploads/2020/05/ingenico-move-5000-contactless.jpg"
                        },
                        new
                        {
                            Id = 5,
                            ProductId = 3,
                            Url = "https://www.clearlypayments.com/wp-content/uploads/2022/06/newland-n910-Clearly-Payments-768x576.jpg"
                        },
                        new
                        {
                            Id = 6,
                            ProductId = 3,
                            Url = "https://www.clearlypayments.com/wp-content/uploads/2021/09/newland-n910-clearly-payments-1-768x432.jpg"
                        },
                        new
                        {
                            Id = 7,
                            ProductId = 4,
                            Url = "https://www.clearlypayments.com/wp-content/uploads/2020/02/Frame-16.png"
                        },
                        new
                        {
                            Id = 8,
                            ProductId = 4,
                            Url = "https://www.clearlypayments.com/wp-content/uploads/2020/07/image2-poynt-5-768x461.jpg"
                        },
                        new
                        {
                            Id = 9,
                            ProductId = 5,
                            Url = "https://www.clearlypayments.com/wp-content/uploads/2022/12/Clover-System-Clearly-Payments-1024x439.png"
                        },
                        new
                        {
                            Id = 10,
                            ProductId = 5,
                            Url = "https://www.clearlypayments.com/wp-content/uploads/2022/12/clover-station-clearly-payments-1024x704.jpg"
                        },
                        new
                        {
                            Id = 11,
                            ProductId = 6,
                            Url = "http://genie2go.com/demo/genie2go/wp-content/uploads/2017/04/s900d.jpg"
                        },
                        new
                        {
                            Id = 12,
                            ProductId = 6,
                            Url = "http://genie2go.com/demo/genie2go/wp-content/uploads/2017/04/s900h.jpg"
                        },
                        new
                        {
                            Id = 13,
                            ProductId = 7,
                            Url = "https://content2.rozetka.com.ua/goods/images/big/361193035.jpg"
                        },
                        new
                        {
                            Id = 14,
                            ProductId = 7,
                            Url = "https://content2.rozetka.com.ua/goods/images/big/361193039.jpg"
                        },
                        new
                        {
                            Id = 15,
                            ProductId = 8,
                            Url = "https://content2.rozetka.com.ua/goods/images/big/361193068.jpg"
                        },
                        new
                        {
                            Id = 16,
                            ProductId = 8,
                            Url = "https://content.rozetka.com.ua/goods/images/big/361193074.jpg"
                        },
                        new
                        {
                            Id = 17,
                            ProductId = 9,
                            Url = "https://content2.rozetka.com.ua/goods/images/big/14942991.jpg"
                        },
                        new
                        {
                            Id = 18,
                            ProductId = 9,
                            Url = "https://content.rozetka.com.ua/goods/images/big/14943024.jpg"
                        },
                        new
                        {
                            Id = 19,
                            ProductId = 10,
                            Url = "http://genie2go.com/demo/genie2go/wp-content/uploads/2017/05/s920.jpg"
                        },
                        new
                        {
                            Id = 20,
                            ProductId = 10,
                            Url = "https://allstarterminals.com/cdn/shop/products/pax-s920-4g-mobile-payment-terminal-347683_1800x1800.webp?v=1696879189"
                        });
                });

            modelBuilder.Entity("Pimpochki.Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Pimpochki.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Accept credit card and debit card payments with the Ingenico Desk 5000 terminal. It’s a perfect countertop payment terminal for offices, retail, restaurants, and other fixed physical locations.",
                            Name = "Ingenico Desk 5000 Payment Terminal",
                            Price = 499.99000000000001,
                            Quantity = 15
                        },
                        new
                        {
                            Id = 2,
                            Description = "Accept credit card and debit card payments with the Ingenico Move 5000 credit card machine. It has wireless capabilities to process payments from anywhere.",
                            Name = "Ingenico Move 5000 Payment Terminal",
                            Price = 299.99000000000001,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 3,
                            Description = "The Newland N910 smart payment terminal is compact with wireless 4G Support, wifi connectivity, fast printing, a large printer paper roll. It’s ideal for retail and restaurants.",
                            Name = "Newland N910 Credit Card Terminal",
                            Price = 99.989999999999995,
                            Quantity = 20
                        },
                        new
                        {
                            Id = 4,
                            Description = "Accept credit card and debit card payments with the Poynt payment terminal. It’s a perfect countertop payment terminal for offices, retail, restaurants, and other physical locations.",
                            Name = "Poynt Smart Point of Sale System",
                            Price = 19.989999999999998,
                            Quantity = 50
                        },
                        new
                        {
                            Id = 5,
                            Description = "Clover is a complete point-of-sale system to take payments, track sales, manage employees, and run your business. Built for table and quick-serve restaurants, retail, or service businesses.",
                            Name = "Clover Point-of-Sale Solutions",
                            Price = 199.99000000000001,
                            Quantity = 8
                        },
                        new
                        {
                            Id = 6,
                            Description = "PAX S900 is the world most innovative mobile payment terminal powered by a secure operating platform, featuring extended life battery, state of the art colour touch screen and GPRS, WiFi and 3G connectivity. It is the ideal solution for high-end retail and hospitality.",
                            Name = "S900 Mobile Payment Terminal",
                            Price = 129.99000000000001,
                            Quantity = 12
                        },
                        new
                        {
                            Id = 7,
                            Description = "The card reader supports all standard formats of contact smart cards, chip cards and other contact cards, including payment cards or contact electronic identification cards *. The reader is compatible with most national eID (electronic ID) programs.",
                            Name = "AxagonCRE-SM2 ",
                            Price = 149.99000000000001,
                            Quantity = 18
                        },
                        new
                        {
                            Id = 8,
                            Description = "Do you manage a transport company and want to provide your employees with comfortable work thanks to tachographs? Is tracking employee hours a priority for you? If the answer is yes, our chip card scanner is the perfect solution for you.",
                            Name = "Qoltec",
                            Price = 49.990000000000002,
                            Quantity = 25
                        },
                        new
                        {
                            Id = 9,
                            Description = "The Zoweetek USB Smart Card Scanner is a desktop&nbsp;device designed to read chip cards, EMV 4.1 smart cards and 4404, 4428, 4442 and I2C memory cards.&nbsp;",
                            Name = "Zoweetek USB",
                            Price = 299.99000000000001,
                            Quantity = 5
                        },
                        new
                        {
                            Id = 10,
                            Description = "The PAX S920 is the world sleekest compact mobile point of sale terminal, packed with the most complete range of payment industry certifications ever and is manufactured to the highest of global standards using state-of-the-art technology and high-end materials.",
                            Name = "S920 Mobile Payment Terminal",
                            Price = 999.99000000000001,
                            Quantity = 3
                        });
                });

            modelBuilder.Entity("Pimpochki.Domain.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("UserRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserRole = "Customer"
                        },
                        new
                        {
                            Id = 2,
                            UserRole = "Admin"
                        });
                });

            modelBuilder.Entity("Pimpochki.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Pimpochki.Domain.Entities.Image", b =>
                {
                    b.HasOne("Pimpochki.Domain.Entities.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Pimpochki.Domain.Entities.Order", b =>
                {
                    b.HasOne("Pimpochki.Domain.Entities.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pimpochki.Domain.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Pimpochki.Domain.Entities.User", b =>
                {
                    b.HasOne("Pimpochki.Domain.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Pimpochki.Domain.Entities.Product", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Pimpochki.Domain.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Pimpochki.Domain.Entities.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
