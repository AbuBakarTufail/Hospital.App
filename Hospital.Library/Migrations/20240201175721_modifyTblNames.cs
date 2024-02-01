using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Library.Migrations
{
    /// <inheritdoc />
    public partial class modifyTblNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientTests_tblPatient_PatientId",
                table: "PatientTests");

            migrationBuilder.DropForeignKey(
                name: "FK_tblPatient_PatientTypes_PatientTypeId",
                table: "tblPatient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PatientTypes",
                table: "PatientTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PatientTests",
                table: "PatientTests");

            migrationBuilder.RenameTable(
                name: "PatientTypes",
                newName: "tblPatientType");

            migrationBuilder.RenameTable(
                name: "PatientTests",
                newName: "tblPatientTest");

            migrationBuilder.RenameIndex(
                name: "IX_PatientTests_PatientId",
                table: "tblPatientTest",
                newName: "IX_tblPatientTest_PatientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblPatientType",
                table: "tblPatientType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblPatientTest",
                table: "tblPatientTest",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tblPatient_tblPatientType_PatientTypeId",
                table: "tblPatient",
                column: "PatientTypeId",
                principalTable: "tblPatientType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tblPatientTest_tblPatient_PatientId",
                table: "tblPatientTest",
                column: "PatientId",
                principalTable: "tblPatient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblPatient_tblPatientType_PatientTypeId",
                table: "tblPatient");

            migrationBuilder.DropForeignKey(
                name: "FK_tblPatientTest_tblPatient_PatientId",
                table: "tblPatientTest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblPatientType",
                table: "tblPatientType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblPatientTest",
                table: "tblPatientTest");

            migrationBuilder.RenameTable(
                name: "tblPatientType",
                newName: "PatientTypes");

            migrationBuilder.RenameTable(
                name: "tblPatientTest",
                newName: "PatientTests");

            migrationBuilder.RenameIndex(
                name: "IX_tblPatientTest_PatientId",
                table: "PatientTests",
                newName: "IX_PatientTests_PatientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PatientTypes",
                table: "PatientTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PatientTests",
                table: "PatientTests",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientTests_tblPatient_PatientId",
                table: "PatientTests",
                column: "PatientId",
                principalTable: "tblPatient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblPatient_PatientTypes_PatientTypeId",
                table: "tblPatient",
                column: "PatientTypeId",
                principalTable: "PatientTypes",
                principalColumn: "Id");
        }
    }
}
