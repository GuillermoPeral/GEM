﻿// <auto-generated />
using System;
using GEM.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GEM.Web.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200421180727_Segunda")]
    partial class Segunda
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GEM.Web.Data.Entities.BodyType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(9);

                    b.HasKey("Id");

                    b.ToTable("BodyTypes");
                });

            modelBuilder.Entity("GEM.Web.Data.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BodyTypeId");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<int?>("GenderId");

                    b.Property<double>("Height");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<double>("Width");

                    b.HasKey("Id");

                    b.HasIndex("BodyTypeId");

                    b.HasIndex("GenderId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("GEM.Web.Data.Entities.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(9);

                    b.HasKey("Id");

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("GEM.Web.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<int?>("GenderId");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GEM.Web.Data.Entities.Workout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ab")
                        .IsRequired();

                    b.Property<string>("Arm")
                        .IsRequired();

                    b.Property<string>("Back")
                        .IsRequired();

                    b.Property<string>("Cardio")
                        .IsRequired();

                    b.Property<string>("Chest")
                        .IsRequired();

                    b.Property<string>("Leg")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Workouts");
                });

            modelBuilder.Entity("GEM.Web.Data.Entities.Client", b =>
                {
                    b.HasOne("GEM.Web.Data.Entities.BodyType", "BodyType")
                        .WithMany("Clients")
                        .HasForeignKey("BodyTypeId");

                    b.HasOne("GEM.Web.Data.Entities.Gender", "Gender")
                        .WithMany("Clients")
                        .HasForeignKey("GenderId");
                });

            modelBuilder.Entity("GEM.Web.Data.Entities.User", b =>
                {
                    b.HasOne("GEM.Web.Data.Entities.Gender", "Gender")
                        .WithMany("Users")
                        .HasForeignKey("GenderId");
                });
#pragma warning restore 612, 618
        }
    }
}
