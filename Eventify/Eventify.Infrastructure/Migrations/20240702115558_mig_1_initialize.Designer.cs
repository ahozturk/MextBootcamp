﻿// <auto-generated />
using System;
using Eventify.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Eventify.Infrastructure.Migrations
{
    [DbContext(typeof(EventifyDbContext))]
    [Migration("20240702115558_mig_1_initialize")]
    partial class mig_1_initialize
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Eventify.Domain.Event", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8e90c53b-bf21-4f3f-88ad-dc23c99c5137"),
                            CreatedAt = new DateTime(2024, 7, 2, 11, 55, 58, 9, DateTimeKind.Utc).AddTicks(4440),
                            Date = new DateTimeOffset(new DateTime(2024, 7, 3, 11, 55, 58, 9, DateTimeKind.Unspecified).AddTicks(4440), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Event 1 Description",
                            Title = "Event 1",
                            Type = 2
                        });
                });

            modelBuilder.Entity("Eventify.Domain.Event", b =>
                {
                    b.OwnsOne("Eventify.Domain.Address", "Location", b1 =>
                        {
                            b1.Property<Guid>("EventId")
                                .HasColumnType("uuid");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("District")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("No")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("Note")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("PostalCode")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.HasKey("EventId");

                            b1.ToTable("Events");

                            b1.WithOwner()
                                .HasForeignKey("EventId");

                            b1.HasData(
                                new
                                {
                                    EventId = new Guid("8e90c53b-bf21-4f3f-88ad-dc23c99c5137"),
                                    City = "City 1",
                                    District = "District 1",
                                    No = "12",
                                    Note = "Near by Stadium",
                                    PostalCode = "12345",
                                    Street = "Street 1"
                                });
                        });

                    b.Navigation("Location")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
