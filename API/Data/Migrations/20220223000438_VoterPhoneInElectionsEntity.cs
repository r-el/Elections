using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class VoterPhoneInElectionsEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VotersInElections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ElectionsId = table.Column<int>(type: "INTEGER", nullable: false),
                    VoterId = table.Column<int>(type: "INTEGER", nullable: false),
                    CandidateId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VotersInElections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VotersInElections_Candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VotersInElections_Elections_ElectionsId",
                        column: x => x.ElectionsId,
                        principalTable: "Elections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VotersInElections_Voter_VoterId",
                        column: x => x.VoterId,
                        principalTable: "Voter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VotersInElections_CandidateId",
                table: "VotersInElections",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_VotersInElections_ElectionsId",
                table: "VotersInElections",
                column: "ElectionsId");

            migrationBuilder.CreateIndex(
                name: "IX_VotersInElections_VoterId",
                table: "VotersInElections",
                column: "VoterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VotersInElections");
        }
    }
}
