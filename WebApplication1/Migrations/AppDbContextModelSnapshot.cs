﻿// <auto-generated />
using System;
using ApiGTT.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ApiGTT.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ApiGTT.Models.Certificates", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("alias");

                    b.Property<DateTime>("caducidad");

                    b.Property<string>("cifrado");

                    b.Property<string>("contacto_renovacion");

                    b.Property<bool>("eliminado");

                    b.Property<string>("entidad_emisora");

                    b.Property<string>("id_orga");

                    b.Property<string>("integration_list");

                    b.Property<string>("nombre_archivo");

                    b.Property<string>("nombre_cliente");

                    b.Property<string>("num_serie");

                    b.Property<string>("observaciones");

                    b.Property<string>("password");

                    b.Property<string>("repositorio_url");

                    b.Property<string>("subject");

                    b.HasKey("id");

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("ApiGTT.Models.Jira", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("component");

                    b.Property<string>("description");

                    b.Property<string>("issueType");

                    b.Property<string>("password");

                    b.Property<string>("project");

                    b.Property<string>("url");

                    b.Property<long>("user_id");

                    b.Property<string>("username");

                    b.HasKey("id");

                    b.ToTable("Jira");
                });

            modelBuilder.Entity("ApiGTT.Models.Users", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("email");

                    b.Property<string>("password");

                    b.Property<int>("role");

                    b.Property<string>("username");

                    b.HasKey("id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
