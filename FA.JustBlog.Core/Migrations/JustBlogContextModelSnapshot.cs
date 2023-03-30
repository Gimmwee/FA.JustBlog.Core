﻿// <auto-generated />
using System;
using FA.JustBlog.Core.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    [DbContext(typeof(JustBlogContext))]
    partial class JustBlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FA.JustBlog.Core.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("Desciption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("UrlSlug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category", (string)null);

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Desciption = "This is an example page for demonstration purposes.",
                            Name = "Chân dung giám đốc trốn nợ được ông Chung cho làm dự án cây xanh",
                            UrlSlug = "chan-dung-giam-dc-trn-n-duc-ong-chung-cho-lam-d-an-cay-xanh"
                        },
                        new
                        {
                            CategoryId = 2,
                            Desciption = "Learn more about our company and what we do.",
                            Name = "About Us",
                            UrlSlug = "about-us"
                        },
                        new
                        {
                            CategoryId = 3,
                            Desciption = "Get in touch with us for any questions or inquiries.",
                            Name = "Contact to customer",
                            UrlSlug = "contact-to-customer"
                        });
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentId"), 1L, 1);

                    b.Property<string>("CommentHeader")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CommentTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex("PostId");

                    b.ToTable("Comments", (string)null);

                    b.HasData(
                        new
                        {
                            CommentId = 1,
                            CommentHeader = "Great article!",
                            CommentText = "This article provided a lot of useful information. I learned a lot from it. Thank you!",
                            CommentTime = new DateTime(2023, 3, 29, 16, 27, 58, 845, DateTimeKind.Local).AddTicks(6069),
                            Email = "john.smith@example.com",
                            Name = "John Smith",
                            PostId = 1
                        },
                        new
                        {
                            CommentId = 2,
                            CommentHeader = "Interesting perspective!",
                            CommentText = "I never thought about the topic from this angle before. Your article gave me a lot to think about. Thanks for sharing!",
                            CommentTime = new DateTime(2023, 3, 29, 16, 27, 58, 845, DateTimeKind.Local).AddTicks(6070),
                            Email = "jane.doe@example.com",
                            Name = "KienDc",
                            PostId = 3
                        },
                        new
                        {
                            CommentId = 3,
                            CommentHeader = "Question about the topic",
                            CommentText = "I have a question about one of the points you made in the article. Can you provide more information about XYZ? Thanks!",
                            CommentTime = new DateTime(2023, 3, 29, 16, 27, 58, 845, DateTimeKind.Local).AddTicks(6071),
                            Email = "SonPP@example.com",
                            Name = "Son PP",
                            PostId = 2
                        });
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PostId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PostedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Published")
                        .HasColumnType("bit");

                    b.Property<int>("RateCount")
                        .HasColumnType("int");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalRate")
                        .HasColumnType("int");

                    b.Property<string>("UrlSlug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("PostId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Posts", (string)null);

                    b.HasData(
                        new
                        {
                            PostId = 1,
                            CategoryId = 1,
                            Modified = new DateTime(2023, 3, 29, 16, 27, 58, 845, DateTimeKind.Local).AddTicks(6031),
                            PostContent = "C# is a modern, object-oriented programming language that is widely used in the development of Windows applications, web applications, and games. It was developed by Microsoft and is part of the .NET framework. In this tutorial, we will cover the basics of C# programming, including data types, variables, operators, and control structures.",
                            PostedOn = new DateTime(2023, 3, 29, 16, 27, 58, 845, DateTimeKind.Local).AddTicks(6022),
                            Published = true,
                            RateCount = 0,
                            ShortDescription = "Learn the basics of C# programming language in this introductory tutorial.",
                            Title = "Introduction to C# Programming",
                            TotalRate = 0,
                            UrlSlug = "introduction-to-c-sharp-programming",
                            ViewCount = 0
                        },
                        new
                        {
                            PostId = 2,
                            CategoryId = 2,
                            Modified = new DateTime(2023, 3, 29, 16, 27, 58, 845, DateTimeKind.Local).AddTicks(6033),
                            PostContent = "Building a responsive website involves using HTML, CSS, and JavaScript to create a layout that adapts to different screen sizes. In this tutorial, we will cover the basics of responsive design, including media queries, flexible grids, and fluid images. We will also discuss some common challenges and how to overcome them.",
                            PostedOn = new DateTime(2023, 3, 29, 16, 27, 58, 845, DateTimeKind.Local).AddTicks(6032),
                            Published = true,
                            RateCount = 0,
                            ShortDescription = "Learn how to create a website that works well on all devices, including desktops, tablets, and smartphones.",
                            Title = "How to Build a Responsive Website",
                            TotalRate = 0,
                            UrlSlug = "how-to-build-a-responsive-website",
                            ViewCount = 0
                        },
                        new
                        {
                            PostId = 3,
                            CategoryId = 3,
                            Modified = new DateTime(2023, 3, 29, 16, 27, 58, 845, DateTimeKind.Local).AddTicks(6034),
                            PostContent = "Time management is an essential skill for success in both personal and professional life. In this article, we will share 10 tips for better time management, including setting goals, prioritizing tasks, minimizing distractions, and delegating responsibilities. By following these tips, you can improve your productivity, reduce stress, and achieve your goals more efficiently.",
                            PostedOn = new DateTime(2023, 3, 29, 16, 27, 58, 845, DateTimeKind.Local).AddTicks(6034),
                            Published = false,
                            RateCount = 0,
                            ShortDescription = "Learn how to manage your time more effectively with these 10 simple tips.",
                            Title = "10 Tips for Better Time Management",
                            TotalRate = 0,
                            UrlSlug = "10-tips-for-better-time-management",
                            ViewCount = 0
                        });
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.PostTagMap", b =>
                {
                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("PostId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("PostTagMap", (string)null);

                    b.HasData(
                        new
                        {
                            PostId = 1,
                            TagId = 1
                        },
                        new
                        {
                            PostId = 2,
                            TagId = 2
                        },
                        new
                        {
                            PostId = 3,
                            TagId = 3
                        });
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TagId"), 1L, 1);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlSlug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagId");

                    b.ToTable("Tag", (string)null);

                    b.HasData(
                        new
                        {
                            TagId = 1,
                            Count = 2,
                            Description = "C# programming language",
                            Name = "C#",
                            UrlSlug = "c-sharp"
                        },
                        new
                        {
                            TagId = 2,
                            Count = 1,
                            Description = "Creating responsive web layouts",
                            Name = "Responsive Design",
                            UrlSlug = "responsive-design"
                        },
                        new
                        {
                            TagId = 3,
                            Count = 3,
                            Description = "Tips for better time management",
                            Name = "Time Management",
                            UrlSlug = "time-management"
                        });
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Comment", b =>
                {
                    b.HasOne("FA.JustBlog.Core.Models.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Post", b =>
                {
                    b.HasOne("FA.JustBlog.Core.Models.Category", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.PostTagMap", b =>
                {
                    b.HasOne("FA.JustBlog.Core.Models.Post", "Post")
                        .WithMany("PostTagMaps")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FA.JustBlog.Core.Models.Tag", "Tag")
                        .WithMany("PostTagMaps")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Category", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Post", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("PostTagMaps");
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Tag", b =>
                {
                    b.Navigation("PostTagMaps");
                });
#pragma warning restore 612, 618
        }
    }
}