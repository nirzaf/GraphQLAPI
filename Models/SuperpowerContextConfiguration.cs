using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQLAPI.Models;

public class SuperpowerContextConfiguration : IEntityTypeConfiguration<Superpower>
{
    private Guid[] _ids;

        public SuperpowerContextConfiguration(Guid[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Superpower> builder)
        {
            builder
                .HasData(
                new Superpower
                {
                    Id = Guid.NewGuid(),
                    SuperPower = "Intellect.",
                    Description = "He's always a step ahead."
                },
                new Superpower
                {
                    Id = Guid.NewGuid(),
                    SuperPower = "Fighting",
                    Description = "Sublime fighting skills."
                },
                new Superpower
                {
                    Id = Guid.NewGuid(),
                    SuperPower = "Wealth.",
                    Description = "He got a lot of money"
                },
                new Superpower
                {
                    Id = Guid.NewGuid(),
                    SuperPower = "Deflect blaster power.",
                    Description = "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them."
                },
                new Superpower
                {
                    Id = Guid.NewGuid(),
                    SuperPower = "Espionage",
                    Description = "She's good at spying at people."
                },
                new Superpower
                {
                    Id = Guid.NewGuid(),
                    SuperPower = "Infiltration",
                    Description = "She knows how to infiltrate the enemy."
                },
                new Superpower
                {
                    Id = Guid.NewGuid(),
                    SuperPower = "Subterfuge",
                    Description = "The knowledge of how to undermine others."
                });
        }
}