using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FIndMeARoomate.Migrations
{
    /// <inheritdoc />
    public partial class Version20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dormitory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dormitory", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DormitoryStudents",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    DormitoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DormitoryStudents", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DormitoryStudents_Dormitory_DormitoryID",
                        column: x => x.DormitoryID,
                        principalTable: "Dormitory",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DormitoryStudents_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DormitoryStudents_DormitoryID",
                table: "DormitoryStudents",
                column: "DormitoryID");

            migrationBuilder.CreateIndex(
                name: "IX_DormitoryStudents_StudentID",
                table: "DormitoryStudents",
                column: "StudentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DormitoryStudents");

            migrationBuilder.DropTable(
                name: "Dormitory");
        }
    }
}
