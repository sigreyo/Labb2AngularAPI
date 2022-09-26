using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb2AngularAPI.Migrations
{
    public partial class fixdepartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Department_DepartmentId",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_DepartmentId",
                table: "Person");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "PersonId" },
                values: new object[] { "Verktyg, Datorer & Datorer", null });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "PersonId" },
                values: new object[] { "Verktyg", null });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "PersonId" },
                values: new object[] { "Spel", null });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "PersonId" },
                values: new object[] { "Klädsel, Skor & Hem", null });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "PersonId" },
                values: new object[] { "Datorer", null });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "PersonId" },
                values: new object[] { "Trädgård, Böcker & Smycken", null });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "PersonId" },
                values: new object[] { "Trädgård, Musik & Filmer", null });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "PersonId" },
                values: new object[] { "Spel & Verktyg", null });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "PersonId" },
                values: new object[] { "Skor", null });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "PersonId" },
                values: new object[] { "Musik", null });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Allens Väg 12", 7, "Otto", 0, "Larsson", 53724 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Trädgårdgärdet 26", "Estevan", 0, "Persson", 52483 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Karlssons Väg 5", 2, "Elisa", 0, "Johansson", 43971 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Mazies Gata 391", 3, "Ethelyn", "Svensson", 49293 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Aspgatan 5", 3, "Kylie", "Johansson", 44243 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Donalds Gata 6", 1, "Veronica", "Gustafsson", 41597 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Södra Aspvägen 37", "Colin", 1, "Olsson", 39425 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Karlssons Gata 12", 2, "Eulalia", "Andersson", 53117 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Olssons Väg 4", 3, "Ceasar", "Eriksson", 55814 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "Salary" },
                values: new object[] { "Erikssons Gata 252", 3, "Valentin", 0, 38792 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "FirstName", "LastName", "Salary" },
                values: new object[] { "Franciscos Väg 04", "Syble", "Eriksson", 42672 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Bäckgränden 54", 4, "Jonathan", 1, "Eriksson", 34822 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Övre Industrigränden 119", 6, "Hiram", 0, "Olsson", 47221 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Larssons Väg 7", 7, "Richmond", 1, "Persson", 32813 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Cristinas Gata 685", 10, "Alicia", "Johansson", 55345 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Carrolls Väg 247", 8, "Polly", "Persson", 41230 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Horaces Gata 4", 10, "Cheyenne", "Nilsson", 39807 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Salary" },
                values: new object[] { "Kyrkoallén 5", 5, "Vernice", 54265 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Kvarngärdet 68", 4, "Caroline", "Eriksson", 41302 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Zoes Gata 585", 8, "Muriel", 0, "Larsson", 44566 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "FirstName", "Gender", "Salary" },
                values: new object[] { "Olssons Gata 627", "Everett", 0, 43760 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Erikssons Väg 716", 4, "Vergie", 1, "Karlsson", 52140 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Västra Stationsallén 76", 10, "Brenden", 1, "Gustafsson", 43340 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Trädgårdgärdet 2", 8, "Marques", 0, "Johansson", 44610 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Västra Backgatan 05", 7, "Doris", 1, "Andersson", 33152 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Södra Furuallén 2", 8, "Omer", "Eriksson", 46518 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "FirstName", "LastName", "Salary" },
                values: new object[] { "Västra Industriallén 641", "Sunny", "Nilsson", 48653 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Karlssons Gata 094", 10, "Aiden", "Johansson", 44981 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Dees Gata 976", 2, "Gerhard", "Olsson", 55288 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Svenssons Gata 1", 4, "Cody", "Nilsson", 49223 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Skolvägen 290", 7, "Ari", 1, "Andersson", 49789 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Fabriksallén 596", "Waldo", 0, "Andersson", 46096 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Merritts Gata 98", 10, "Jarrell", 1, "Andersson", 53600 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Olssons Väg 85", 8, "Pietro", "Gustafsson", 37193 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Larssons Gata 7", 9, "Vernon", 1, "Eriksson", 38955 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Övre Stationsgatan 938", 4, "Leann", 0, "Eriksson", 51309 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Övre Villagärdet 40", 3, "Kyra", "Gustafsson", 52546 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Övre Industrigränden 49", 2, "Newell", 0, "Svensson", 53952 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "Salary" },
                values: new object[] { "Ängsgatan 5", 9, "Clemmie", 0, 40541 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Erikssons Väg 10", 5, "Emerald", 0, "Svensson", 32064 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Undre Strandgatan 133", 5, "Bobbie", 1, "Johansson", 45200 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Salary" },
                values: new object[] { "Maceys Väg 70", 1, "Deion", 51085 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Östra Åkergränden 10", 7, "Chelsie", "Andersson", 44664 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Roxannes Väg 851", 4, "Ian", "Eriksson", 32647 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Grangatan 7", 4, "Quinten", "Karlsson", 58749 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Undre Åkergatan 77", 2, "Sigurd", 1, "Johansson", 37150 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Verlies Väg 651", "Deven", 0, "Johansson", 45363 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Västra Storvägen 445", 10, "Rhett", 1, "Johansson", 47522 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Wiltons Väg 916", 4, "Alfred", "Andersson", 44347 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Houstons Gata 054", 9, "Moriah", "Persson", 48167 });

            migrationBuilder.CreateIndex(
                name: "IX_Department_PersonId",
                table: "Department",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Person_PersonId",
                table: "Department",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Person_PersonId",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Department_PersonId",
                table: "Department");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "PersonId" },
                values: new object[] { "Smycken, Hälsa & Verktyg", 18 });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "PersonId" },
                values: new object[] { "Spel", 17 });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "PersonId" },
                values: new object[] { "Böcker & Filmer", 40 });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "PersonId" },
                values: new object[] { "Smycken", 42 });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "PersonId" },
                values: new object[] { "Sport", 10 });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "PersonId" },
                values: new object[] { "Leksaker & Hem", 21 });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "PersonId" },
                values: new object[] { "Livsmedel & Skor", 43 });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "PersonId" },
                values: new object[] { "Böcker & Hälsa", 7 });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "PersonId" },
                values: new object[] { "Verktyg, Skönhet & Skönhet", 50 });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "PersonId" },
                values: new object[] { "Skönhet", 32 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Loys Väg 731, Hatuna, Tjeckien", 4, "Lois", 1, "Johansson", 44369 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Idrottsgatan 6, Lyckstad, Nepal", "Jeremy", 1, "Karlsson", 52436 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Undre Skogsallén 886, Lyckmora, Komorerna", 6, "Luz", 1, "Olsson", 55997 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Parkvägen 8, Söderhamn, Egypten", 8, "Sedrick", "Larsson", 38712 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Demarcos Gata 10, Enholm, Libanon", 6, "Jamarcus", "Andersson", 56078 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Kvarnvägen 6, Avmora, Estland", 10, "Destinee", "Svensson", 35672 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Abbigails Väg 70, Enmora, Sudan", "Cecile", 0, "Johansson", 44739 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Backgränden 966, Södervik, Israel", 3, "Johann", "Svensson", 45985 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Anderssons Gata 704, Hafred, Samoa", 5, "Alyson", "Karlsson", 37000 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "Salary" },
                values: new object[] { "Annes Väg 46, Österholm, Pakistan", 8, "Bridgette", 1, 45902 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "FirstName", "LastName", "Salary" },
                values: new object[] { "Erikssons Väg 92, Helsingmora, Bosnien och Hercegovina", "Buster", "Persson", 46714 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Gustafssons Gata 4, Kungfors, Jamaica", 7, "Sophia", 0, "Olsson", 45607 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Wileys Gata 27, Båstad, Nordkorea", 1, "Doug", 1, "Karlsson", 47363 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Nygränden 3, Gävmora, Mongoliet", 8, "Nicolette", 0, "Gustafsson", 44699 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Patricias Väg 710, Avlöv, Panama", 2, "Gudrun", "Larsson", 55222 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Järnvägsallén 391, Alingholm, Vanuatu", 5, "Sydni", "Nilsson", 32294 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Aspallén 061, Eskfred, Israel", 2, "Ben", "Persson", 36564 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Salary" },
                values: new object[] { "Perssons Väg 767, Karlvik, Malta", 9, "Faustino", 38883 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Norra Ringvägen 2, Östersta, Zimbabwe", 1, "Dena", "Larsson", 57804 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Östra Backgränden 95, Kunglöv, Finland", 3, "Dee", 1, "Andersson", 45269 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "FirstName", "Gender", "Salary" },
                values: new object[] { "Södra Backgränden 882, Falhult, USA", "Sabina", 1, 35429 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Västra Aspallén 9, Arfors, Dominica", 8, "Elza", 0, "Persson", 39699 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Karlssons Väg 972, Gävberg, Ryssland", 5, "Patricia", 0, "Johansson", 39355 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Norra Ringgatan 82, Kramby, Fiji", 1, "Connor", 1, "Svensson", 37975 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Patiences Gata 68, Kramholm, El Salvador", 4, "Lulu", 0, "Nilsson", 55147 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Östra Åkergärdet 288, Västhult, Mauretanien", 10, "Elouise", "Larsson", 53127 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "FirstName", "LastName", "Salary" },
                values: new object[] { "Larssons Väg 7, Falmora, Danmark", "Irma", "Larsson", 50639 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Stationsvägen 5, Karltuna, El Salvador", 6, "Llewellyn", "Karlsson", 58308 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Gustafssons Väg 7, Söderstad, Vanuatu", 1, "Adela", "Eriksson", 45413 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Jessikas Väg 96, Falberg, Nigeria", 3, "Bill", "Gustafsson", 56461 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Genallén 8, Envik, Kanada", 10, "Chandler", 0, "Karlsson", 57706 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Perssons Väg 494, Bovik, Danmark", "Estefania", 1, "Persson", 32461 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Skolgränden 304, Götemora, Centralafrikanska republiken", 6, "Lauretta", 0, "Eriksson", 36005 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Undre Ringgärdet 98, Kungby, Samoa", 10, "Carlotta", "Persson", 50203 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Södra Furugatan 12, Väststad, Madagaskar", 2, "Norris", 0, "Nilsson", 57710 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Dashawns Gata 271, Västås, Pakistan", 8, "Bryce", 1, "Karlsson", 32068 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Skolgatan 924, Boås, Moçambique", 10, "Bella", "Karlsson", 41270 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Erikssons Gata 8, Österland, Kuwait", 8, "Toni", 1, "Gustafsson", 50548 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "Salary" },
                values: new object[] { "Larssons Väg 578, Kriststad, Haiti", 3, "Hanna", 1, 45510 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Gustafssons Väg 82, Kristtuna, Argentina", 3, "Camila", 1, "Larsson", 53090 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Undre Ekgatan 631, Helsingberg, Malawi", 6, "Joanie", 0, "Persson", 55135 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Salary" },
                values: new object[] { "Perssons Gata 09, Bosta, Antigua och Barbuda", 9, "Maya", 52391 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Övre Fabriksvägen 68, Hahult, Elfenbenskusten", 4, "Hans", "Svensson", 40000 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Granvägen 47, Kösta, Svalbard", 5, "Hayden", "Johansson", 50190 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Södra Ekvägen 750, Esktuna, Sudan", 3, "Odessa", "Johansson", 56005 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Erikssons Väg 3, Kungland, Malta", 5, "Cora", 0, "Nilsson", 34473 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Östra Skolgränden 687, Falborg, Indonesien", "Mina", 1, "Larsson", 56323 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Olssons Väg 90, Båby, Polen", 3, "Hertha", 0, "Olsson", 54970 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Emilianos Gata 184, Gävås, Saint Kitts och Nevis", 7, "Keagan", "Johansson", 35464 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Beaus Väg 68, Brsås, Papua Nya Guinea", 6, "Roderick", "Eriksson", 49084 });

            migrationBuilder.CreateIndex(
                name: "IX_Person_DepartmentId",
                table: "Person",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Department_DepartmentId",
                table: "Person",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id");
        }
    }
}
