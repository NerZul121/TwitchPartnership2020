﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TwitchPartnership2020.Data;

namespace TwitchPartnership2020.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200202153920_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TwitchPartnership2020.Models.Advertiser", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthID")
                        .HasColumnType("int");

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contacts")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PurseID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Advertiser");
                });

            modelBuilder.Entity("TwitchPartnership2020.Models.Appeal", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Change_Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Create_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<int>("StreamID")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int>("ViewID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Appeal");
                });

            modelBuilder.Entity("TwitchPartnership2020.Models.Auth", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Type")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Auth");
                });

            modelBuilder.Entity("TwitchPartnership2020.Models.Banner", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdvertiserID")
                        .HasColumnType("int");

                    b.Property<int?>("Delay")
                        .HasColumnType("int");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Whitelist")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AdvertiserID");

                    b.ToTable("Banner");
                });

            modelBuilder.Entity("TwitchPartnership2020.Models.Content", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdvertiserID")
                        .HasColumnType("int");

                    b.Property<int?>("BannerID")
                        .HasColumnType("int");

                    b.Property<int>("Budget")
                        .HasColumnType("int");

                    b.Property<float>("CostPerClick")
                        .HasColumnType("real");

                    b.Property<float>("CostPerTrueView")
                        .HasColumnType("real");

                    b.Property<float>("CostPerView")
                        .HasColumnType("real");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Platforms")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ranks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsedBudget")
                        .HasColumnType("int");

                    b.Property<int?>("Whitelist")
                        .HasColumnType("int");

                    b.Property<int?>("WhitelistPlatform")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BannerID");

                    b.ToTable("Content");
                });

            modelBuilder.Entity("TwitchPartnership2020.Models.Operation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PurseID")
                        .HasColumnType("int");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<int>("Summ")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Operation");
                });

            modelBuilder.Entity("TwitchPartnership2020.Models.Purse", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CurrentBalance")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Purse");
                });

            modelBuilder.Entity("TwitchPartnership2020.Models.Stream", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("ChangeDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<int>("StreamerID")
                        .HasColumnType("int");

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Stream");
                });

            modelBuilder.Entity("TwitchPartnership2020.Models.Streamer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthID")
                        .HasColumnType("int");

                    b.Property<int>("BannerID")
                        .HasColumnType("int");

                    b.Property<int?>("ContentID")
                        .HasColumnType("int");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PurseID")
                        .HasColumnType("int");

                    b.Property<string>("TwitchURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ContentID");

                    b.ToTable("Streamers");
                });

            modelBuilder.Entity("TwitchPartnership2020.Models.Thematics", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descrition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StreamID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("StreamID");

                    b.ToTable("Thematic");
                });

            modelBuilder.Entity("TwitchPartnership2020.Models.View", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthViewers")
                        .HasColumnType("int");

                    b.Property<int>("BannerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ChangeDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Platform")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<int>("StreamID")
                        .HasColumnType("int");

                    b.Property<int>("Viewers")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("View");
                });

            modelBuilder.Entity("TwitchPartnership2020.Models.Banner", b =>
                {
                    b.HasOne("TwitchPartnership2020.Models.Advertiser", null)
                        .WithMany("Banners")
                        .HasForeignKey("AdvertiserID");
                });

            modelBuilder.Entity("TwitchPartnership2020.Models.Content", b =>
                {
                    b.HasOne("TwitchPartnership2020.Models.Banner", null)
                        .WithMany("Contents")
                        .HasForeignKey("BannerID");
                });

            modelBuilder.Entity("TwitchPartnership2020.Models.Streamer", b =>
                {
                    b.HasOne("TwitchPartnership2020.Models.Content", null)
                        .WithMany("Streamers")
                        .HasForeignKey("ContentID");
                });

            modelBuilder.Entity("TwitchPartnership2020.Models.Thematics", b =>
                {
                    b.HasOne("TwitchPartnership2020.Models.Stream", null)
                        .WithMany("Thematics")
                        .HasForeignKey("StreamID");
                });
#pragma warning restore 612, 618
        }
    }
}
