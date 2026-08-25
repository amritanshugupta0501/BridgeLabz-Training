using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FundooNotesApp.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddLabelsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Label",
                columns: table => new
                {
                    LabelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LabelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Label", x => x.LabelId);
                });

            migrationBuilder.CreateTable(
                name: "LabelNotes",
                columns: table => new
                {
                    LabelsLabelId = table.Column<int>(type: "int", nullable: false),
                    NotesNoteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabelNotes", x => new { x.LabelsLabelId, x.NotesNoteId });
                    table.ForeignKey(
                        name: "FK_LabelNotes_Label_LabelsLabelId",
                        column: x => x.LabelsLabelId,
                        principalTable: "Label",
                        principalColumn: "LabelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LabelNotes_Note_NotesNoteId",
                        column: x => x.NotesNoteId,
                        principalTable: "Note",
                        principalColumn: "NoteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LabelNotes_NotesNoteId",
                table: "LabelNotes",
                column: "NotesNoteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LabelNotes");

            migrationBuilder.DropTable(
                name: "Label");
        }
    }
}
