﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Portal.Models;

namespace Portal.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Portal.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AlumniHomeAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovingTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceLength")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("AdminId");

                    b.HasIndex("UserId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Portal.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("BizUnitAssignedWork")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BizUnitImprovementIdeas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BizUnitInformedMe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BizUnitInvolvedMe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BizUnitOnTheJobTraining")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BizUnitPositiveCulture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Division")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Level")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MyJobClearlyDefined")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MyJobManageableWorkload")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MyJobSkills")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MyJobValuableWorkExp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MyJobWorkLifeHarmony")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MyPDAlign")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MyPDFeedback")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MyPDQualityDiscussion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MyPDWellPrepared")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PMAccessible")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PMAppreciates")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PMRespectsMe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StaffName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("isMyCareerExpectationMet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("isMyCareerSatisfactory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("isMyCareerpromotion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("isMyCompensationMarket")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("isMyCompensationPeers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("isMyCompensationPerf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("isPMResilient")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("isPMRoleModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("isPMSupportive")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Portal.Models.Admin", b =>
                {
                    b.HasOne("Portal.Models.User", "User")
                        .WithMany("Admin")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Portal.Models.User", b =>
                {
                    b.Navigation("Admin");
                });
#pragma warning restore 612, 618
        }
    }
}
