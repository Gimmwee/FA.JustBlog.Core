﻿using FA.JustBlog.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FA.JustBlog.Core.DataContext
{
    public static class JustBlogInitializer
    {
        /// <summary>
        /// add data to other class
        /// </summary>
        /// <param name="builder"></param>
        public static void SeedData(this ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    Name = "Chân dung giám đốc trốn nợ được ông Chung cho làm dự án cây xanh",
                    UrlSlug = "chan-dung-giam-dc-trn-n-duc-ong-chung-cho-lam-d-an-cay-xanh",
                    Desciption = "This is an example page for demonstration purposes.",
                },
                new Category
                {
                    CategoryId = 2,
                    Name = "About Us",
                    UrlSlug = "about-us",
                    Desciption = "Learn more about our company and what we do.",
                },
                new Category
                {
                    CategoryId = 3,
                    Name = "Contact to customer",
                    UrlSlug = "contact-to-customer",
                    Desciption = "Get in touch with us for any questions or inquiries.",
                }
            );

            builder.Entity<Post>().HasData(
                new Post
                {
                    PostId = 1,
                    Title = "Introduction to C# Programming",
                    ShortDescription = "Learn the basics of C# programming language in this introductory tutorial.",
                    PostContent = "C# is a modern, object-oriented programming language that is widely used in the development of Windows applications, web applications, and games. It was developed by Microsoft and is part of the .NET framework. In this tutorial, we will cover the basics of C# programming, including data types, variables, operators, and control structures.",
                    UrlSlug = "introduction-to-c-sharp-programming",
                    Published = true,
                    PostedOn = DateTime.Now,
                    Modified = DateTime.Now,
                    CategoryId = 1,
                },
                 new Post
                 {
                     PostId = 2,
                     Title = "How to Build a Responsive Website",
                     ShortDescription = "Learn how to create a website that works well on all devices, including desktops, tablets, and smartphones.",
                     PostContent = "Building a responsive website involves using HTML, CSS, and JavaScript to create a layout that adapts to different screen sizes. In this tutorial, we will cover the basics of responsive design, including media queries, flexible grids, and fluid images. We will also discuss some common challenges and how to overcome them.",
                     UrlSlug = "how-to-build-a-responsive-website",
                     Published = true,
                     PostedOn = DateTime.Now,
                     Modified = DateTime.Now,
                     CategoryId = 2,
                 },
                  new Post
                  {
                      PostId = 3,
                      Title = "10 Tips for Better Time Management",
                      ShortDescription = "Learn how to manage your time more effectively with these 10 simple tips.",
                      PostContent = "Time management is an essential skill for success in both personal and professional life. In this article, we will share 10 tips for better time management, including setting goals, prioritizing tasks, minimizing distractions, and delegating responsibilities. By following these tips, you can improve your productivity, reduce stress, and achieve your goals more efficiently.",
                      UrlSlug = "10-tips-for-better-time-management",
                      Published = false,
                      PostedOn = DateTime.Now,
                      Modified = DateTime.Now,
                      CategoryId = 3,
                  }
            );

            builder.Entity<PostTagMap>().HasData(
                new PostTagMap
                {
                    PostId = 1,
                    TagId = 1
                },
                new PostTagMap
                {
                    PostId = 2,
                    TagId = 2
                },
                new PostTagMap
                {
                    PostId = 3,
                    TagId = 3
                }
            );
            builder.Entity<Tag>().HasData(
                new Tag
                {
                    TagId = 1,
                    Name = "C#",
                    UrlSlug = "c-sharp",
                    Description = "C# programming language",
                    Count = 2
                },
                new Tag
                {
                    TagId = 2,
                    Name = "Responsive Design",
                    UrlSlug = "responsive-design",
                    Description = "Creating responsive web layouts",
                    Count = 1
                },
                new Tag
                {
                    TagId = 3,
                    Name = "Time Management",
                    UrlSlug = "time-management",
                    Description = "Tips for better time management",
                    Count = 3
                }
            );
            builder.Entity<Comment>().HasData(
               new Comment
               {
                   CommentId = 1,
                   Name = "John Smith",
                   Email = "john.smith@example.com",
                   PostId = 1,
                   CommentHeader = "Great article!",
                   CommentText = "This article provided a lot of useful information. I learned a lot from it. Thank you!",
                   CommentTime = DateTime.Now,
               },
               new Comment
               {
                   CommentId = 2,
                   Name = "KienDc",
                   Email = "jane.doe@example.com",
                   PostId = 3,
                   CommentHeader = "Interesting perspective!",
                   CommentText = "I never thought about the topic from this angle before. Your article gave me a lot to think about. Thanks for sharing!",
                   CommentTime = DateTime.Now,
               },
               new Comment
               {
                   CommentId = 3,
                   Name = "Son PP",
                   Email = "SonPP@example.com",
                   PostId = 2,
                   CommentHeader = "Question about the topic",
                   CommentText = "I have a question about one of the points you made in the article. Can you provide more information about XYZ? Thanks!",
                   CommentTime = DateTime.Now,
               }
           );

        }
    }
}
