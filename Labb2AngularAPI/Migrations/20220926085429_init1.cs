using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb2AngularAPI.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Skor, Skor & Verktyg");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Spel");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Hälsa");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Hem & Skönhet");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Musik, Klädsel & Smycken");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Spel & Filmer");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Skor, Klädsel & Hälsa");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Leksaker");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Livsmedel");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Böcker, Klädsel & Livsmedel");

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Larssons Gata 1", 8, "Ashtyn", 1, "Eriksson", 44064 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Domenicks Väg 0", 5, "Aletha", 1, "Olsson", 50869 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Kyrkovägen 129", 9, "Isaiah", 1, "Persson", 54207 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "FirstName", "LastName", "Salary" },
                values: new object[] { "Ringgatan 8", "Roberta", "Eriksson", 48260 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Undre Bäckgatan 25", 8, "Lonzo", "Svensson", 44361 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "FirstName", "LastName", "Salary" },
                values: new object[] { "Austins Väg 1", "Raphaelle", "Persson", 56208 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Ekgatan 64", 6, "Darius", 0, "Larsson", 34099 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Stationsallén 7", "Brielle", 1, "Johansson", 35261 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Salary" },
                values: new object[] { "Gengärdet 94", 2, "Moises", 33118 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Candelarios Väg 406", 10, "Katelyn", 1, "Nilsson", 54619 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Erikssons Gata 147", 4, "Columbus", 1, "Johansson", 32174 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Kyrkogränden 238", 2, "Aisha", "Nilsson", 46736 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "Salary" },
                values: new object[] { "Mortons Väg 8", 10, "Queen", 1, 36662 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Östra Idrottsgränden 92", 3, "Bruce", "Nilsson", 34469 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Norra Villavägen 23", 5, "Jazmin", 0, "Larsson", 50831 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Daphnees Gata 9", 3, "Tito", "Olsson", 36732 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Östra Björkgärdet 0", 8, "Adrienne", "Andersson", 40735 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Salary" },
                values: new object[] { "Stanfords Gata 2", 2, "Myles", 40567 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "FirstName", "LastName", "Salary" },
                values: new object[] { "Francescos Gata 81", "Waylon", "Larsson", 55698 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Övre Aspgränden 593", 3, "Rashawn", 1, "Olsson", 44283 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Undre Ängsgränden 7", 10, "Deon", "Olsson", 44905 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Gustafssons Gata 01", 3, "Kayley", 0, "Svensson", 49037 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Salary" },
                values: new object[] { "Erikssons Gata 80", 3, "Reuben", 50897 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Karlssons Gata 45", 5, "Addie", 1, "Karlsson", 34953 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Erikssons Väg 180", 1, "Jay", 0, "Svensson", 41650 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Kyrkogränden 337", 3, "Raheem", 0, "Karlsson", 43810 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Aspgränden 41", 5, "Cornelius", 1, "Gustafsson", 58064 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Furugränden 2", 3, "Estel", "Olsson", 55654 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Perssons Gata 89", 7, "Maryam", "Karlsson", 43193 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Gustafssons Gata 7", 10, "Dorcas", 0, "Olsson", 39737 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Undre Aspgärdet 43", 6, "Jennings", "Larsson", 35503 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "FirstName", "LastName", "Salary" },
                values: new object[] { "Anderssons Gata 667", "Charley", "Svensson", 45334 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Heloises Gata 7", 3, "Ryann", 0, "Karlsson", 52604 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Hillards Gata 5", 1, "Novella", 0, "Persson", 48278 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "Salary" },
                values: new object[] { "Idrottsgränden 038", 4, "Lloyd", 0, 53489 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Salary" },
                values: new object[] { "Skogsallén 11", 9, "Keyon", 34308 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Järnvägsallén 42", 10, "Susan", "Svensson", 41746 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Strandallén 2", 8, "Colt", "Gustafsson", 36065 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Tierras Gata 529", 8, "Anahi", "Persson", 41561 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Salary" },
                values: new object[] { "Perssons Gata 740", 3, "Gregoria", 41946 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Perssons Gata 4", 7, "Darrick", "Svensson", 51974 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "FirstName", "Gender", "Salary" },
                values: new object[] { "Perssons Gata 21", "Naomi", 1, 53879 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Södra Villagärdet 618", 10, "Hassie", "Karlsson", 56740 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Freedas Gata 7", 8, "Elody", 0, "Gustafsson", 54048 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Östra Stationsgärdet 894", 6, "Alanna", 0, "Gustafsson", 40354 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Salary" },
                values: new object[] { "Ringgatan 87", 7, "Nestor", 36116 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Södra Ekgatan 3", 8, "Yasmeen", 1, "Svensson", 44871 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Everettes Gata 169", 7, "Branson", "Gustafsson", 54538 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Storgärdet 169", 6, "Carole", "Svensson", 40545 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "Salary" },
                values: new object[] { "Lethas Väg 11", 10, "Jana", 1, 43744 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Verktyg, Datorer & Datorer");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Verktyg");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Spel");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Klädsel, Skor & Hem");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Datorer");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Trädgård, Böcker & Smycken");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Trädgård, Musik & Filmer");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Spel & Verktyg");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Skor");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Musik");

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Trädgårdgärdet 26", 10, "Estevan", 0, "Persson", 52483 });

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
                columns: new[] { "Address", "FirstName", "LastName", "Salary" },
                values: new object[] { "Mazies Gata 391", "Ethelyn", "Svensson", 49293 });

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
                columns: new[] { "Address", "FirstName", "LastName", "Salary" },
                values: new object[] { "Donalds Gata 6", "Veronica", "Gustafsson", 41597 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Södra Aspvägen 37", 2, "Colin", 1, "Olsson", 39425 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Karlssons Gata 12", "Eulalia", 0, "Andersson", 53117 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Salary" },
                values: new object[] { "Olssons Väg 4", 3, "Ceasar", 55814 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Erikssons Gata 252", 3, "Valentin", 0, "Svensson", 38792 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Franciscos Väg 04", 6, "Syble", 0, "Eriksson", 42672 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Bäckgränden 54", 4, "Jonathan", "Eriksson", 34822 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "Salary" },
                values: new object[] { "Övre Industrigränden 119", 6, "Hiram", 0, 47221 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Larssons Väg 7", 7, "Richmond", "Persson", 32813 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Cristinas Gata 685", 10, "Alicia", 1, "Johansson", 55345 });

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
                columns: new[] { "Address", "FirstName", "LastName", "Salary" },
                values: new object[] { "Kvarngärdet 68", "Caroline", "Eriksson", 41302 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Olssons Gata 627", 7, "Everett", "Nilsson", 43760 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "Salary" },
                values: new object[] { "Västra Stationsallén 76", 10, "Brenden", 43340 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Södra Furuallén 2", 8, "Omer", 1, "Eriksson", 46518 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Västra Industriallén 641", 1, "Sunny", 0, "Nilsson", 48653 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Svenssons Gata 1", 4, "Cody", 1, "Nilsson", 49223 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Skolvägen 290", 7, "Ari", "Andersson", 49789 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "FirstName", "LastName", "Salary" },
                values: new object[] { "Fabriksallén 596", "Waldo", "Andersson", 46096 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Olssons Väg 85", 8, "Pietro", 1, "Gustafsson", 37193 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "Salary" },
                values: new object[] { "Larssons Gata 7", 9, "Vernon", 1, 38955 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Salary" },
                values: new object[] { "Övre Stationsgatan 938", 4, "Leann", 51309 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Övre Industrigränden 49", 2, "Newell", "Svensson", 53952 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Ängsgatan 5", 9, "Clemmie", "Andersson", 40541 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Salary" },
                values: new object[] { "Erikssons Väg 10", 5, "Emerald", 32064 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Undre Strandgatan 133", 5, "Bobbie", "Johansson", 45200 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "FirstName", "Gender", "Salary" },
                values: new object[] { "Maceys Väg 70", "Deion", 0, 51085 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Roxannes Väg 851", 4, "Ian", 1, "Eriksson", 32647 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Grangatan 7", 4, "Quinten", 1, "Karlsson", 58749 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Salary" },
                values: new object[] { "Undre Åkergatan 77", 2, "Sigurd", 37150 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Verlies Väg 651", 9, "Deven", 0, "Johansson", 45363 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Västra Storvägen 445", 10, "Rhett", "Johansson", 47522 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "Salary" },
                values: new object[] { "Houstons Gata 054", 9, "Moriah", 0, 48167 });
        }
    }
}
