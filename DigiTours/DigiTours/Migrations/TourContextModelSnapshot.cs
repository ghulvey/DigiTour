﻿// <auto-generated />
using DigiTours.Data;
using DigiTours.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DigiTours.Migrations
{
    [DbContext(typeof(TourContext))]
    partial class TourContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DigiTours.Models.Tour", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Location");

                    b.Property<string>("Requests");

                    b.Property<int?>("State");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("StreetAddress2");

                    b.Property<int?>("Type");

                    b.Property<string>("User");

                    b.Property<int>("ZipCode");

                    b.HasKey("ID");

                    b.ToTable("Tour");
                });

            modelBuilder.Entity("DigiTours.Models.TourBid", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Commission");

                    b.Property<double>("Cost");

                    b.Property<DateTime>("Delivery");

                    b.Property<DateTime>("Expiration");

                    b.Property<string>("Notes");

                    b.Property<string>("User");

                    b.HasKey("ID");

                    b.ToTable("TourBid");
                });
#pragma warning restore 612, 618
        }
    }
}
