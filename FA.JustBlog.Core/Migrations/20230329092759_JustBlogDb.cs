using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class JustBlogDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UrlSlug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Desciption = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    TagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrlSlug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrlSlug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Published = table.Column<bool>(type: "bit", nullable: false),
                    PostedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    RateCount = table.Column<int>(type: "int", nullable: false),
                    TotalRate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Posts_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    CommentHeader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostTagMap",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTagMap", x => new { x.PostId, x.TagId });
                    table.ForeignKey(
                        name: "FK_PostTagMap_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTagMap_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Desciption", "Name", "UrlSlug" },
                values: new object[,]
                {
                    { 1, "This is an example page for demonstration purposes.", "Chân dung giám đốc trốn nợ được ông Chung cho làm dự án cây xanh", "chan-dung-giam-dc-trn-n-duc-ong-chung-cho-lam-d-an-cay-xanh" },
                    { 2, "Learn more about our company and what we do.", "About Us", "about-us" },
                    { 3, "Get in touch with us for any questions or inquiries.", "Contact to customer", "contact-to-customer" }
                });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "TagId", "Count", "Description", "Name", "UrlSlug" },
                values: new object[,]
                {
                    { 1, 2, "C# programming language", "C#", "c-sharp" },
                    { 2, 1, "Creating responsive web layouts", "Responsive Design", "responsive-design" },
                    { 3, 3, "Tips for better time management", "Time Management", "time-management" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "CategoryId", "Modified", "PostContent", "PostedOn", "Published", "RateCount", "ShortDescription", "Title", "TotalRate", "UrlSlug", "ViewCount" },
                values: new object[] { 1, 1, new DateTime(2023, 3, 29, 16, 27, 58, 845, DateTimeKind.Local).AddTicks(6031), "C# is a modern, object-oriented programming language that is widely used in the development of Windows applications, web applications, and games. It was developed by Microsoft and is part of the .NET framework. In this tutorial, we will cover the basics of C# programming, including data types, variables, operators, and control structures.", new DateTime(2023, 3, 29, 16, 27, 58, 845, DateTimeKind.Local).AddTicks(6022), true, 0, "Learn the basics of C# programming language in this introductory tutorial.", "Introduction to C# Programming", 0, "introduction-to-c-sharp-programming", 0 });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "CategoryId", "Modified", "PostContent", "PostedOn", "Published", "RateCount", "ShortDescription", "Title", "TotalRate", "UrlSlug", "ViewCount" },
                values: new object[] { 2, 2, new DateTime(2023, 3, 29, 16, 27, 58, 845, DateTimeKind.Local).AddTicks(6033), "Building a responsive website involves using HTML, CSS, and JavaScript to create a layout that adapts to different screen sizes. In this tutorial, we will cover the basics of responsive design, including media queries, flexible grids, and fluid images. We will also discuss some common challenges and how to overcome them.", new DateTime(2023, 3, 29, 16, 27, 58, 845, DateTimeKind.Local).AddTicks(6032), true, 0, "Learn how to create a website that works well on all devices, including desktops, tablets, and smartphones.", "How to Build a Responsive Website", 0, "how-to-build-a-responsive-website", 0 });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "CategoryId", "Modified", "PostContent", "PostedOn", "Published", "RateCount", "ShortDescription", "Title", "TotalRate", "UrlSlug", "ViewCount" },
                values: new object[] { 3, 3, new DateTime(2023, 3, 29, 16, 27, 58, 845, DateTimeKind.Local).AddTicks(6034), "Time management is an essential skill for success in both personal and professional life. In this article, we will share 10 tips for better time management, including setting goals, prioritizing tasks, minimizing distractions, and delegating responsibilities. By following these tips, you can improve your productivity, reduce stress, and achieve your goals more efficiently.", new DateTime(2023, 3, 29, 16, 27, 58, 845, DateTimeKind.Local).AddTicks(6034), false, 0, "Learn how to manage your time more effectively with these 10 simple tips.", "10 Tips for Better Time Management", 0, "10-tips-for-better-time-management", 0 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "CommentHeader", "CommentText", "CommentTime", "Email", "Name", "PostId" },
                values: new object[,]
                {
                    { 1, "Great article!", "This article provided a lot of useful information. I learned a lot from it. Thank you!", new DateTime(2023, 3, 29, 16, 27, 58, 845, DateTimeKind.Local).AddTicks(6069), "john.smith@example.com", "John Smith", 1 },
                    { 2, "Interesting perspective!", "I never thought about the topic from this angle before. Your article gave me a lot to think about. Thanks for sharing!", new DateTime(2023, 3, 29, 16, 27, 58, 845, DateTimeKind.Local).AddTicks(6070), "jane.doe@example.com", "KienDc", 3 },
                    { 3, "Question about the topic", "I have a question about one of the points you made in the article. Can you provide more information about XYZ? Thanks!", new DateTime(2023, 3, 29, 16, 27, 58, 845, DateTimeKind.Local).AddTicks(6071), "SonPP@example.com", "Son PP", 2 }
                });

            migrationBuilder.InsertData(
                table: "PostTagMap",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTagMap_TagId",
                table: "PostTagMap",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "PostTagMap");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
