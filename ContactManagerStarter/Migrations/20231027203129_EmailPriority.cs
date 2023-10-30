using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactManagerStarter.Migrations
{
    /// <inheritdoc />
    public partial class EmailPriority : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "EmailAddresses",
                type: "int",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.Sql("update dbo.EmailAddresses SET Priority=0");
            /*
                        migrationBuilder.UpdateData(
                            table: "EmailAddresses",
                            keyColumn: "Id",
                            keyValue: new Guid("3a406f64-ad7b-4098-ab01-7e93aae2b851"),
                            column: "Priority",
                            value: 0);

                        migrationBuilder.UpdateData(
                            table: "EmailAddresses",
                            keyColumn: "Id",
                            keyValue: new Guid("3ddeb084-5e5d-4eca-b275-e4f6886e04dc"),
                            column: "Priority",
                            value: 1);

                        migrationBuilder.UpdateData(
                            table: "EmailAddresses",
                            keyColumn: "Id",
                            keyValue: new Guid("5111f412-a7f4-4169-bb27-632687569ccd"),
                            column: "Priority",
                            value: 1);

                        migrationBuilder.UpdateData(
                            table: "EmailAddresses",
                            keyColumn: "Id",
                            keyValue: new Guid("d1a50413-20c0-4972-a351-8be24e1fc939"),
                            column: "Priority",
                            value: 1);
            */
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Priority",
                table: "EmailAddresses");
        }
    }
}
