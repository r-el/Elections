using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class VotingArea : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VotingAreaId",
                table: "VotersInElections",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "VotingAreas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VotingAreas", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VotersInElections_VotingAreaId",
                table: "VotersInElections",
                column: "VotingAreaId");

            migrationBuilder.AddForeignKey(
                name: "FK_VotersInElections_VotingAreas_VotingAreaId",
                table: "VotersInElections",
                column: "VotingAreaId",
                principalTable: "VotingAreas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VotersInElections_VotingAreas_VotingAreaId",
                table: "VotersInElections");

            migrationBuilder.DropTable(
                name: "VotingAreas");

            migrationBuilder.DropIndex(
                name: "IX_VotersInElections_VotingAreaId",
                table: "VotersInElections");

            migrationBuilder.DropColumn(
                name: "VotingAreaId",
                table: "VotersInElections");
        }
    }
}
