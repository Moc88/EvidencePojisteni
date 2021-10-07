using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EvidencePojisteni.Data.Migrations
{
    public partial class Vytvoreni_adres_events : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MesicniCastka",
                table: "Insurance");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Klient",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefon",
                table: "Klient",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RocniCastka",
                table: "Insurance",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KlientId = table.Column<string>(nullable: true),
                    Ulice = table.Column<string>(nullable: false),
                    Cp = table.Column<string>(nullable: false),
                    Mesto = table.Column<string>(nullable: false),
                    Psc = table.Column<string>(nullable: false),
                    Stat = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KlientId = table.Column<string>(nullable: true),
                    InsuranceId = table.Column<string>(nullable: true),
                    Nahlaseno = table.Column<DateTime>(nullable: false),
                    Typ = table.Column<string>(nullable: false),
                    Odhad = table.Column<int>(nullable: false),
                    VyplacenaCastka = table.Column<int>(nullable: false),
                    VyplacenoDatum = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Klient");

            migrationBuilder.DropColumn(
                name: "Telefon",
                table: "Klient");

            migrationBuilder.DropColumn(
                name: "RocniCastka",
                table: "Insurance");

            migrationBuilder.AddColumn<int>(
                name: "MesicniCastka",
                table: "Insurance",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
