using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PhoneStore.Migrations
{
    public partial class memory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MemoryId",
                table: "Phone",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Memory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Size = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memory", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Phone_MemoryId",
                table: "Phone",
                column: "MemoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Phone_Memory_MemoryId",
                table: "Phone",
                column: "MemoryId",
                principalTable: "Memory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phone_Memory_MemoryId",
                table: "Phone");

            migrationBuilder.DropTable(
                name: "Memory");

            migrationBuilder.DropIndex(
                name: "IX_Phone_MemoryId",
                table: "Phone");

            migrationBuilder.DropColumn(
                name: "MemoryId",
                table: "Phone");
        }
    }
}
