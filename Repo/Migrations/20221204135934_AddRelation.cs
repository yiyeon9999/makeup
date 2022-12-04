using Microsoft.EntityFrameworkCore.Migrations;

namespace Repo.Migrations
{
    public partial class AddRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserRole",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RoleId",
                table: "UserRole",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Post",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CourseId",
                table: "Post",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BookingId1",
                table: "History",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "History",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Booking",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TypeId",
                table: "Booking",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CategoryId",
                table: "Booking",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                table: "UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UserId",
                table: "UserRole",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_CourseId",
                table: "Post",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_UserId",
                table: "Post",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_History_BookingId1",
                table: "History",
                column: "BookingId1");

            migrationBuilder.CreateIndex(
                name: "IX_History_UserId1",
                table: "History",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_CategoryId",
                table: "Booking",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_TypeId",
                table: "Booking",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_UserId",
                table: "Booking",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Category_CategoryId",
                table: "Booking",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Type_TypeId",
                table: "Booking",
                column: "TypeId",
                principalTable: "Type",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_User_UserId",
                table: "Booking",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_History_Booking_BookingId1",
                table: "History",
                column: "BookingId1",
                principalTable: "Booking",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_History_User_UserId1",
                table: "History",
                column: "UserId1",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Course_CourseId",
                table: "Post",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_User_UserId",
                table: "Post",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Role_RoleId",
                table: "UserRole",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_User_UserId",
                table: "UserRole",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Category_CategoryId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Type_TypeId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_User_UserId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_History_Booking_BookingId1",
                table: "History");

            migrationBuilder.DropForeignKey(
                name: "FK_History_User_UserId1",
                table: "History");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Course_CourseId",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_User_UserId",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_Role_RoleId",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_User_UserId",
                table: "UserRole");

            migrationBuilder.DropIndex(
                name: "IX_UserRole_RoleId",
                table: "UserRole");

            migrationBuilder.DropIndex(
                name: "IX_UserRole_UserId",
                table: "UserRole");

            migrationBuilder.DropIndex(
                name: "IX_Post_CourseId",
                table: "Post");

            migrationBuilder.DropIndex(
                name: "IX_Post_UserId",
                table: "Post");

            migrationBuilder.DropIndex(
                name: "IX_History_BookingId1",
                table: "History");

            migrationBuilder.DropIndex(
                name: "IX_History_UserId1",
                table: "History");

            migrationBuilder.DropIndex(
                name: "IX_Booking_CategoryId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_TypeId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_UserId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "BookingId1",
                table: "History");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "History");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserRole",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RoleId",
                table: "UserRole",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Post",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CourseId",
                table: "Post",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Booking",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TypeId",
                table: "Booking",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CategoryId",
                table: "Booking",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
