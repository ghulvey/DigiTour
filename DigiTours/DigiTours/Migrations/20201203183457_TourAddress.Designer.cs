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
    [Migration("20201203183457_TourAddress")]
    partial class TourAddress
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int?>("Type");

                    b.Property<string>("User");

                    b.Property<int>("ZipCode");

                    b.HasKey("ID");

                    b.ToTable("Tour");
                });
#pragma warning restore 612, 618
        }
    }
}
