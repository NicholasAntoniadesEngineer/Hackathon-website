﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ThePowerRanges.Models;

namespace ThePowerRanges.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20191013004309_YY_1")]
    partial class YY_1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ThePowerRanges.Models.Budget", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Debt");

                    b.Property<int?>("ExpensesId");

                    b.Property<int>("ExpensesTotal");

                    b.Property<int>("Income");

                    b.Property<int>("Month");

                    b.Property<int>("Save");

                    b.Property<int>("TaxPercentage");

                    b.HasKey("Id");

                    b.HasIndex("ExpensesId");

                    b.ToTable("Budget");
                });

            modelBuilder.Entity("ThePowerRanges.Models.ExpenseCollection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("ExpenseCollection");
                });

            modelBuilder.Entity("ThePowerRanges.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountType");

                    b.Property<string>("DateOfBirth");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ThePowerRanges.Models.Budget", b =>
                {
                    b.HasOne("ThePowerRanges.Models.ExpenseCollection", "Expenses")
                        .WithMany()
                        .HasForeignKey("ExpensesId");
                });
#pragma warning restore 612, 618
        }
    }
}
