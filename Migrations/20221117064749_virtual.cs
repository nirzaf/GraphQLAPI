using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraphQLAPI.Migrations
{
    public partial class @virtual : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("2db7b479-b079-4647-b8ad-0c05c6b27920"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4b0c207d-9a6c-4281-829d-42fbb9a34e32"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("67859df3-3068-48c5-84d0-4257998a682a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7b2998cb-2da5-409e-8c12-dcf9244438c6"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("91b4f155-c236-450c-8bcb-c54f11ef7d02"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a367ca24-738c-4ec6-9194-967969887a11"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a749cf89-a7d6-47ea-b9ad-0c689df8c00e"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("0acff383-c002-4c1e-aec2-41fc66c67ad5"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("4afd542d-6913-4578-b90d-5dfe425ca026"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("7d92b7fb-88dd-432f-89bc-e8fec9fdcdc9"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("a3a36a5b-add2-466d-9a62-ba6df2f1c10c"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("ab2effc3-7ad1-459c-b6a0-45faebb9c28f"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("bc0e1d68-742b-46bd-9a2a-5ee21d8a599d"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("c3a23759-6094-429d-9117-5f8deb57fcc2"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("3cac85a6-28b0-481c-b4da-e0f57a4acff5"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("4e72af38-0d0b-471d-89a9-cb1137b35fce"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("67b8ff7a-390e-4874-ae7a-494b1019dbfd"));

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[] { new Guid("3cac85a6-28b0-481c-b4da-e0f57a4acff5"), "Superman is a fictional superhero appearing in American comic books published by DC Comics. The character was created by writer Jerry Siegel and artist Joe Shuster, high school students living in Cleveland, Ohio, in 1933.", "6'3", "Superman" });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[] { new Guid("4e72af38-0d0b-471d-89a9-cb1137b35fce"), "Luke Skywalker is a fictional character and the main protagonist of the original film trilogy of the Star Wars franchise created by George Lucas. He is portrayed by Mark Hamill in the original trilogy and by Hayden Christensen in the prequel trilogy.", "5'11", "Luke Skywalker" });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[] { new Guid("67b8ff7a-390e-4874-ae7a-494b1019dbfd"), "Batman is a superhero who appears in American comic books published by DC Comics. The character was created by artist Bob Kane and writer Bill Finger, and first appeared in Detective Comics #27 (May 1939). Originally", "6'2", "Batman" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "SuperheroId", "Title" },
                values: new object[,]
                {
                    { new Guid("2db7b479-b079-4647-b8ad-0c05c6b27920"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("67b8ff7a-390e-4874-ae7a-494b1019dbfd"), "The Dark Knight Rises" },
                    { new Guid("4b0c207d-9a6c-4281-829d-42fbb9a34e32"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3cac85a6-28b0-481c-b4da-e0f57a4acff5"), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("67859df3-3068-48c5-84d0-4257998a682a"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("67b8ff7a-390e-4874-ae7a-494b1019dbfd"), "Batman Begins" },
                    { new Guid("7b2998cb-2da5-409e-8c12-dcf9244438c6"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3cac85a6-28b0-481c-b4da-e0f57a4acff5"), "Star Wars: Episode V – The Empire Strikes Back" },
                    { new Guid("91b4f155-c236-450c-8bcb-c54f11ef7d02"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("67b8ff7a-390e-4874-ae7a-494b1019dbfd"), "The Dark Knight" },
                    { new Guid("a367ca24-738c-4ec6-9194-967969887a11"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4e72af38-0d0b-471d-89a9-cb1137b35fce"), "Black Widow" },
                    { new Guid("a749cf89-a7d6-47ea-b9ad-0c689df8c00e"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3cac85a6-28b0-481c-b4da-e0f57a4acff5"), "Star Wars: Episode VI – Return of the Jedi" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("0acff383-c002-4c1e-aec2-41fc66c67ad5"), "She's good at spying at people.", "Espionage", new Guid("4e72af38-0d0b-471d-89a9-cb1137b35fce") },
                    { new Guid("4afd542d-6913-4578-b90d-5dfe425ca026"), "He's always a step ahead.", "Intellect.", new Guid("67b8ff7a-390e-4874-ae7a-494b1019dbfd") },
                    { new Guid("7d92b7fb-88dd-432f-89bc-e8fec9fdcdc9"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power.", new Guid("3cac85a6-28b0-481c-b4da-e0f57a4acff5") },
                    { new Guid("a3a36a5b-add2-466d-9a62-ba6df2f1c10c"), "He got a lot of money", "Wealth.", new Guid("67b8ff7a-390e-4874-ae7a-494b1019dbfd") },
                    { new Guid("ab2effc3-7ad1-459c-b6a0-45faebb9c28f"), "Sublime fighting skills.", "Fighting", new Guid("67b8ff7a-390e-4874-ae7a-494b1019dbfd") },
                    { new Guid("bc0e1d68-742b-46bd-9a2a-5ee21d8a599d"), "She knows how to infiltrate the enemy.", "Infiltration", new Guid("4e72af38-0d0b-471d-89a9-cb1137b35fce") },
                    { new Guid("c3a23759-6094-429d-9117-5f8deb57fcc2"), "The knowledge of how to undermine others.", "Subterfuge", new Guid("4e72af38-0d0b-471d-89a9-cb1137b35fce") }
                });
        }
    }
}
