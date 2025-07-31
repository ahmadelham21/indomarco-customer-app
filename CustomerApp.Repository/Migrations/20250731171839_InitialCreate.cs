using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CustomerApp.Repository.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customer",
                columns: table => new
                {
                    customer_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    customer_code = table.Column<string>(type: "text", nullable: false),
                    customer_name = table.Column<string>(type: "text", nullable: false),
                    customer_address = table.Column<string>(type: "text", nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modified_by = table.Column<int>(type: "integer", nullable: true),
                    modified_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer", x => x.customer_id);
                });

            migrationBuilder.InsertData(
                table: "customer",
                columns: new[] { "customer_id", "created_at", "created_by", "customer_address", "customer_code", "customer_name", "modified_at", "modified_by" },
                values: new object[] { 1, new DateTime(2025, 7, 31, 17, 18, 39, 47, DateTimeKind.Utc).AddTicks(4488), 1, "Jl. Mangga Dua Raya", "000001", "User Pertama", null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customer");
        }
    }
}
