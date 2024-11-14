using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cpu.Migrations
{
    /// <inheritdoc />
    public partial class fuck : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cpus",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    marque = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    famille = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modele = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    frequence = table.Column<float>(type: "real", nullable: false),
                    prix = table.Column<int>(type: "int", nullable: false),
                    stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cpus", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cpu_production",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    duree_prod = table.Column<int>(type: "int", nullable: false),
                    cpu_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cpu_production", x => x.id);
                    table.ForeignKey(
                        name: "fk_cpu_production_cpus_cpu_id",
                        column: x => x.cpu_id,
                        principalTable: "cpus",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_cpu_production_cpu_id",
                table: "cpu_production",
                column: "cpu_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cpu_production");

            migrationBuilder.DropTable(
                name: "cpus");
        }
    }
}
