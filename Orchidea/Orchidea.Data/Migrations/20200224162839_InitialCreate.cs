using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Orchidea.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flowers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flowers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Flowers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("8d38549a-4e17-4715-ba8b-375db5282666"), "Orchidea" },
                    { new Guid("7dab7074-d639-4e5f-9385-dedb291e6b27"), "Rose" },
                    { new Guid("f8b55404-dd8f-4258-b926-58f418fea742"), "Snowdrop" },
                    { new Guid("013287fb-cabe-4eca-bb27-558e2ae8a294"), "Bluebell" },
                    { new Guid("cff9330e-9e2e-42e1-9762-9f82940cdc24"), "Daffodil" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flowers");
        }
    }
}
