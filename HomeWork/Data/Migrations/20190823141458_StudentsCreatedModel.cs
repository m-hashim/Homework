using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeWork.Data.Migrations
{
    public partial class StudentsCreatedModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BatchId",
                table: "Subjects",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_BatchId",
                table: "Subjects",
                column: "BatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Batches_BatchId",
                table: "Subjects",
                column: "BatchId",
                principalTable: "Batches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Batches_BatchId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_BatchId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "BatchId",
                table: "Subjects");
        }
    }
}
