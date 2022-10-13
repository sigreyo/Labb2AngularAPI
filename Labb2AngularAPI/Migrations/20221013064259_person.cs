using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb2AngularAPI.Migrations
{
    public partial class person : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Elektronik, Skor & Klädsel");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Livsmedel & Skor");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Filmer & Leksaker");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Böcker");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Musik, Datorer & Musik");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Hem & Livsmedel");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Hem, Smycken & Musik");

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
                value: "Trädgård");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Trädgård & Smycken");

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Backvägen 72", 6, "Meggie", "Eriksson", 57813 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "FirstName", "Gender", "Salary" },
                values: new object[] { "Övre Idrottsgatan 1", "Ethyl", 1, 46532 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Bonnies Väg 12", 5, "Laurine", "Svensson", 38524 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Övre Skolallén 1", 5, "Bernadine", "Nilsson", 39515 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Johanssons Gata 16", 8, "Jackson", "Larsson", 36816 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Trevors Väg 966", 6, "Alexandrine", "Persson", 52713 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Norra Storgränden 9", 3, "Pearl", 0, "Andersson", 50988 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Alyces Gata 23", 8, "Norris", 0, "Olsson", 46579 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "Salary" },
                values: new object[] { "Nilssons Väg 8", 8, "Suzanne", 0, 54057 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Salary" },
                values: new object[] { "Olssons Väg 8", 2, "Mac", 57194 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Gengärdet 9", 10, "Kaylee", 0, "Larsson", 49268 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Undre Ekallén 88", 3, "Alessandro", "Nilsson", 34249 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Nilssons Väg 280", 9, "Kurt", "Karlsson", 58424 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Ringallén 41", 7, "Francis", "Gustafsson", 42345 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Nilssons Gata 52", 4, "Pascale", "Karlsson", 46128 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Ringgatan 581", 3, "Lavina", 1, "Johansson", 34263 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Aspgränden 8", 6, "Arnulfo", 0, "Johansson", 57488 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Övre Aspallén 88", 6, "Marcella", "Larsson", 37387 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Norra Ängsallén 84", 4, "Eino", "Johansson", 33316 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Backgatan 512", 10, "Al", 1, "Nilsson", 49675 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Ängsgränden 6", 2, "Donald", "Persson", 47111 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Enas Gata 81", 2, "Jeffery", 1, "Persson", 43525 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Övre Industrigatan 431", 5, "Giles", "Gustafsson", 40641 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Karlies Gata 1", 1, "Edwardo", 0, "Gustafsson", 39300 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Karlssons Väg 924", 6, "Abigayle", 0, "Karlsson", 45878 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "Salary" },
                values: new object[] { "Västra Björkgatan 8", 7, "Columbus", 1, 37820 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Gustafssons Gata 155", 5, "Kennith", "Svensson", 33372 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Calistas Gata 6", 1, "Anika", "Olsson", 40335 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Åkerallén 14", 6, "Tobin", "Larsson", 46021 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Salary" },
                values: new object[] { "Reeces Väg 983", 5, "Darien", 45514 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Nilssons Väg 6", 3, "Garret", 0, "Larsson", 57069 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Skogsvägen 1", 10, "Malcolm", "Eriksson", 39077 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Karlssons Gata 61", 3, "Nellie", "Nilsson", 41740 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "Salary" },
                values: new object[] { "Olssons Väg 60", 8, "America", 1, 53797 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Keegans Väg 5", 8, "Orlo", 1, "Persson", 44483 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Skogsgatan 549", 8, "Karelle", "Johansson", 32215 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Östra Backallén 5", 9, "Stephany", 1, "Gustafsson", 47741 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "Salary" },
                values: new object[] { "Olssons Gata 72", 3, "Lamont", 1, 56705 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Raphaels Väg 441", 7, "Cameron", "Nilsson", 57147 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Aimees Väg 078", 10, "Candice", "Persson", 52417 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Idrottsallén 212", "Priscilla", 0, "Gustafsson", 43242 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Skolgärdet 626", 1, "Danika", "Svensson", 39464 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Kevens Väg 882", "Garret", 0, "Andersson", 38760 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "Salary" },
                values: new object[] { "Ambers Gata 583", 9, "Vesta", 1, 53183 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Lylas Väg 188", 5, "Alicia", 1, "Eriksson", 49623 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Orens Väg 43", 5, "Selmer", "Andersson", 40627 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Östra Gengärdet 354", 9, "Effie", 1, "Gustafsson", 38011 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "Salary" },
                values: new object[] { "Kyrkogränden 982", 8, "Stefanie", 0, 53321 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Salary" },
                values: new object[] { "Åkergärdet 844", 8, "Malvina", 49101 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Västra Nygärdet 974", "Jace", 0, "Nilsson", 56103 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Klädsel");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Elektronik");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Musik & Elektronik");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Musik, Livsmedel & Trädgård");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Datorer & Verktyg");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Filmer, Trädgård & Smycken");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Trädgård & Livsmedel");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Hälsa & Trädgård");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Skönhet, Spel & Verktyg");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Filmer, Musik & Spel");

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Strandallén 183", 5, "Filomena", "Larsson", 33760 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "FirstName", "Gender", "Salary" },
                values: new object[] { "Nilssons Gata 9", "Lennie", 0, 36242 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Nilssons Väg 696", 9, "Elisa", "Johansson", 58107 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Reynas Gata 919", 9, "Olen", "Johansson", 54969 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Bessies Gata 34", 10, "Ayana", "Olsson", 34983 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Västra Kyrkvägen 93", 5, "Margie", "Eriksson", 54664 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Undre Villagatan 7", 8, "Walker", 1, "Larsson", 51664 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Genvägen 6", 6, "Kelsi", 1, "Larsson", 33115 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "Salary" },
                values: new object[] { "Jovanys Gata 4", 2, "Yasmin", 1, 34729 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Salary" },
                values: new object[] { "Karlssons Gata 7", 3, "Elmer", 51924 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Guadalupes Gata 289", 9, "Shanny", 1, "Andersson", 52146 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Lorenzas Gata 063", 6, "Dax", "Andersson", 36405 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Johanssons Gata 65", 2, "Andre", "Gustafsson", 39580 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Norra Ekgränden 7", 8, "Carole", "Eriksson", 32379 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Larssons Väg 3", 5, "Crystal", "Nilsson", 38043 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Erikssons Gata 691", 4, "Lilly", 0, "Larsson", 47518 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Asas Väg 5", 1, "Demond", 1, "Eriksson", 54380 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Norra Ängsallén 01", 3, "Hertha", "Gustafsson", 46885 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Svenssons Gata 3", 5, "Sarai", "Svensson", 55701 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Parkgatan 131", 2, "Vaughn", 0, "Svensson", 41944 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Ringgränden 314", 5, "Russ", "Svensson", 46449 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Kyrkgärdet 58", 1, "Cecelia", 0, "Olsson", 34166 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Östra Storgatan 628", 8, "Ariel", "Larsson", 56280 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Undre Fabriksgatan 559", 9, "Halie", 1, "Olsson", 51910 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Idrottsgränden 9", 4, "Ally", 1, "Persson", 35907 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "Salary" },
                values: new object[] { "Idrottsgränden 853", 10, "Arch", 0, 48438 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Östra Parkgränden 818", 9, "Aurelia", "Johansson", 49547 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Orions Väg 1", 9, "Erik", "Gustafsson", 51277 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Darwins Gata 96", 8, "Rodolfo", "Eriksson", 43626 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Salary" },
                values: new object[] { "Gustafssons Väg 84", 8, "Daphnee", 44798 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Gustafssons Väg 799", 10, "Katlyn", 1, "Gustafsson", 51820 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Nilssons Väg 00", 3, "Fiona", "Svensson", 56450 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Undre Ekgatan 505", 8, "Jacynthe", "Olsson", 46003 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "Salary" },
                values: new object[] { "Rexs Väg 792", 7, "Veronica", 0, 56314 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Västra Nygränden 149", 4, "Rex", 0, "Larsson", 53395 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Augustines Gata 3", 6, "Abner", "Olsson", 47275 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Södra Åkervägen 3", 5, "Reyes", 0, "Olsson", 46999 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "Salary" },
                values: new object[] { "Södra Idrottsgärdet 1", 9, "Timothy", 0, 57127 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Skogsgränden 263", 6, "Janet", "Persson", 45953 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Östra Åkergatan 34", 9, "Donnell", "Karlsson", 38000 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Nilssons Gata 643", "Yasmin", 1, "Larsson", 45313 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Västra Industrigärdet 8", 2, "Chester", "Gustafsson", 33079 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Nilssons Gata 4", "Rosalia", 1, "Persson", 37554 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "Salary" },
                values: new object[] { "Odas Väg 903", 2, "Ben", 0, 52951 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Skogsvägen 69", 7, "Alexandrine", 0, "Larsson", 34036 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Adans Gata 98", 4, "Camylle", "Larsson", 33657 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Benedicts Väg 966", 8, "Okey", 0, "Karlsson", 45329 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "Salary" },
                values: new object[] { "Gustafssons Väg 1", 7, "Salvador", 1, 37583 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Salary" },
                values: new object[] { "Undre Strandgränden 470", 2, "Cielo", 41964 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Åkergatan 72", "Merl", 1, "Svensson", 48165 });
        }
    }
}
