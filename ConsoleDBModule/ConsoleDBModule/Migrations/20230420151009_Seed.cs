using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConsoleDBModule.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artist",
                columns: new[] { "ArtistId", "DateOfBirth", "DateOfDeath", "EMail", "InstagramUrl", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, new DateTime(1970, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "https://www.instagram.com/aerosmith/", "Aerosmith", null },
                    { 2, new DateTime(1974, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "https://www.instagram.com/andrudonalds/", "Andru Donalds", null },
                    { 3, new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "https://www.instagram.com/muse/", "Muse", null },
                    { 4, new DateTime(1982, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "https://www.instagram.com/adamlambert/", "Adam Lambert", null },
                    { 5, new DateTime(1979, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "https://www.instagram.com/Pink/", "Pink", null }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "GenreId", "Title" },
                values: new object[,]
                {
                    { 1, "Rock" },
                    { 2, "Pop-Rock" },
                    { 3, "Jazz" },
                    { 4, "Funk-Rock" }
                });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "SongId", "Duration", "GenreId", "ReleasedDate", "Title" },
                values: new object[,]
                {
                    { 1, new TimeSpan(0, 4, 28, 0, 0), 1, new DateTime(1973, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dream on" },
                    { 2, new TimeSpan(0, 2, 53, 0, 0), 3, new DateTime(1964, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Feeling Good" },
                    { 3, new TimeSpan(0, 3, 47, 0, 0), 2, new DateTime(2009, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Whataya Want from Me" },
                    { 4, new TimeSpan(0, 5, 16, 0, 0), 1, new DateTime(1994, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crazy" },
                    { 5, new TimeSpan(0, 3, 29, 0, 0), 4, new DateTime(2006, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Supermassive Black Hole" }
                });

            migrationBuilder.InsertData(
                table: "SongArtists",
                columns: new[] { "ArtistId", "SongId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 2 },
                    { 4, 3 },
                    { 5, 3 },
                    { 1, 4 },
                    { 3, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SongArtists",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "SongArtists",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "SongArtists",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "SongArtists",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "SongArtists",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "SongArtists",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "SongArtists",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "SongArtists",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "SongId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "SongId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "SongId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "SongId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "SongId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: 4);
        }
    }
}
