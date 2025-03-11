﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrjAPILembretes.Context;

#nullable disable

namespace PrjAPILembretes.Migrations
{
    [DbContext(typeof(AppLembretesContext))]
    partial class AppLembretesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PrjAPILembretes.Entities.Lembrete", b =>
                {
                    b.Property<int>("LembreteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CorpoLembrete")
                        .HasColumnType("longtext");

                    b.Property<bool>("StatusLembrete")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("TituloLembrete")
                        .HasColumnType("longtext");

                    b.HasKey("LembreteId");

                    b.ToTable("Lembretes");
                });
#pragma warning restore 612, 618
        }
    }
}
