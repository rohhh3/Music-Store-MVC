namespace MusicStore.Models
{
    public class DbInitilizer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            AppDbContext context = applicationBuilder
                .ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<AppDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Items.Any())
            {
                context.AddRange
                (
                    new Item { Name = "Harley Benton TE-20HH SBK Standard Series", Price = 85M, Description = "Most people associate TE-style guitars with musical styles like Country, Blues, and Western. The Harley Benton TE-20HH, on the other hand, breaks away from this much-trodden path and combines a traditional design with modern features - a synergy that makes this affordable guitar perfect for Rock and Metal music. At the core of the TE-20HH's sound is a combination of solid woods and a pair of humbucking pickups, and the result is a powerful-sounding instrument that will handle clean tones well enough but whose real specialty lies in the field of high-gain sounds. What is more, the slim-taper maple neck ensures a comfortable playing feel, while the hardware - comprising a set of reliable DLX die-cast machine heads and a six-way DLX TE bridge - provides optimum tuning stability and accurate intonation in every register.", Category = Categories["Guitars"], ImageUrl = "https://fast-images.static-thomann.de/pics/bdb/_49/491458/16313343_800.jpg", InStock = true, IsItemOfTheWeek = true, ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/491458.webp" },
                    new Item { Name = "Yamaha YDP-165 B Arius", Price = 998M, Description = "88 Weighted keys with hammer action (Graded Hammer, GH3) and synthetic ebony and ivory key tops\r\n10 Sounds (incl. high-end sound from the Yamaha CFX concert grand)\r\n192-Voice polyphony\r\nEffects (Reverb: 4 types, Stereophonic Optimizer, Intelligent Acoustic Control)\r\nMidi-recording (2 tracks)\r\nFunctions: Dual, Duo mode, Metronome, Transpose (-6 - +6), Tuning (414.8 - 466.8 kHz)\r\nPedal: Sustain (half pedal), Sostenuto, Soft\r\nUSB to Host connection\r\n2 x Headphone output (6.3 mm jack)\r\nSpeaker: 2 x 20 W\r\nDimensions (W x D x H): 1357 x 422 x 849 mm (height incl. music stand 1003 mm)\r\nWeight: 42 kg\r\nColour: Black\r\nIncludes power supply unit (PA-300C) and music booklet \"50 Classical Music Masterpieces\"", Category = Categories["Keys"], ImageUrl = "https://static4.redcart.pl/templates/images/thumb/17512/1024/1024/pl/0/templates/images/products/17512/4d6fdcd8e5eed6248ee446d40e71683d.jpeg", InStock = true, IsItemOfTheWeek = false, ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/536780.webp" },
                    new Item { Name = "Startone Star Drum Set Studio -BK", Price = 229M, Description = "5-Piece drum set, ideal for beginners\r\n6-Ply tom- and snare drum shells made from poplar wood\r\n9-Ply bass drum made from poplar wood\r\nDrum shells feature a wrap finish\r\nThe ultimate entry level drum set with an added fun factor!\r\nColour: Black\r\nIncludes a drum throne", Category = Categories["Drums"], ImageUrl = "https://b.scdn.gr/images/sku_main_images/029695/29695598/20210701115525_startone_star_set_studio_black.jpeg", InStock = true, IsItemOfTheWeek = true, ImageThumbnailUrl = "https://image.ceneostatic.pl/data/products/137605298/i-startone-perkusja-akustyczna-star-drum-set-studio-483770.jpg" }
                );
            }
            context.SaveChanges();
        }


        private static Dictionary<string, Category>? categories;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Guitars" },
                        new Category { CategoryName = "Keys" },
                        new Category { CategoryName = "Drums" },
                        new Category { CategoryName = "Studio" },
                        new Category { CategoryName = "Microphones" },
                        new Category { CategoryName = "Software" },
                        new Category { CategoryName = "Accessories" },
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}
