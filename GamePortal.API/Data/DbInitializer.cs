using GamePortal.API.Models;

namespace GamePortal.API.Data
{
    public class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if ((context.Games.Any())) return;

            var rpg = new Genre { Name = "RPG" };
            var action = new Genre { Name = "Action" };
            var adventure = new Genre { Name = "Adventure" };
            var shooter = new Genre { Name = "Shooter" };
            var strategy = new Genre { Name = "Strategy" };

            var pc = new Platform { Name = "PC" };
            var ps5 = new Platform { Name = "PS5" };
            var xbox = new Platform { Name = "Xbox" };
            var nintendo = new Platform { Name = "Nintendo" };

            context.Genres.AddRange(rpg, action, adventure, shooter, strategy);
            context.Platforms.AddRange(pc, ps5, xbox, nintendo);

            context.Games.AddRange(
    new Game
    {
        Title = "The Witcher 3: Wild Hunt",
        Description = "An open-world RPG set in a dark fantasy universe where you play as Geralt of Rivia, a monster hunter for hire.",
        ReleaseDate = new DateOnly(2015, 5, 19),
        Genres = new List<Genre> { rpg, action },
        Platforms = new List<Platform> { pc, ps5, xbox }
    },

    new Game
    {
        Title = "Elden Ring",
        Description = "A vast open-world action RPG where you explore the Lands Between and face powerful demigods.",
        ReleaseDate = new DateOnly(2022, 2, 25),
        Genres = new List<Genre> { rpg, action },
        Platforms = new List<Platform> { pc, ps5, xbox }
    },

new Game
{
    Title = "Halo Infinite",
    Description = "A sci-fi shooter following Master Chief as he battles the Banished on a mysterious Halo ring.",
    ReleaseDate = new DateOnly(2021, 12, 8),
    Genres = new List<Genre> { shooter, action },
    Platforms = new List<Platform> { pc, xbox }
},

new Game
{
    Title = "The Legend of Zelda: Tears of the Kingdom",
    Description = "An adventure game where Link explores the skies and lands of Hyrule to stop a new ancient threat.",
    ReleaseDate = new DateOnly(2023, 5, 12),
    Genres = new List<Genre> { adventure, action },
    Platforms = new List<Platform> { nintendo }
},

new Game
{
    Title = "Civilization VI",
    Description = "A turn-based strategy game where you build an empire and lead it through the ages.",
    ReleaseDate = new DateOnly(2016, 10, 21),
    Genres = new List<Genre> { strategy },
    Platforms = new List<Platform> { pc, ps5, xbox, nintendo }
},

new Game
{
    Title = "Mass Effect Legendary Edition",
    Description = "A remastered sci-fi RPG trilogy where Commander Shepard fights to save the galaxy from the Reapers.",
    ReleaseDate = new DateOnly(2021, 5, 14),
    Genres = new List<Genre> { rpg, action },
    Platforms = new List<Platform> { pc, ps5, xbox }
},

new Game
{
    Title = "Super Mario Odyssey",
    Description = "A colorful 3D adventure where Mario travels across unique worlds to rescue Princess Peach.",
    ReleaseDate = new DateOnly(2017, 10, 27),
    Genres = new List<Genre> { adventure },
    Platforms = new List<Platform> { nintendo }
},

new Game
{
    Title = "Call of Duty: Modern Warfare II",
    Description = "A fast-paced military shooter featuring global special operations and intense multiplayer combat.",
    ReleaseDate = new DateOnly(2022, 10, 28),
    Genres = new List<Genre> { shooter, action },
    Platforms = new List<Platform> { pc, ps5, xbox }
},

new Game
{
    Title = "Divinity: Original Sin 2",
    Description = "A deep tactical RPG with rich storytelling, turn-based combat, and full party customization.",
    ReleaseDate = new DateOnly(2017, 9, 14),
    Genres = new List<Genre> { rpg, strategy },
    Platforms = new List<Platform> { pc, ps5, xbox, nintendo }
},

new Game
{
    Title = "Horizon Forbidden West",
    Description = "An action-adventure game where Aloy explores a post-apocalyptic world filled with machine creatures.",
    ReleaseDate = new DateOnly(2022, 2, 18),
    Genres = new List<Genre> { action, adventure },
    Platforms = new List<Platform> { ps5 }
}
);
            context.SaveChanges();
        }
    }
}
