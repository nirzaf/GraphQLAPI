using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraphQLAPI.Migrations
{
    public partial class super : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Superpowers_Superheroes_SuperheroId",
                table: "Superpowers");

            migrationBuilder.DropIndex(
                name: "IX_Superpowers_SuperheroId",
                table: "Superpowers");

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

            migrationBuilder.DropColumn(
                name: "SuperheroId",
                table: "Superpowers");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("0779f45e-1c08-4eac-9776-5e2c147236d0"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman Begins" },
                    { new Guid("6b78d4da-db00-49f2-b67b-9bccd1a7531f"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight Rises" },
                    { new Guid("8fd9056e-fd4f-4c58-803f-f6b0fc350997"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black Widow" },
                    { new Guid("a858af41-473d-4f08-bd8a-19bc0d813dcb"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Episode VI – Return of the Jedi" },
                    { new Guid("ab1203a3-5be4-448e-b5d6-6d37cc561db6"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Episode V – The Empire Strikes Back" },
                    { new Guid("bcc17b0c-9c2f-42e0-ab84-6567b3e2b8ad"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight" },
                    { new Guid("e7d497c0-b6b1-408c-9429-9162402e6f01"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Episode IV – A New Hope" }
                });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[,]
                {
                    { new Guid("5bc7818a-856b-4a4a-ab97-6fc786cdbb82"), "Batman is a superhero who appears in American comic books published by DC Comics. The character was created by artist Bob Kane and writer Bill Finger, and first appeared in Detective Comics #27 (May 1939). Originally", "6'2", "Batman" },
                    { new Guid("6f9b7716-6dc3-432b-9d27-27609ba6958c"), "Luke Skywalker is a fictional character and the main protagonist of the original film trilogy of the Star Wars franchise created by George Lucas. He is portrayed by Mark Hamill in the original trilogy and by Hayden Christensen in the prequel trilogy.", "5'11", "Luke Skywalker" },
                    { new Guid("9c5608f6-c433-4d86-98f8-95dd9a250047"), "Superman is a fictional superhero appearing in American comic books published by DC Comics. The character was created by writer Jerry Siegel and artist Joe Shuster, high school students living in Cleveland, Ohio, in 1933.", "6'3", "Superman" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower" },
                values: new object[,]
                {
                    { new Guid("0ac21a60-356e-447d-92f0-c436e46b786c"), "She's good at spying at people.", "Espionage" },
                    { new Guid("666f2770-023e-46d8-a1bf-871fc4aefa09"), "Sublime fighting skills.", "Fighting" },
                    { new Guid("7aa01142-921f-4d3d-ae7c-622ff94e640c"), "The knowledge of how to undermine others.", "Subterfuge" },
                    { new Guid("9e38d17c-3f52-4ca8-b289-224431379386"), "He got a lot of money", "Wealth." },
                    { new Guid("e203d392-c0d0-474f-8c08-ee5d01b7988a"), "He's always a step ahead.", "Intellect." },
                    { new Guid("ea7acae2-e110-4648-9c37-9e7181bb8b0c"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power." },
                    { new Guid("fbd8a04d-c61a-4ed9-a752-b76f9f4c75ef"), "She knows how to infiltrate the enemy.", "Infiltration" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("0779f45e-1c08-4eac-9776-5e2c147236d0"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6b78d4da-db00-49f2-b67b-9bccd1a7531f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("8fd9056e-fd4f-4c58-803f-f6b0fc350997"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a858af41-473d-4f08-bd8a-19bc0d813dcb"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ab1203a3-5be4-448e-b5d6-6d37cc561db6"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("bcc17b0c-9c2f-42e0-ab84-6567b3e2b8ad"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e7d497c0-b6b1-408c-9429-9162402e6f01"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("5bc7818a-856b-4a4a-ab97-6fc786cdbb82"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("6f9b7716-6dc3-432b-9d27-27609ba6958c"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("9c5608f6-c433-4d86-98f8-95dd9a250047"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("0ac21a60-356e-447d-92f0-c436e46b786c"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("666f2770-023e-46d8-a1bf-871fc4aefa09"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("7aa01142-921f-4d3d-ae7c-622ff94e640c"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("9e38d17c-3f52-4ca8-b289-224431379386"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("e203d392-c0d0-474f-8c08-ee5d01b7988a"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("ea7acae2-e110-4648-9c37-9e7181bb8b0c"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("fbd8a04d-c61a-4ed9-a752-b76f9f4c75ef"));

            migrationBuilder.AddColumn<Guid>(
                name: "SuperheroId",
                table: "Superpowers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.CreateIndex(
                name: "IX_Superpowers_SuperheroId",
                table: "Superpowers",
                column: "SuperheroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Superpowers_Superheroes_SuperheroId",
                table: "Superpowers",
                column: "SuperheroId",
                principalTable: "Superheroes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
