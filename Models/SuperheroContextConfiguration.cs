using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQLAPI.Models;

public class SuperheroContextConfiguration : IEntityTypeConfiguration<Superhero>
{
    private Guid[] _ids;
    
    public SuperheroContextConfiguration(Guid[] ids)
    {
        _ids = ids;
    }
    
    public void Configure(EntityTypeBuilder<Superhero> builder)
    {
        builder.HasData(
            new Superhero
            {
                Id = _ids[0],
                Name = "Batman",
                Description =
                    "Batman is a superhero who appears in American comic books published by DC Comics. The character was created by artist Bob Kane and writer Bill Finger, and first appeared in Detective Comics #27 (May 1939). Originally",
                Height = "6'2"
            },
            new Superhero
            {
                Id = _ids[1],
                Name = "Superman",
                Description =
                    "Superman is a fictional superhero appearing in American comic books published by DC Comics. The character was created by writer Jerry Siegel and artist Joe Shuster, high school students living in Cleveland, Ohio, in 1933.",
                Height = "6'3"
            },
            new Superhero
            {
                Id = _ids[2],
                Name = "Luke Skywalker",
                Description =
                    "Luke Skywalker is a fictional character and the main protagonist of the original film trilogy of the Star Wars franchise created by George Lucas. He is portrayed by Mark Hamill in the original trilogy and by Hayden Christensen in the prequel trilogy.",
                Height = "5'11"
            }
        );
    }
}