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
    [Migration("20240118212225_Changed_CustomerModel_RegistrationDate")]
    partial class Changed_CustomerModel_RegistrationDate
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

                    b.Property<string>("AccountType")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

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
                            AccountType = "Savings",
                            Balance = 66000.00m,
                            CustomerId = 1
                        },
                        new
                        {
                            AccountId = 4,
                            AccountType = "Debit",
                            Balance = 25500.00m,
                            CustomerId = 1
                        },
                        new
                        {
                            AccountId = 2,
                            AccountType = "Debit",
                            Balance = 89500.00m,
                            CustomerId = 2
                        },
                        new
                        {
                            AccountId = 3,
                            AccountType = "Debit",
                            Balance = 144000.00m,
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

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

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
                            Password = "1111",
                            Phonenum = "07705089501",
                            RegistrationDate = new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9524)
                        },
                        new
                        {
                            CustomerId = 2,
                            EmailAddress = "pattrick.george@outlook.com",
                            FirstName = "Pattrick",
                            LastName = "George",
                            Password = "2222",
                            Phonenum = "07755589511",
                            RegistrationDate = new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9596)
                        },
                        new
                        {
                            CustomerId = 3,
                            EmailAddress = "lilliana.bestie@hotmail.com",
                            FirstName = "Lilliana",
                            LastName = "Johnson",
                            Password = "3333",
                            Phonenum = "07712312355",
                            RegistrationDate = new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9599)
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

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

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
                            SenderAccountId = 1,
                            TransactionDate = new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9822)
                        },
                        new
                        {
                            TransactionId = 2,
                            Amount = 3000m,
                            ReceiverAccountId = 2,
                            SenderAccountId = 1,
                            TransactionDate = new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9834)
                        },
                        new
                        {
                            TransactionId = 3,
                            Amount = 5000m,
                            ReceiverAccountId = 3,
                            SenderAccountId = 1,
                            TransactionDate = new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9837)
                        },
                        new
                        {
                            TransactionId = 13,
                            Amount = 6000m,
                            ReceiverAccountId = 4,
                            SenderAccountId = 1,
                            TransactionDate = new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9839)
                        },
                        new
                        {
                            TransactionId = 8,
                            Amount = 2000m,
                            ReceiverAccountId = 3,
                            SenderAccountId = 4,
                            TransactionDate = new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9841)
                        },
                        new
                        {
                            TransactionId = 9,
                            Amount = 1500m,
                            ReceiverAccountId = 2,
                            SenderAccountId = 4,
                            TransactionDate = new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9843)
                        },
                        new
                        {
                            TransactionId = 10,
                            Amount = 5000m,
                            ReceiverAccountId = 1,
                            SenderAccountId = 4,
                            TransactionDate = new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9845)
                        },
                        new
                        {
                            TransactionId = 4,
                            Amount = 6000m,
                            ReceiverAccountId = 1,
                            SenderAccountId = 2,
                            TransactionDate = new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9847)
                        },
                        new
                        {
                            TransactionId = 5,
                            Amount = 15000m,
                            ReceiverAccountId = 3,
                            SenderAccountId = 2,
                            TransactionDate = new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9849)
                        },
                        new
                        {
                            TransactionId = 11,
                            Amount = 3000m,
                            ReceiverAccountId = 4,
                            SenderAccountId = 2,
                            TransactionDate = new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9851)
                        },
                        new
                        {
                            TransactionId = 6,
                            Amount = 5000m,
                            ReceiverAccountId = 1,
                            SenderAccountId = 3,
                            TransactionDate = new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9853)
                        },
                        new
                        {
                            TransactionId = 7,
                            Amount = 8000m,
                            ReceiverAccountId = 2,
                            SenderAccountId = 3,
                            TransactionDate = new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9855)
                        },
                        new
                        {
                            TransactionId = 12,
                            Amount = 15000m,
                            ReceiverAccountId = 1,
                            SenderAccountId = 3,
                            TransactionDate = new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9857)
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
