using Microsoft.EntityFrameworkCore.Migrations;

namespace Otiport.API.Migrations
{
    public partial class Medicineentitywasadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThreatmentToPatients_Patients_PatientId1",
                table: "ThreatmentToPatients");

            migrationBuilder.DropForeignKey(
                name: "FK_ThreatmentToPatients_Treatments_ProfileItemId",
                table: "ThreatmentToPatients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ThreatmentToPatients",
                table: "ThreatmentToPatients");

            migrationBuilder.RenameTable(
                name: "ThreatmentToPatients",
                newName: "TreatmentToPatients");

            migrationBuilder.RenameIndex(
                name: "IX_ThreatmentToPatients_ProfileItemId",
                table: "TreatmentToPatients",
                newName: "IX_TreatmentToPatients_ProfileItemId");

            migrationBuilder.RenameIndex(
                name: "IX_ThreatmentToPatients_PatientId1",
                table: "TreatmentToPatients",
                newName: "IX_TreatmentToPatients_PatientId1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TreatmentToPatients",
                table: "TreatmentToPatients",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TreatmentToPatients_Patients_PatientId1",
                table: "TreatmentToPatients",
                column: "PatientId1",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TreatmentToPatients_Treatments_ProfileItemId",
                table: "TreatmentToPatients",
                column: "ProfileItemId",
                principalTable: "Treatments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TreatmentToPatients_Patients_PatientId1",
                table: "TreatmentToPatients");

            migrationBuilder.DropForeignKey(
                name: "FK_TreatmentToPatients_Treatments_ProfileItemId",
                table: "TreatmentToPatients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TreatmentToPatients",
                table: "TreatmentToPatients");

            migrationBuilder.RenameTable(
                name: "TreatmentToPatients",
                newName: "ThreatmentToPatients");

            migrationBuilder.RenameIndex(
                name: "IX_TreatmentToPatients_ProfileItemId",
                table: "ThreatmentToPatients",
                newName: "IX_ThreatmentToPatients_ProfileItemId");

            migrationBuilder.RenameIndex(
                name: "IX_TreatmentToPatients_PatientId1",
                table: "ThreatmentToPatients",
                newName: "IX_ThreatmentToPatients_PatientId1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ThreatmentToPatients",
                table: "ThreatmentToPatients",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ThreatmentToPatients_Patients_PatientId1",
                table: "ThreatmentToPatients",
                column: "PatientId1",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ThreatmentToPatients_Treatments_ProfileItemId",
                table: "ThreatmentToPatients",
                column: "ProfileItemId",
                principalTable: "Treatments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
