using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_tagcloud1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TagClouds_Blogs_BlogID",
                table: "TagClouds");

            migrationBuilder.DropColumn(
                name: "BlodID",
                table: "TagClouds");

            migrationBuilder.RenameColumn(
                name: "BlogID",
                table: "TagClouds",
                newName: "blogID");

            migrationBuilder.RenameIndex(
                name: "IX_TagClouds_BlogID",
                table: "TagClouds",
                newName: "IX_TagClouds_blogID");

            migrationBuilder.AddForeignKey(
                name: "FK_TagClouds_Blogs_blogID",
                table: "TagClouds",
                column: "blogID",
                principalTable: "Blogs",
                principalColumn: "BlogID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TagClouds_Blogs_blogID",
                table: "TagClouds");

            migrationBuilder.RenameColumn(
                name: "blogID",
                table: "TagClouds",
                newName: "BlogID");

            migrationBuilder.RenameIndex(
                name: "IX_TagClouds_blogID",
                table: "TagClouds",
                newName: "IX_TagClouds_BlogID");

            migrationBuilder.AddColumn<int>(
                name: "BlodID",
                table: "TagClouds",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_TagClouds_Blogs_BlogID",
                table: "TagClouds",
                column: "BlogID",
                principalTable: "Blogs",
                principalColumn: "BlogID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
