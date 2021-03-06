﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Poc.GraphQL.Api.Data;

namespace Poc.GraphQL.Api.Data.Migrations
{
    [DbContext(typeof(IAGContext))]
    [Migration("20200618092051_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Poc.GraphQL.Api.Data.Entities.Airline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<string>("Description")
                        .HasMaxLength(100);

                    b.Property<string>("LogoFileName");

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.Property<int>("NumberOfPlanes");

                    b.Property<int>("Rating");

                    b.HasKey("Id");

                    b.ToTable("Airlines");
                });

            modelBuilder.Entity("Poc.GraphQL.Api.Data.Entities.AirlineReview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AirlineId");

                    b.Property<string>("Review");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("AirlineId");

                    b.ToTable("AirlineReviews");
                });

            modelBuilder.Entity("Poc.GraphQL.Api.Data.Entities.AirlineReview", b =>
                {
                    b.HasOne("Poc.GraphQL.Api.Data.Entities.Airline", "Airline")
                        .WithMany("AirlineReviews")
                        .HasForeignKey("AirlineId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
