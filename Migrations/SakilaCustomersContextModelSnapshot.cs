﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SakilaCustomers.Data;

namespace SakilaCustomers.Migrations
{
    [DbContext(typeof(SakilaCustomersContext))]
    partial class SakilaCustomersContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SakilaCustomers.Models.Customer", b =>
                {
                    b.Property<int?>("customer_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("active");

                    b.Property<int>("address_id");

                    b.Property<DateTime>("create_date");

                    b.Property<string>("email");

                    b.Property<string>("first_name");

                    b.Property<string>("last_name");

                    b.Property<DateTime>("last_update");

                    b.Property<int>("store_id");

                    b.HasKey("customer_id");

                    b.ToTable("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}
