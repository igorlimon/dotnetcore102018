﻿// <auto-generated />
using System;
using AgileHub102018;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AgileHub102018.Migrations
{
    [DbContext(typeof(AgileHubContext))]
    [Migration("20181028132310_AddDogsAndAddresses")]
    partial class AddDogsAndAddresses
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AgileHub102018.Entities.AddressEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("AgileHub102018.Entities.DogEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDay");

                    b.Property<string>("CreditCard");

                    b.Property<long?>("DogAddressId");

                    b.Property<string>("Email");

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("DogAddressId");

                    b.ToTable("Dogs");
                });

            modelBuilder.Entity("AgileHub102018.Entities.DogEntity", b =>
                {
                    b.HasOne("AgileHub102018.Entities.AddressEntity", "DogAddress")
                        .WithMany()
                        .HasForeignKey("DogAddressId");
                });
#pragma warning restore 612, 618
        }
    }
}
