using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraphQLAPI.Migrations
{
    public partial class newmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Superheroes_SuperheroId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_SuperheroId",
                table: "Movies");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("0654b69c-8993-424c-a49c-94304f4d8c73"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("184b55df-8b69-4a05-86e5-c2afc8ee3cd5"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("65aa9ba5-9216-4911-a602-eb2c48c02978"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9182ca79-6571-4923-b5d0-c9b97f7b3b2c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("bae14098-b011-4e2a-8097-4672c14b20b8"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d4d28f82-1e82-47d9-9129-ec822924b4d4"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ff5b8b94-e27e-4330-ae16-f58d6a939bd0"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("40cfb4b8-1a2c-48a8-8648-b15d546f2432"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("4760351f-001f-4a7e-9b96-77fc8fabbb19"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("7cb5b2c3-efc8-4093-81a0-58fd15f0c540"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("a13816da-a48d-47b4-bdef-280022f986e2"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("be451af4-2a31-4b82-a437-a62ceaf8a046"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("c046bc1a-36d7-47c5-9eab-db9af761c3c0"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("cae4dadc-1b0b-4383-bac1-b4931a418e6d"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("20493288-fd97-4145-bf06-27e7911e3c61"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("214f9878-37ce-4497-85f4-c4a21162b258"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("c959c30a-cf5d-46c9-9e99-99a0af4e8c1c"));

            migrationBuilder.DropColumn(
                name: "SuperheroId",
                table: "Movies");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("6f89f8e6-318f-4bb8-9270-e7c6dc987448"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black Widow" },
                    { new Guid("76f7aed0-f53c-4e58-ad86-cfa3f9c8490f"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight" },
                    { new Guid("7a483ef3-356b-4ede-b2f1-25dbd56e474f"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight Rises" },
                    { new Guid("877b92f1-97b7-4535-8fbf-66cd23f53d58"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Episode VI – Return of the Jedi" },
                    { new Guid("90650fa9-fe2b-4be2-a004-381806db63b5"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman Begins" },
                    { new Guid("f282a91e-1f9d-48c9-87fc-053e353a0a81"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("f718576b-96e7-4133-a70f-0c5a38a25fde"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Episode V – The Empire Strikes Back" }
                });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[,]
                {
                    { new Guid("25d9da60-d717-4630-b250-fa737b26660a"), "Batman is a superhero who appears in American comic books published by DC Comics. The character was created by artist Bob Kane and writer Bill Finger, and first appeared in Detective Comics #27 (May 1939). Originally", "6'2", "Batman" },
                    { new Guid("579a5cd1-b2a1-406f-bebb-68a8d2140bae"), "Luke Skywalker is a fictional character and the main protagonist of the original film trilogy of the Star Wars franchise created by George Lucas. He is portrayed by Mark Hamill in the original trilogy and by Hayden Christensen in the prequel trilogy.", "5'11", "Luke Skywalker" },
                    { new Guid("5c39e387-ed5a-45d1-bebc-bdef6f254677"), "Superman is a fictional superhero appearing in American comic books published by DC Comics. The character was created by writer Jerry Siegel and artist Joe Shuster, high school students living in Cleveland, Ohio, in 1933.", "6'3", "Superman" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("115306c3-1720-4c6e-8782-20f91e8b8c90"), "He's always a step ahead.", "Intellect.", new Guid("25d9da60-d717-4630-b250-fa737b26660a") },
                    { new Guid("43e2151c-8bb7-4fd4-b1ef-f2d700a988b5"), "Sublime fighting skills.", "Fighting", new Guid("25d9da60-d717-4630-b250-fa737b26660a") },
                    { new Guid("5fcab2f4-ba7c-41e1-adcc-b771eb24cea9"), "She's good at spying at people.", "Espionage", new Guid("579a5cd1-b2a1-406f-bebb-68a8d2140bae") },
                    { new Guid("aa31bd3b-fefb-4eb9-a0db-065d3f70449a"), "He got a lot of money", "Wealth.", new Guid("25d9da60-d717-4630-b250-fa737b26660a") },
                    { new Guid("b1c91cff-1764-4fbd-8c4c-a1270bfbc5f6"), "The knowledge of how to undermine others.", "Subterfuge", new Guid("579a5cd1-b2a1-406f-bebb-68a8d2140bae") },
                    { new Guid("d6184e4e-00b1-4f7c-9dd3-8846a30a0311"), "She knows how to infiltrate the enemy.", "Infiltration", new Guid("579a5cd1-b2a1-406f-bebb-68a8d2140bae") },
                    { new Guid("df4df487-799d-45c3-8e0c-4d319358964e"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power.", new Guid("5c39e387-ed5a-45d1-bebc-bdef6f254677") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6f89f8e6-318f-4bb8-9270-e7c6dc987448"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("76f7aed0-f53c-4e58-ad86-cfa3f9c8490f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7a483ef3-356b-4ede-b2f1-25dbd56e474f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("877b92f1-97b7-4535-8fbf-66cd23f53d58"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("90650fa9-fe2b-4be2-a004-381806db63b5"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("f282a91e-1f9d-48c9-87fc-053e353a0a81"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("f718576b-96e7-4133-a70f-0c5a38a25fde"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("115306c3-1720-4c6e-8782-20f91e8b8c90"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("43e2151c-8bb7-4fd4-b1ef-f2d700a988b5"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("5fcab2f4-ba7c-41e1-adcc-b771eb24cea9"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("aa31bd3b-fefb-4eb9-a0db-065d3f70449a"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("b1c91cff-1764-4fbd-8c4c-a1270bfbc5f6"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("d6184e4e-00b1-4f7c-9dd3-8846a30a0311"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("df4df487-799d-45c3-8e0c-4d319358964e"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("25d9da60-d717-4630-b250-fa737b26660a"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("579a5cd1-b2a1-406f-bebb-68a8d2140bae"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("5c39e387-ed5a-45d1-bebc-bdef6f254677"));

            migrationBuilder.AddColumn<Guid>(
                name: "SuperheroId",
                table: "Movies",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[] { new Guid("20493288-fd97-4145-bf06-27e7911e3c61"), "Batman is a superhero who appears in American comic books published by DC Comics. The character was created by artist Bob Kane and writer Bill Finger, and first appeared in Detective Comics #27 (May 1939). Originally", "6'2", "Batman" });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[] { new Guid("214f9878-37ce-4497-85f4-c4a21162b258"), "Luke Skywalker is a fictional character and the main protagonist of the original film trilogy of the Star Wars franchise created by George Lucas. He is portrayed by Mark Hamill in the original trilogy and by Hayden Christensen in the prequel trilogy.", "5'11", "Luke Skywalker" });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[] { new Guid("c959c30a-cf5d-46c9-9e99-99a0af4e8c1c"), "Superman is a fictional superhero appearing in American comic books published by DC Comics. The character was created by writer Jerry Siegel and artist Joe Shuster, high school students living in Cleveland, Ohio, in 1933.", "6'3", "Superman" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "SuperheroId", "Title" },
                values: new object[,]
                {
                    { new Guid("0654b69c-8993-424c-a49c-94304f4d8c73"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("214f9878-37ce-4497-85f4-c4a21162b258"), "Black Widow" },
                    { new Guid("184b55df-8b69-4a05-86e5-c2afc8ee3cd5"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c959c30a-cf5d-46c9-9e99-99a0af4e8c1c"), "Star Wars: Episode VI – Return of the Jedi" },
                    { new Guid("65aa9ba5-9216-4911-a602-eb2c48c02978"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c959c30a-cf5d-46c9-9e99-99a0af4e8c1c"), "Star Wars: Episode V – The Empire Strikes Back" },
                    { new Guid("9182ca79-6571-4923-b5d0-c9b97f7b3b2c"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("20493288-fd97-4145-bf06-27e7911e3c61"), "The Dark Knight" },
                    { new Guid("bae14098-b011-4e2a-8097-4672c14b20b8"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c959c30a-cf5d-46c9-9e99-99a0af4e8c1c"), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("d4d28f82-1e82-47d9-9129-ec822924b4d4"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("20493288-fd97-4145-bf06-27e7911e3c61"), "The Dark Knight Rises" },
                    { new Guid("ff5b8b94-e27e-4330-ae16-f58d6a939bd0"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("20493288-fd97-4145-bf06-27e7911e3c61"), "Batman Begins" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("40cfb4b8-1a2c-48a8-8648-b15d546f2432"), "The knowledge of how to undermine others.", "Subterfuge", new Guid("214f9878-37ce-4497-85f4-c4a21162b258") },
                    { new Guid("4760351f-001f-4a7e-9b96-77fc8fabbb19"), "He got a lot of money", "Wealth.", new Guid("20493288-fd97-4145-bf06-27e7911e3c61") },
                    { new Guid("7cb5b2c3-efc8-4093-81a0-58fd15f0c540"), "He's always a step ahead.", "Intellect.", new Guid("20493288-fd97-4145-bf06-27e7911e3c61") },
                    { new Guid("a13816da-a48d-47b4-bdef-280022f986e2"), "She's good at spying at people.", "Espionage", new Guid("214f9878-37ce-4497-85f4-c4a21162b258") },
                    { new Guid("be451af4-2a31-4b82-a437-a62ceaf8a046"), "She knows how to infiltrate the enemy.", "Infiltration", new Guid("214f9878-37ce-4497-85f4-c4a21162b258") },
                    { new Guid("c046bc1a-36d7-47c5-9eab-db9af761c3c0"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power.", new Guid("c959c30a-cf5d-46c9-9e99-99a0af4e8c1c") },
                    { new Guid("cae4dadc-1b0b-4383-bac1-b4931a418e6d"), "Sublime fighting skills.", "Fighting", new Guid("20493288-fd97-4145-bf06-27e7911e3c61") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_SuperheroId",
                table: "Movies",
                column: "SuperheroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Superheroes_SuperheroId",
                table: "Movies",
                column: "SuperheroId",
                principalTable: "Superheroes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
