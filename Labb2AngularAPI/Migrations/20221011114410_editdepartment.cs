using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb2AngularAPI.Migrations
{
    public partial class editdepartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Nilssons Gata 9", 1, "Lennie", 0, "Johansson", 36242 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Nilssons Väg 696", "Elisa", 0, "Johansson", 58107 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Reynas Gata 919", 9, "Olen", 0, "Johansson", 54969 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Västra Kyrkvägen 93", 5, "Margie", 0, "Eriksson", 54664 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "Salary" },
                values: new object[] { "Undre Villagatan 7", 8, "Walker", 1, 51664 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Genvägen 6", 6, "Kelsi", "Larsson", 33115 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Jovanys Gata 4", "Yasmin", 1, "Olsson", 34729 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Karlssons Gata 7", 3, "Elmer", "Persson", 51924 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Guadalupes Gata 289", 9, "Shanny", "Andersson", 52146 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Norra Ekgränden 7", 8, "Carole", 0, "Eriksson", 32379 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "FirstName", "LastName", "Salary" },
                values: new object[] { "Larssons Väg 3", "Crystal", "Nilsson", 38043 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Erikssons Gata 691", 4, "Lilly", "Larsson", 47518 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Asas Väg 5", 1, "Demond", "Eriksson", 54380 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Norra Ängsallén 01", 3, "Hertha", 0, "Gustafsson", 46885 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Svenssons Gata 3", 5, "Sarai", 0, "Svensson", 55701 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Kyrkgärdet 58", 1, "Cecelia", "Olsson", 34166 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Östra Storgatan 628", 8, "Ariel", 0, "Larsson", 56280 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Undre Fabriksgatan 559", 9, "Halie", "Olsson", 51910 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Idrottsgränden 853", 10, "Arch", "Andersson", 48438 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Darwins Gata 96", 8, "Rodolfo", 0, "Eriksson", 43626 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Gustafssons Väg 84", 8, "Daphnee", 1, "Larsson", 44798 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Gustafssons Väg 799", 10, "Katlyn", "Gustafsson", 51820 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Salary" },
                values: new object[] { "Nilssons Väg 00", 3, "Fiona", 56450 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Rexs Väg 792", 7, "Veronica", "Eriksson", 56314 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "FirstName", "LastName", "Salary" },
                values: new object[] { "Västra Nygränden 149", "Rex", "Larsson", 53395 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Augustines Gata 3", 6, "Abner", 1, "Olsson", 47275 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Södra Idrottsgärdet 1", 9, "Timothy", "Larsson", 57127 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Salary" },
                values: new object[] { "Skogsgränden 263", 6, "Janet", 45953 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Nilssons Gata 643", 8, "Yasmin", "Larsson", 45313 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Nilssons Gata 4", 8, "Rosalia", "Persson", 37554 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Odas Väg 903", 2, "Ben", "Karlsson", 52951 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Skogsvägen 69", 7, "Alexandrine", "Larsson", 34036 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Adans Gata 98", 4, "Camylle", 0, "Larsson", 33657 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Benedicts Väg 966", "Okey", 0, "Karlsson", 45329 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "FirstName", "LastName", "Salary" },
                values: new object[] { "Gustafssons Väg 1", "Salvador", "Andersson", 37583 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Undre Strandgränden 470", 2, "Cielo", 1, "Karlsson", 41964 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Åkergatan 72", 9, "Merl", "Svensson", 48165 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Larssons Gata 1", 8, "Ashtyn", "Eriksson", 44064 });

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
                columns: new[] { "Address", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Kyrkovägen 129", "Isaiah", 1, "Persson", 54207 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Ringgatan 8", 3, "Roberta", 1, "Eriksson", 48260 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Austins Väg 1", 1, "Raphaelle", 1, "Persson", 56208 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "Salary" },
                values: new object[] { "Ekgatan 64", 6, "Darius", 0, 34099 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Stationsallén 7", 2, "Brielle", "Johansson", 35261 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Gengärdet 94", "Moises", 0, "Eriksson", 33118 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Candelarios Väg 406", 10, "Katelyn", "Nilsson", 54619 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Erikssons Gata 147", 4, "Columbus", "Johansson", 32174 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Mortons Väg 8", 10, "Queen", "Olsson", 36662 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Östra Idrottsgränden 92", 3, "Bruce", 1, "Nilsson", 34469 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "FirstName", "LastName", "Salary" },
                values: new object[] { "Norra Villavägen 23", "Jazmin", "Larsson", 50831 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Stanfords Gata 2", 2, "Myles", 1, "Svensson", 40567 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Francescos Gata 81", 4, "Waylon", 1, "Larsson", 55698 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Gustafssons Gata 01", 3, "Kayley", "Svensson", 49037 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Erikssons Gata 80", 3, "Reuben", 1, "Gustafsson", 50897 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Karlssons Gata 45", 5, "Addie", "Karlsson", 34953 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Kyrkogränden 337", 3, "Raheem", "Karlsson", 43810 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Aspgränden 41", 5, "Cornelius", "Gustafsson", 58064 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Perssons Gata 89", 7, "Maryam", 1, "Karlsson", 43193 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "Salary" },
                values: new object[] { "Anderssons Gata 667", 5, "Charley", 45334 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Heloises Gata 7", 3, "Ryann", "Karlsson", 52604 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Hillards Gata 5", 1, "Novella", "Persson", 48278 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "FirstName", "LastName", "Salary" },
                values: new object[] { "Idrottsgränden 038", "Lloyd", "Eriksson", 53489 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Skogsallén 11", 9, "Keyon", 0, "Eriksson", 34308 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Järnvägsallén 42", 10, "Susan", 1, "Svensson", 41746 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "Salary" },
                values: new object[] { "Tierras Gata 529", 8, "Anahi", 41561 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Perssons Gata 740", 3, "Gregoria", "Svensson", 41946 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Perssons Gata 21", 1, "Naomi", "Eriksson", 53879 });

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
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Freedas Gata 7", 8, "Elody", "Gustafsson", 54048 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Östra Stationsgärdet 894", 6, "Alanna", "Gustafsson", 40354 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Ringgatan 87", 7, "Nestor", 1, "Johansson", 36116 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Södra Ekgatan 3", "Yasmeen", 1, "Svensson", 44871 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "FirstName", "LastName", "Salary" },
                values: new object[] { "Everettes Gata 169", "Branson", "Gustafsson", 54538 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "DepartmentId", "FirstName", "Gender", "LastName", "Salary" },
                values: new object[] { "Storgärdet 169", 6, "Carole", 0, "Svensson", 40545 });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[] { "Lethas Väg 11", 10, "Jana", "Persson", 43744 });
        }
    }
}
