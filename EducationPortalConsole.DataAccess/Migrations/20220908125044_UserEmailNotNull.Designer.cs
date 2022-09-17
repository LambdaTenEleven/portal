﻿// <auto-generated />
using System;
using EducationPortalConsole.DataAccess.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EducationPortalConsole.DataAccess.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220908125044_UserEmailNotNull")]
    partial class UserEmailNotNull
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.7.22376.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EducationPortalConsole.Core.Entities.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UpdatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("UpdatedById");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("EducationPortalConsole.Core.Entities.JoinEntities.BookAuthorBookMaterial", b =>
                {
                    b.Property<Guid>("BookAuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookMaterialId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BookAuthorId", "BookMaterialId");

                    b.HasIndex("BookMaterialId");

                    b.ToTable("BookAuthorBookMaterial");
                });

            modelBuilder.Entity("EducationPortalConsole.Core.Entities.JoinEntities.CourseMaterial", b =>
                {
                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MaterialId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CourseId", "MaterialId");

                    b.HasIndex("MaterialId");

                    b.ToTable("CourseMaterial");
                });

            modelBuilder.Entity("EducationPortalConsole.Core.Entities.JoinEntities.CourseSkill", b =>
                {
                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SkillId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CourseId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("CourseSkill");
                });

            modelBuilder.Entity("EducationPortalConsole.Core.Entities.Material", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UpdatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("UpdatedById");

                    b.ToTable("Materials");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Material");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("EducationPortalConsole.Core.Entities.Materials.BookAuthor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UpdatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("UpdatedById");

                    b.ToTable("BookAuthor");
                });

            modelBuilder.Entity("EducationPortalConsole.Core.Entities.Progress.CourseProgress", b =>
                {
                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Progress")
                        .HasColumnType("int");

                    b.HasKey("CourseId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("CourseProgresses");
                });

            modelBuilder.Entity("EducationPortalConsole.Core.Entities.Progress.MaterialProgress", b =>
                {
                    b.Property<Guid>("MaterialId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Progress")
                        .HasColumnType("int");

                    b.HasKey("MaterialId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("MaterialProgresses");
                });

            modelBuilder.Entity("EducationPortalConsole.Core.Entities.Progress.SkillProgress", b =>
                {
                    b.Property<Guid>("SkillId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.HasKey("SkillId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("SkillProgresses");
                });

            modelBuilder.Entity("EducationPortalConsole.Core.Entities.Skill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UpdatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("UpdatedById");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("EducationPortalConsole.Core.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHashSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EducationPortalConsole.Core.Entities.Materials.ArticleMaterial", b =>
                {
                    b.HasBaseType("EducationPortalConsole.Core.Entities.Material");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ArticleMaterial");
                });

            modelBuilder.Entity("EducationPortalConsole.Core.Entities.Materials.BookMaterial", b =>
                {
                    b.HasBaseType("EducationPortalConsole.Core.Entities.Material");

                    b.Property<string>("Format")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pages")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("BookMaterial");
                });

            modelBuilder.Entity("EducationPortalConsole.Core.Entities.Materials.VideoMaterial", b =>
                {
                    b.HasBaseType("EducationPortalConsole.Core.Entities.Material");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<string>("Quality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("VideoMaterial");
                });

            modelBuilder.Entity("EducationPortalConsole.Core.Entities.Course", b =>
                {
                    b.HasOne("EducationPortalConsole.Core.Entities.User", "CreatedBy")
                        .WithMany("CreatedCourses")
                        .HasForeignKey("CreatedById");

                    b.HasOne("EducationPortalConsole.Core.Entities.User", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedById");

                    b.Navigation("CreatedBy");

                    b.Navigation("UpdatedBy");
                });

            modelBuilder.Entity("EducationPortalConsole.Core.Entities.JoinEntities.BookAuthorBookMaterial", b =>
                {
                    b.HasOne("EducationPortalConsole.Core.Entities.Materials.BookAuthor", "BookAuthor")
                        .WithMany("BookAuthorBookMaterial")
                        .HasForeignKey("BookAuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EducationPortalConsole.Core.Entities.Materials.BookMaterial", "BookMaterial")
                        .WithMany("BookAuthorBookMaterial")
                        .HasForeignKey("BookMaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookAuthor");

                    b.Navigation("BookMaterial");
                });

            modelBuilder.Entity("EducationPortalConsole.Core.Entities.JoinEntities.CourseMaterial", b =>
                {
                    b.HasOne("EducationPortalConsole.Core.Entities.Course", "Course")
                        .WithMany("CourseMaterials")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EducationPortalConsole.Core.Entities.Material", "Material")
                        .WithMany("CourseMaterials")
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Material");
                });

            modelBuilder.Entity("EducationPortalConsole.Core.Entities.JoinEntities.CourseSkill", b =>
                {
                    b.HasOne("EducationPortalConsole.Core.Entities.Course", "Course")
                        .WithMany("CourseSkills")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EducationPortalConsole.Core.Entities.Skill", "Skill")
                        .WithMany("CourseSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("EducationPortalConsole.Core.Entities.Material", b =>
                {
                    b.HasOne("EducationPortalConsole.Core.Entities.User", "CreatedBy")
                        .WithMany("CreatedMaterials")
                        .HasForeignKey("CreatedById");

                    b.HasOne("EducationPortalConsole.Core.Entities.User", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedById");

                    b.Navigation("CreatedBy");

                    b.Navigation("UpdatedBy");
                });

            modelBuilder.Entity("EducationPortalConsole.Core.Entities.Materials.BookAuthor", b =>
                {
                    b.HasOne("EducationPortalConsole.Core.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("EducationPortalConsole.Core.Entities.User", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedById");

                    b.Navigation("CreatedBy");

                    b.Navigation("UpdatedBy");
                });

            modelBuilder.Entity("EducationPortalConsole.Core.Entities.Progress.CourseProgress", b =>
                {
                    b.HasOne("EducationPortalConsole.Core.Entities.Course", "Course")
                        .WithMany("CourseProgresses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EducationPortalConsole.Core.Entities.User", "User")
                        .WithMany("CourseProgresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EducationPortalConsole.Core.Entities.Progress.MaterialProgress", b =>
                {
                    b.HasOne("EducationPortalConsole.Core.Entities.Material", "Material")
                        .WithMany("MaterialProgresses")
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EducationPortalConsole.Core.Entities.User", "User")
                        .WithMany("MaterialProgresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Material");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EducationPortalConsole.Core.Entities.Progress.SkillProgress", b =>
                {
                    b.HasOne("EducationPortalConsole.Core.Entities.Skill", "Skill")
                        .WithMany("SkillProgresses")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EducationPortalConsole.Core.Entities.User", "User")
                        .WithMany("SkillProgresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Skill");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EducationPortalConsole.Core.Entities.Skill", b =>
                {
                    b.HasOne("EducationPortalConsole.Core.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("EducationPortalConsole.Core.Entities.User", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedById");

                    b.Navigation("CreatedBy");

                    b.Navigation("UpdatedBy");
                });

            modelBuilder.Entity("EducationPortalConsole.Core.Entities.Course", b =>
                {
                    b.Navigation("CourseMaterials");

                    b.Navigation("CourseProgresses");

                    b.Navigation("CourseSkills");
                });

            modelBuilder.Entity("EducationPortalConsole.Core.Entities.Material", b =>
                {
                    b.Navigation("CourseMaterials");

                    b.Navigation("MaterialProgresses");
                });

            modelBuilder.Entity("EducationPortalConsole.Core.Entities.Materials.BookAuthor", b =>
                {
                    b.Navigation("BookAuthorBookMaterial");
                });

            modelBuilder.Entity("EducationPortalConsole.Core.Entities.Skill", b =>
                {
                    b.Navigation("CourseSkills");

                    b.Navigation("SkillProgresses");
                });

            modelBuilder.Entity("EducationPortalConsole.Core.Entities.User", b =>
                {
                    b.Navigation("CourseProgresses");

                    b.Navigation("CreatedCourses");

                    b.Navigation("CreatedMaterials");

                    b.Navigation("MaterialProgresses");

                    b.Navigation("SkillProgresses");
                });

            modelBuilder.Entity("EducationPortalConsole.Core.Entities.Materials.BookMaterial", b =>
                {
                    b.Navigation("BookAuthorBookMaterial");
                });
#pragma warning restore 612, 618
        }
    }
}
