using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GSC_BackEnd_TP.Migrations
{
    public partial class Nombre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loan_People_PersonId",
                table: "Loan");

            migrationBuilder.DropForeignKey(
                name: "FK_Loan_Thing_ThingId",
                table: "Loan");

            migrationBuilder.DropForeignKey(
                name: "FK_Thing_Category_CategoryId",
                table: "Thing");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Thing",
                table: "Thing");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Loan",
                table: "Loan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Thing");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Thing",
                newName: "Things");

            migrationBuilder.RenameTable(
                name: "Loan",
                newName: "Loans");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_Thing_CategoryId",
                table: "Things",
                newName: "IX_Things_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Loan_ThingId",
                table: "Loans",
                newName: "IX_Loans_ThingId");

            migrationBuilder.RenameIndex(
                name: "IX_Loan_PersonId",
                table: "Loans",
                newName: "IX_Loans_PersonId");

            migrationBuilder.AlterColumn<int>(
                name: "ThingId",
                table: "Loans",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Loans",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Things",
                table: "Things",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Loans",
                table: "Loans",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_People_PersonId",
                table: "Loans",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Things_ThingId",
                table: "Loans",
                column: "ThingId",
                principalTable: "Things",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Things_Categories_CategoryId",
                table: "Things",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_People_PersonId",
                table: "Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Things_ThingId",
                table: "Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_Things_Categories_CategoryId",
                table: "Things");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Things",
                table: "Things");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Loans",
                table: "Loans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Things",
                newName: "Thing");

            migrationBuilder.RenameTable(
                name: "Loans",
                newName: "Loan");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameIndex(
                name: "IX_Things_CategoryId",
                table: "Thing",
                newName: "IX_Thing_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Loans_ThingId",
                table: "Loan",
                newName: "IX_Loan_ThingId");

            migrationBuilder.RenameIndex(
                name: "IX_Loans_PersonId",
                table: "Loan",
                newName: "IX_Loan_PersonId");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "People",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Address",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Thing",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ThingId",
                table: "Loan",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Loan",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Loan",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Thing",
                table: "Thing",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Loan",
                table: "Loan",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Loan_People_PersonId",
                table: "Loan",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Loan_Thing_ThingId",
                table: "Loan",
                column: "ThingId",
                principalTable: "Thing",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Thing_Category_CategoryId",
                table: "Thing",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
