using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb2AngularAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Person_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "Name", "PersonId" },
                values: new object[,]
                {
                    { 1, "Smycken, Hälsa & Verktyg", 18 },
                    { 2, "Spel", 17 },
                    { 3, "Böcker & Filmer", 40 },
                    { 4, "Smycken", 42 },
                    { 5, "Sport", 10 },
                    { 6, "Leksaker & Hem", 21 },
                    { 7, "Livsmedel & Skor", 43 },
                    { 8, "Böcker & Hälsa", 7 },
                    { 9, "Verktyg, Skönhet & Skönhet", 50 },
                    { 10, "Skönhet", 32 }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[,]
                {
                    { 1, "Loys Väg 731, Hatuna, Tjeckien", 4, "Lois", 1, "Johansson", 44369 },
                    { 2, "Idrottsgatan 6, Lyckstad, Nepal", 10, "Jeremy", 1, "Karlsson", 52436 },
                    { 3, "Undre Skogsallén 886, Lyckmora, Komorerna", 6, "Luz", 1, "Olsson", 55997 },
                    { 4, "Parkvägen 8, Söderhamn, Egypten", 8, "Sedrick", 1, "Larsson", 38712 },
                    { 5, "Demarcos Gata 10, Enholm, Libanon", 6, "Jamarcus", 1, "Andersson", 56078 },
                    { 6, "Kvarnvägen 6, Avmora, Estland", 10, "Destinee", 1, "Svensson", 35672 },
                    { 7, "Abbigails Väg 70, Enmora, Sudan", 2, "Cecile", 0, "Johansson", 44739 },
                    { 8, "Backgränden 966, Södervik, Israel", 3, "Johann", 0, "Svensson", 45985 },
                    { 9, "Anderssons Gata 704, Hafred, Samoa", 5, "Alyson", 0, "Karlsson", 37000 },
                    { 10, "Annes Väg 46, Österholm, Pakistan", 8, "Bridgette", 1, "Svensson", 45902 },
                    { 11, "Erikssons Väg 92, Helsingmora, Bosnien och Hercegovina", 6, "Buster", 0, "Persson", 46714 },
                    { 12, "Gustafssons Gata 4, Kungfors, Jamaica", 7, "Sophia", 0, "Olsson", 45607 },
                    { 13, "Wileys Gata 27, Båstad, Nordkorea", 1, "Doug", 1, "Karlsson", 47363 },
                    { 14, "Nygränden 3, Gävmora, Mongoliet", 8, "Nicolette", 0, "Gustafsson", 44699 },
                    { 15, "Patricias Väg 710, Avlöv, Panama", 2, "Gudrun", 1, "Larsson", 55222 },
                    { 16, "Järnvägsallén 391, Alingholm, Vanuatu", 5, "Sydni", 0, "Nilsson", 32294 },
                    { 17, "Aspallén 061, Eskfred, Israel", 2, "Ben", 1, "Persson", 36564 },
                    { 18, "Perssons Väg 767, Karlvik, Malta", 9, "Faustino", 1, "Svensson", 38883 },
                    { 19, "Norra Ringvägen 2, Östersta, Zimbabwe", 1, "Dena", 1, "Larsson", 57804 },
                    { 20, "Östra Backgränden 95, Kunglöv, Finland", 3, "Dee", 1, "Andersson", 45269 },
                    { 21, "Södra Backgränden 882, Falhult, USA", 7, "Sabina", 1, "Nilsson", 35429 },
                    { 22, "Västra Aspallén 9, Arfors, Dominica", 8, "Elza", 0, "Persson", 39699 },
                    { 23, "Karlssons Väg 972, Gävberg, Ryssland", 5, "Patricia", 0, "Johansson", 39355 },
                    { 24, "Norra Ringgatan 82, Kramby, Fiji", 1, "Connor", 1, "Svensson", 37975 },
                    { 25, "Patiences Gata 68, Kramholm, El Salvador", 4, "Lulu", 0, "Nilsson", 55147 },
                    { 26, "Östra Åkergärdet 288, Västhult, Mauretanien", 10, "Elouise", 1, "Larsson", 53127 },
                    { 27, "Larssons Väg 7, Falmora, Danmark", 1, "Irma", 0, "Larsson", 50639 },
                    { 28, "Stationsvägen 5, Karltuna, El Salvador", 6, "Llewellyn", 1, "Karlsson", 58308 },
                    { 29, "Gustafssons Väg 7, Söderstad, Vanuatu", 1, "Adela", 1, "Eriksson", 45413 },
                    { 30, "Jessikas Väg 96, Falberg, Nigeria", 3, "Bill", 1, "Gustafsson", 56461 },
                    { 31, "Genallén 8, Envik, Kanada", 10, "Chandler", 0, "Karlsson", 57706 },
                    { 32, "Perssons Väg 494, Bovik, Danmark", 5, "Estefania", 1, "Persson", 32461 },
                    { 33, "Skolgränden 304, Götemora, Centralafrikanska republiken", 6, "Lauretta", 0, "Eriksson", 36005 },
                    { 34, "Undre Ringgärdet 98, Kungby, Samoa", 10, "Carlotta", 1, "Persson", 50203 },
                    { 35, "Södra Furugatan 12, Väststad, Madagaskar", 2, "Norris", 0, "Nilsson", 57710 },
                    { 36, "Dashawns Gata 271, Västås, Pakistan", 8, "Bryce", 1, "Karlsson", 32068 },
                    { 37, "Skolgatan 924, Boås, Moçambique", 10, "Bella", 1, "Karlsson", 41270 },
                    { 38, "Erikssons Gata 8, Österland, Kuwait", 8, "Toni", 1, "Gustafsson", 50548 },
                    { 39, "Larssons Väg 578, Kriststad, Haiti", 3, "Hanna", 1, "Andersson", 45510 },
                    { 40, "Gustafssons Väg 82, Kristtuna, Argentina", 3, "Camila", 1, "Larsson", 53090 },
                    { 41, "Undre Ekgatan 631, Helsingberg, Malawi", 6, "Joanie", 0, "Persson", 55135 },
                    { 42, "Perssons Gata 09, Bosta, Antigua och Barbuda", 9, "Maya", 0, "Eriksson", 52391 }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[,]
                {
                    { 43, "Övre Fabriksvägen 68, Hahult, Elfenbenskusten", 4, "Hans", 1, "Svensson", 40000 },
                    { 44, "Granvägen 47, Kösta, Svalbard", 5, "Hayden", 1, "Johansson", 50190 },
                    { 45, "Södra Ekvägen 750, Esktuna, Sudan", 3, "Odessa", 1, "Johansson", 56005 },
                    { 46, "Erikssons Väg 3, Kungland, Malta", 5, "Cora", 0, "Nilsson", 34473 },
                    { 47, "Östra Skolgränden 687, Falborg, Indonesien", 9, "Mina", 1, "Larsson", 56323 },
                    { 48, "Olssons Väg 90, Båby, Polen", 3, "Hertha", 0, "Olsson", 54970 },
                    { 49, "Emilianos Gata 184, Gävås, Saint Kitts och Nevis", 7, "Keagan", 0, "Johansson", 35464 },
                    { 50, "Beaus Väg 68, Brsås, Papua Nya Guinea", 6, "Roderick", 0, "Eriksson", 49084 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Person_DepartmentId",
                table: "Person",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
