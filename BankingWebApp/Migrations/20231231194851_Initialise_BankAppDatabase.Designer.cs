﻿// <auto-generated />
using System;
using BankingWebApp.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BankingWebApp.Migrations
{
    [DbContext(typeof(BankAppDbContext))]
    [Migration("20231231194851_Initialise_BankAppDatabase")]
    partial class Initialise_BankAppDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BankingWebApp.Models.Bank.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"));

                    b.Property<decimal>("Balance")
                        .HasPrecision(15, 3)
                        .HasColumnType("decimal(15,3)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("AccountId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            AccountId = 1,
                            Balance = 52000.00m,
                            CustomerId = 1
                        },
                        new
                        {
                            AccountId = 2,
                            Balance = 91000.00m,
                            CustomerId = 2
                        },
                        new
                        {
                            AccountId = 3,
                            Balance = 157000.00m,
                            CustomerId = 3
                        });
                });

            modelBuilder.Entity("BankingWebApp.Models.Bank.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phonenum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            EmailAddress = "john.gerrad@gmail.com",
                            FirstName = "John",
                            LastName = "Gerrad",
                            Password = "1234",
                            Phonenum = "07705089501"
                        },
                        new
                        {
                            CustomerId = 2,
                            EmailAddress = "pattrick.george@outlook.com",
                            FirstName = "Pattrick",
                            LastName = "George",
                            Password = "5678",
                            Phonenum = "07755589511"
                        },
                        new
                        {
                            CustomerId = 3,
                            EmailAddress = "lilliana.bestie@hotmail.com",
                            FirstName = "Lilliana",
                            LastName = "Johnson",
                            Password = "9101112",
                            Phonenum = "07712312355"
                        });
                });

            modelBuilder.Entity("BankingWebApp.Models.Bank.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionId"));

                    b.Property<decimal>("Amount")
                        .HasPrecision(15, 3)
                        .HasColumnType("decimal(15,3)");

                    b.Property<int?>("ReceiverAccountId")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.Property<int?>("SenderAccountId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.HasKey("TransactionId");

                    b.HasIndex("ReceiverAccountId");

                    b.HasIndex("SenderAccountId");

                    b.ToTable("Transactions");

                    b.HasData(
                        new
                        {
                            TransactionId = 1,
                            Amount = 1000m,
                            ReceiverAccountId = 2,
                            SenderAccountId = 1
                        },
                        new
                        {
                            TransactionId = 2,
                            Amount = 3000m,
                            ReceiverAccountId = 2,
                            SenderAccountId = 1
                        },
                        new
                        {
                            TransactionId = 3,
                            Amount = 5000m,
                            ReceiverAccountId = 3,
                            SenderAccountId = 1
                        },
                        new
                        {
                            TransactionId = 4,
                            Amount = 6000m,
                            ReceiverAccountId = 1,
                            SenderAccountId = 2
                        },
                        new
                        {
                            TransactionId = 5,
                            Amount = 15000m,
                            ReceiverAccountId = 3,
                            SenderAccountId = 2
                        },
                        new
                        {
                            TransactionId = 6,
                            Amount = 5000m,
                            ReceiverAccountId = 1,
                            SenderAccountId = 3
                        },
                        new
                        {
                            TransactionId = 7,
                            Amount = 8000m,
                            ReceiverAccountId = 2,
                            SenderAccountId = 3
                        });
                });

            modelBuilder.Entity("BankingWebApp.Models.Bank.Account", b =>
                {
                    b.HasOne("BankingWebApp.Models.Bank.Customer", "Customer")
                        .WithMany("Accounts")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("BankingWebApp.Models.Bank.Transaction", b =>
                {
                    b.HasOne("BankingWebApp.Models.Bank.Account", "Receiver")
                        .WithMany("DebitTransactions")
                        .HasForeignKey("ReceiverAccountId");

                    b.HasOne("BankingWebApp.Models.Bank.Account", "Sender")
                        .WithMany("CreditTransactions")
                        .HasForeignKey("SenderAccountId");

                    b.Navigation("Receiver");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("BankingWebApp.Models.Bank.Account", b =>
                {
                    b.Navigation("CreditTransactions");

                    b.Navigation("DebitTransactions");
                });

            modelBuilder.Entity("BankingWebApp.Models.Bank.Customer", b =>
                {
                    b.Navigation("Accounts");
                });
#pragma warning restore 612, 618
        }
    }
}
