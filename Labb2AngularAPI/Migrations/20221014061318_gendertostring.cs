using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb2AngularAPI.Migrations
{
    public partial class gendertostring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Person",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Leksaker, Filmer & Elektronik");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Datorer & Musik");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Böcker, Spel & Elektronik");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Hälsa & Sport");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Smycken");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Böcker");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Leksaker & Spel");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Musik & Smycken");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Elektronik, Smycken & Livsmedel");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Musik, Trädgård & Verktyg");

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Norra Kvarngränden 94", "Petra", "Female", "Andersson", 49331 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Västra Ekgatan 2", 7, "Ettie", "Male", "Eriksson", 42346 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Anderssons Väg 67", 4, "Mertie", "Female", "Gustafsson", 42545 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Olssons Gata 1", 8, "Caleigh", "Male", "Olsson", 44066 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Trädgårdgatan 88", 7, "Giuseppe", "Male", "Persson", 36008 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Övre Industriallén 851", 2, "Antonina", "Male", "Olsson", 49054 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Erikssons Gata 586", 10, "Durward", "Female", "Karlsson", 33288 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Maximilians Gata 2", 2, "Ottis", "Female", "Nilsson", 49025 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Övre Parkallén 708", 3, "Kendall", "Male", "Nilsson", 50078 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Bäckallén 133", 9, "Mortimer", "Female", "Eriksson", 42641 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Anderssons Gata 2", 2, "Angelita", "Male", "Eriksson", 58970 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Reannas Gata 282", 4, "Fermin", "Male", "Eriksson", 42320 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Abbeys Gata 35", 6, "Consuelo", "Male", "Nilsson", 46889 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Trädgårdallén 419", 3, "Jimmy", "Male", "Andersson", 34921 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Erikssons Väg 199", 1, "Britney", "Male", "Olsson", 42927 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Johnathons Väg 63", 4, "Yasmin", "Female", "Larsson", 45087 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Övre Kyrkvägen 1", 10, "Mollie", "Female", "Larsson", 43403 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "Salary" },
                values: new object[] { "Undre Backgatan 079", 1, "Isobel", "Female", 32265 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Wilfrids Väg 942", 3, "Stewart", "Female", "Karlsson", 49991 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Olssons Gata 4", 7, "Else", "Female", "Gustafsson", 55158 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Rashads Gata 8", 8, "Deborah", "Female", "Eriksson", 34816 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Aidans Gata 06", 9, "Immanuel", "Female", "Larsson", 34986 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Norra Stationsgränden 7", "Celia", "Female", "Johansson", 55809 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Undre Stationsvägen 28", 10, "Payton", "Female", "Persson", 47847 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Jaquelines Gata 832", 10, "Andrew", "Male", "Svensson", 44361 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Strandallén 274", 3, "Hobart", "Male", "Karlsson", 38039 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Övre Åkergränden 87", 9, "Leatha", "Female", "Nilsson", 54156 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Erwins Väg 196", 9, "Gabriella", "Female", "Eriksson", 41477 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Aspvägen 677", 9, "Bobby", "Male", "Karlsson", 38287 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Gustafssons Gata 847", 7, "Myrna", "Male", "Eriksson", 38910 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Salvadors Gata 13", 8, "Melba", "Female", "Olsson", 56915 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "Salary" },
                values: new object[] { "Anderssons Väg 34", 5, "Kelley", "Male", 51015 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Adellas Väg 89", 4, "Reva", "Male", "Eriksson", 48483 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Karlssons Väg 5", 7, "Jerod", "Female", "Andersson", 55385 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Södra Furugärdet 17", "Rosie", "Female", "Larsson", 52595 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Ekgatan 59", "Gerda", "Male", "Eriksson", 57229 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Södra Granvägen 4", 5, "Gilda", "Male", "Olsson", 33837 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "Salary" },
                values: new object[] { "Undre Kvarnvägen 43", 6, "Trisha", "Female", 58876 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Marcuss Väg 728", 2, "Davonte", "Female", "Persson", 46418 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Griffins Gata 9", 6, "Treva", "Male", "Svensson", 51569 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Stationsgränden 16", 2, "Andy", "Male", "Andersson", 46287 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Genvägen 4", "Caden", "Male", "Gustafsson", 58149 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Nygatan 256", 10, "Jasper", "Male", "Nilsson", 37425 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Västra Furugärdet 62", 2, "Sunny", "Male", "Nilsson", 54952 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Gustafssons Väg 414", 6, "Michale", "Male", "Johansson", 49048 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Huberts Gata 36", 4, "Jailyn", "Male", "Svensson", 38792 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Jaunitas Väg 21", 5, "Patrick", "Male", "Andersson", 39783 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Kyrkogärdet 13", 3, "Michele", "Female", "Svensson", 50228 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Carlies Gata 632", 4, "Rudolph", "Female", "Nilsson", 51071 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Granvägen 539", 6, "Javonte", "Female", "Gustafsson", 54205 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "Person",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                columns: new[] { "Address", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Backvägen 72", "Meggie", 1, "Eriksson", 57813 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Övre Idrottsgatan 1", 1, "Ethyl", 1, "Johansson", 46532 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Bonnies Väg 12", 5, "Laurine", 0, "Svensson", 38524 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Övre Skolallén 1", 5, "Bernadine", 0, "Nilsson", 39515 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Johanssons Gata 16", 8, "Jackson", 1, "Larsson", 36816 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Trevors Väg 966", 6, "Alexandrine", 0, "Persson", 52713 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Nilssons Väg 8", 8, "Suzanne", 0, "Olsson", 54057 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Olssons Väg 8", 2, "Mac", 1, "Persson", 57194 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Undre Ekallén 88", 3, "Alessandro", 1, "Nilsson", 34249 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Nilssons Väg 280", 9, "Kurt", 1, "Karlsson", 58424 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Ringallén 41", 7, "Francis", 0, "Gustafsson", 42345 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Nilssons Gata 52", 4, "Pascale", 0, "Karlsson", 46128 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "Salary" },
                values: new object[] { "Övre Aspallén 88", 6, "Marcella", 0, 37387 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Norra Ängsallén 84", 4, "Eino", 0, "Johansson", 33316 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Ängsgränden 6", 2, "Donald", 0, "Persson", 47111 });

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
                columns: new[] { "Address", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Övre Industrigatan 431", "Giles", 0, "Gustafsson", 40641 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Västra Björkgatan 8", 7, "Columbus", 1, "Andersson", 37820 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Gustafssons Gata 155", 5, "Kennith", 1, "Svensson", 33372 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Calistas Gata 6", 1, "Anika", 1, "Olsson", 40335 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Åkerallén 14", 6, "Tobin", 0, "Larsson", 46021 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Reeces Väg 983", 5, "Darien", 1, "Larsson", 45514 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "Salary" },
                values: new object[] { "Skogsvägen 1", 10, "Malcolm", 0, 39077 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Karlssons Gata 61", 3, "Nellie", 0, "Nilsson", 41740 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Olssons Väg 60", 8, "America", 1, "Eriksson", 53797 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Keegans Väg 5", "Orlo", 1, "Persson", 44483 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Skogsgatan 549", "Karelle", 1, "Johansson", 32215 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Raphaels Väg 441", 7, "Cameron", 0, "Nilsson", 57147 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Aimees Väg 078", 10, "Candice", 0, "Persson", 52417 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Idrottsallén 212", 8, "Priscilla", 0, "Gustafsson", 43242 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Skolgärdet 626", "Danika", 1, "Svensson", 39464 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Kevens Väg 882", 8, "Garret", 0, "Andersson", 38760 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Ambers Gata 583", 9, "Vesta", 1, "Karlsson", 53183 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Orens Väg 43", 5, "Selmer", 0, "Andersson", 40627 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Kyrkogränden 982", 8, "Stefanie", 0, "Andersson", 53321 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Åkergärdet 844", 8, "Malvina", 1, "Karlsson", 49101 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Västra Nygärdet 974", 9, "Jace", 0, "Nilsson", 56103 });
        }
    }
}
