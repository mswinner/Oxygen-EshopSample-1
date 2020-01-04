﻿// <auto-generated />
using System;
using Goods.Infrastructure.EfDataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Goods.Infrastructure.Migrations
{
    [DbContext(typeof(GoodsContext))]
    partial class GoodsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Goods.Infrastructure.PersistenceObject.Goods", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<Guid>("CreateUserId");

                    b.Property<string>("ImageId");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsUpshelf");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock");

                    b.Property<DateTime?>("UpshelfTime");

                    b.HasKey("Id");

                    b.ToTable("Goods");
                });
#pragma warning restore 612, 618
        }
    }
}