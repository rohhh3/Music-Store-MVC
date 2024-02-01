namespace MusicStore.Models
{
    public class DbInitilizer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            AppDbContext context = applicationBuilder
                .ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<AppDbContext>();

            InitializeVisitCounter(context);

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Items.Any())
            {
                context.AddRange
                (
                    //GUITARS
                    new Item
                    {
                        Name = "Harley Benton TE-20HH SBK Standard Series",
                        Price = 85M,
                        Description = "Standard series<br>Basswood body<br>Bolt-on maple neck<br>Roseacer fretboard<br>DOT fretboard inlays<br>Neck profile: modern C<br>Scale: 648 mm<br>Fretboard radius: 305 mm<br>Nut width: 42 mm<br>22 Frets<br>Pickups: 2 humbuckers<br>1 x Volume and 1 x tone control<br>3-Way switch<br>DLX TE bridge<br>Double-action truss rod<br>DLX DieCast machine heads<br>Black hardware<br>Strings: .010 \"- .046\"<br>Colour: Matt Black",
                        Category = Categories["Guitars"],
                        ImageUrl = "https://fast-images.static-thomann.de/pics/bdb/_49/491458/16313343_800.jpg",
                        InStock = true,
                        IsItemOfTheWeek = true,
                        Discount = 0.1F,
                        ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/491458.jpg"
                    },
                    new Item
                    {
                        Name = "Fender Player Plus Strat HSS MN BLK",
                        Price = 899M,
                        Description = "Body: Alder<br>Bolt-on neck: roasted maple<br>Fingerboard: Maple<br>Black Pearloid dot fingerboard inlays<br>Nut: synthetic bone<br>Fingerboard radius: 305 mm (12\")<br>Scale: 648 mm (25.51\")<br>Nut width: 42.8 mm (1.69\")<br>Neck profile: Modern C<br>22 Medium jumbo frets<br>Pickups: Shawbucker 1 humbucker (bridge) and 2 Pure Vintage '65 Gray-Bottom Strat single coils (middle and neck)<br>Control: Master Volume<br>1 Tone control<br>Volume control with push/pull function for coil split<br>5-Way switch<br>2-Point synchronised tremolo with block saddles<br>Deluxe Cast/Sealed locking machine heads<br>Hardware finish: Nickel/chrome<br>Original strings: Fender USA 250LR NPS .009 - .046 (Art. 103326)<br>Colour: Black<br>Incl. Deluxe gig bag",
                        Category = Categories["Guitars"],
                        ImageUrl = "https://thumbs.static-thomann.de/thumb/padthumb600x600/pics/bdb/_58/580990/18752431_800.jpg",
                        InStock = true,
                        IsItemOfTheWeek = true,
                        Discount = 0.2F,
                        ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/580990.jpg"
                    },
                    new Item
                    {
                        Name = "PRS SE DGT Gold Top",
                        Price = 799M,
                        Description = "Body: Mahogany. Top: Maple. Glued-in neck: Mahogany. Fingerboard: Rosewood. Moons fretboard inlays. Neck profile: DGT. Fretboard radius: 254 mm (10\"). Scale: 635 mm (25\"). 22 Frets. Pickups: 2 DGT \"S\" humbuckers. 2 Volume controls. 1 Tone control with push/pull function. 3-Way switch. PRS tremolo. Nickel hardware. Original strings: .010 - .046. Colour: Gold Top. Incl. gig bag",
                        Category = Categories["Guitars"],
                        ImageUrl = "https://bdbo2.thomann.de/thumb/bdb3000/pics/bdbo/17840688.jpg",
                        InStock = true,
                        IsItemOfTheWeek = false,
                        ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/557654.jpg"
                    },
                    new Item
                    {
                        Name = "ESP LTD H3-1000 See Thru Purple SB",
                        Price = 959M,
                        Description = "Body: Mahogany<br>Top: Flamed maple<br>Neck-tru-body: Maple<br>Fretboard: Macassar Ebony<br>Nut width: 42 mm<br>Radius: 350 mm<br>Neck profile: U<br>24 X-Jumbo frets<br>Scale length: 648 mm (25.5\")<br>Pickups: 1 Seymour Duncan Sentient (neck) and 1 Seymour Duncan Pegasus (bridge) humbucker<br>1 x Volume and 1 x tone control<br>3-Way switch (push/pull)<br>ESP locking tuners<br>Tonepros Locking TOM String Thru Bridge<br>Black hardware<br>Strings: Daddario XL110 .010 - .046<br>Colour: See Thru Purple Sunburst",
                        Category = Categories["Guitars"],
                        ImageUrl = "https://fast-images.static-thomann.de/pics/bdb/_43/432110/13965316_800.jpg",
                        InStock = true,
                        IsItemOfTheWeek = false,
                        ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/432110.jpg"
                    },
                    new Item
                    {
                        Name = "Gibson Les Paul Slash Standard NB",
                        Price = 2599M,
                        Description = "Slash signature model<br>Body: Mahogany (Swietenia macrophylla - Origin: India/ Indonesia)<br>Top: AAA flamed maple<br>Neck: Mahogany (Swietenia macrophylla - Origin: India/ Indonesia)<br>Fretboard: Rosewood (Dalbergia Latifolia)<br>Neck profile: Thick<br>Scale: 628 mm<br>Nut width: 43 mm<br>Tektoid nut<br>22 Frets<br>Pickups: 2x Custom Burstbucker Alnico II double black<br>ABR bridge<br>Aluminium stop bar<br>Colour: November Burst<br>Case, accessory kit and Slash picks set included<br>Made in USA",
                        Category = Categories["Guitars"],
                        ImageUrl = "https://fast-images.static-thomann.de/pics/bdb/_48/482161/15574455_800.jpg",
                        InStock = true,
                        IsItemOfTheWeek = false,
                        ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/482161.jpg"
                    },
                    new Item
                    {
                        Name = "Harley Benton SC-400 SBK Classic Series",
                        Price = 111M,
                        Description = "Classic series<br>Body: Basswood<br>Arched top<br>Set-in neck: Maple<br>Neck profile: C<br>Fretboard: Roseacer (thermally treated maple wood)<br>Fretboard radius: 350 mm<br>Crown inlays<br>22 Frets<br>Scale: 628 mm<br>Nut width: 43 mm<br>Double action truss rod<br>Pickups: 2 Classic open humbuckers<br>3-Way pickup selector<br>2 Volume and 2 tone controls<br>Chrome hardware<br>Tune-o-matic bridge<br>Kluson Style Tuners<br>Strings: Harley Benton .010 - .046<br>Colour: Silk-matte black",
                        Category = Categories["Guitars"],
                        ImageUrl = "https://fast-images.static-thomann.de/pics/bdb/_36/362533/14595663_800.jpg",
                        InStock = true,
                        IsItemOfTheWeek = false,
                        ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/362533.jpg"
                    },

                    //KEYS
                    new Item
                    {
                        Name = "Yamaha YDP-165 B Arius",
                        Price = 998M,
                        Description = "88 Weighted keys with hammer action (Graded Hammer, GH3) and synthetic ebony and ivory key tops<br>10 Sounds (incl. high-end sound from the Yamaha CFX concert grand)<br>192-Voice polyphony<br>Effects (Reverb: 4 types, Stereophonic Optimizer, Intelligent Acoustic Control)<br>Midi-recording (2 tracks)<br>Functions: Dual, Duo mode, Metronome, Transpose (-6 - +6), Tuning (414.8 - 466.8 kHz)<br>Pedal: Sustain (half pedal), Sostenuto, Soft<br>USB to Host connection<br>2 x Headphone output (6.3 mm jack)<br>Speaker: 2 x 20 W<br>Dimensions (W x D x H): 1357 x 422 x 849 mm (height incl. music stand 1003 mm)<br>Weight: 42 kg<br>Colour: Black<br>Includes power supply unit (PA-300C) and music booklet \"50 Classical Music Masterpieces\"",
                        Category = Categories["Keys"],
                        ImageUrl = "https://static4.redcart.pl/templates/images/thumb/17512/1024/1024/pl/0/templates/images/products/17512/4d6fdcd8e5eed6248ee446d40e71683d.jpeg",
                        InStock = true,
                        IsItemOfTheWeek = true,
                        Discount = 0.3F,
                        ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/536780.jpg"
                    },
                    new Item
                    {
                        Name = "Roland FP-30X BK",
                        Price = 552M,
                        Description = "88 Keys<br>PHA-4 keyboard with ivory touch<br>Sound engine: 12 Supernatural piano sounds, 20 electric pianos and 24 other sounds<br>Max. polyphony: 256 Voices<br>Built-in speaker system with 2x 12 cm speakers (2x 11 W)<br>Transpose function<br>Built-in metronome<br>Recording and playback of standard MIDI files (SMF) and audio (WAV and MP3) via USB stick<br>30 Accompaniment songs<br>Keyboard modes: Normal, Dual, Split and Twin Piano<br>Dimensions (W x D x H): 1300 x 284 x 151 mm<br>Weight: 14.8 kg<br>Colour: Black<br>Includes operating instructions, external power supply unit (PSB-7U), sheet music holder and DP-2 sustain pedal",
                        Category = Categories["Keys"],
                        ImageUrl = "https://bdbo1.thomann.de/thumb/bdb3000/pics/bdbo/16037093.jpg",
                        InStock = true,
                        IsItemOfTheWeek = false,
                        ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/510682.jpg"
                    },
                    new Item
                    {
                        Name = "Thomann SP-320",
                        Price = 209M,
                        Description = "88 Lightweighted velocity sensitive keys<br>12 Sounds<br>12 Demo songs<br>32-Voice polyphony<br>Layer mode<br>Reverb<br>Chorus<br>Metronome<br>Tempo<br>Headphone jack<br>USB to host - MIDI & Audio, Windows 8 or later, Mac OSX 10.8 or later<br>Line Out (L/R)<br>Sustain pedal connection<br>Optional battery operation (6x LR20 D Mono - not included)<br>Speaker system: 2x 20 watts<br>Dimensions (W x D x H): 1275 x 275 x 85 mm<br>Height including music stand: 1000 mm<br>Weight: 9 kg<br>Colour: Black<br>Includes power supply, sustain pedal and music stand.",
                        Category = Categories["Keys"],
                        ImageUrl = "https://bdbo2.thomann.de/thumb/bdb3000/pics/bdbo/11740155.jpg",
                        InStock = true,
                        IsItemOfTheWeek = false,
                        ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/381525.jpg"
                    },
                    new Item
                    {
                        Name = "Yamaha P-525 B",
                        Price = 1659M,
                        Description = "88 Weighted keys with hammer action (GrandTouch-S)<br>Wooden keys with pressure point and synthetic ivory top layers<br>542 Sounds (incl. Yamaha CFX Piano, Bösendorfer Imperial)<br>Dual/layer<br>Split<br>Duo<br>40 Styles<br>Storable registration memory (6 x 4 banks)<br>21 Voice demo songs + 50 classics<br>256-Voice polyphonic<br>LCD display 198 x 100 dots<br>Midi recording: 250 songs (16 tracks each), format 0<br>Audio recording (USB memory): WAV (44.1 kHz, 16-bit, stereo), up to 80 minutes/song<br>Playback: SMF (Standard Midi File, format 0 and 1), WAV (44.1 kHz, 16-bit, stereo)<br>Effects: Reverb (7), Chorus (3), Master EQ (3 Preset + 1 User), 12 Insert Effects, Intelligent Acoustic Control (IAC), Stereophonic Optimizer, Sound Boost (3).<br>Bluetooth Audio & Midi<br>Connections: Headphone outputs (2x 6.3mm stereo jack), Midi In/Out, Aux In (3.5mm mini-jack stereo), USB to device (USB A), USB to host (USB C), Power supply connector, Sustain pedal, Pedal board (LP-1 or FC-35, sold separately).<br>Speaker: 2x 20W + 6W<br>Included in delivery: P-525B digital piano, operating instructions, Online Member Registration, sheet music holder, foot pedal (FC-3A), power supply unit (PA-300C)<br>Dimensions: 1336 x 145 x 376 mm<br>Weight: 22 kg<br>Colour: Black",
                        Category = Categories["Keys"],
                        ImageUrl = "https://bdbo1.thomann.de/thumb/bdb3000/pics/bdbo/18789238.jpg",
                        InStock = true,
                        IsItemOfTheWeek = false,
                        ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/577283.jpg"
                    },
                    new Item
                    {
                        Name = "Kawai ES-120 B",
                        Price = 522M,
                        Description = "88 Weighted keys with hammer action, Responsive Hammer Compact - RHC<br>25 Sounds<br>100 Drum rhythms<br>4 Memory registrations<br>192-Polyphonic voices<br>Dual mode<br>Split mode<br>Internal recorder (3 songs, approx. 15,000 notes)<br>Effects: Room, small hall, concert hall<br>Functions: Transpose, tuning, temperament, temperament Key<br>Low volume balance<br>Speaker EQ<br>Speaker on/off<br>Auto power off<br>Metronome<br>Bluetooth Midi (Ver. 5.0 GATT compatible)<br>Bluetooth Audio (Ver. 5.1 A2DP compatible)<br>Speaker system: 2 x 10 W<br>Dimensions (W x D x H) in mm: 1305 x 280 x 120<br>Weight: 12 kg<br>Colour: Black",
                        Category = Categories["Keys"],
                        ImageUrl = "https://bdbo1.thomann.de/thumb/bdb3000/pics/bdbo/17679818.jpg",
                        InStock = true,
                        IsItemOfTheWeek = false,
                        ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/546622.jpg"
                    },
                    new Item
                    {
                        Name = "Clavia Nord Stage 4 88",
                        Price = 4090M,
                        Description = "",
                        Category = Categories["Keys"],
                        ImageUrl = "https://bdbo1.thomann.de/thumb/bdb3000/pics/bdbo/18566068.jpg",
                        InStock = true,
                        IsItemOfTheWeek = false,
                        ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/560977.jpg"
                    },

                    //DRUMS
                    new Item
                    {
                        Name = "Startone Star Drum Set Studio -BK",
                        Price = 229M,
                        Description = "Complete Set<br>5-Piece drum set, ideal for beginners<br>6-Ply tom- and snare drum shells made from poplar wood<br>9-Ply bass drum made from poplar wood<br>Drum shells feature a wrap finish<br>The ultimate entry level drum set with an added fun factor!<br>Colour: Black<br>Includes a drum throne",
                        Category = Categories["Drums"],
                        ImageUrl = "https://b.scdn.gr/images/sku_main_images/029695/29695598/20210701115525_startone_star_set_studio_black.jpeg",
                        InStock = true,
                        IsItemOfTheWeek = true,
                        Discount = 0.15F,
                        ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/541371.jpg"
                    },
                    new Item
                    {
                        Name = "Ludwig Accent Fuse 5pc Blue",
                        Price = 429M,
                        Description = "Accent Drive Serie<br>5-Ply hard wood shell<br>Foil-covered<br>Chrome shell hardware<br>Double-layered drumheads<br>Power Collar kick drum heads<br>Colour: Blue Sparkle",
                        Category = Categories["Drums"],
                        ImageUrl = "https://bdbo2.thomann.de/thumb/bdb3000/pics/bdbo/18692233.jpg",
                        InStock = true,
                        IsItemOfTheWeek = false,
                        ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/578823.jpg"
                    },
                    new Item
                    {
                        Name = "Mapex Tornado Studio Zildjian Set BK",
                        Price = 522M,
                        Description = "Tornado Series<br>Studio version<br>Drum shells are made from basswood<br>Drum shells with wrap finish<br>Colour: Black",
                        Category = Categories["Drums"],
                        ImageUrl = "https://bdbo1.thomann.de/thumb/bdb3000/pics/bdbo/12543102.jpg",
                        InStock = true,
                        IsItemOfTheWeek = false,
                        ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/398666.jpg"
                    },
                    new Item
                    {
                        Name = "Pearl Roadshow Jr. Jet Black",
                        Price = 348M,
                        Description = "Roadshow series<br>Junior version<br>RSJ465C / C708<br>Wrap-finished shells<br>Chrome shell hardware<br>6-Ply poplar shell<br>Colour: Jet Black #31<br>Includes sticks",
                        Category = Categories["Drums"],
                        ImageUrl = "https://bdbo1.thomann.de/thumb/bdb2500/pics/bdbo/14913190.jpg",
                        InStock = true,
                        IsItemOfTheWeek = false,
                        ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/472255.jpg"
                    },
                    new Item
                    {
                        Name = "Sonor AQX Studio Set RMS",
                        Price = 229M,
                        Description = "AQX Series<br>Studio configuration<br>Drum shells: Poplar<br>Colour: Red Moon Sparkle (RMS)<br>Includes a DTH 2000 tom holder",
                        Category = Categories["Drums"],
                        ImageUrl = "https://thumbs.static-thomann.de/thumb/padthumb600x600/pics/bdb/_51/512283/18624789_800.jpg",
                        InStock = true,
                        IsItemOfTheWeek = false,
                        ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/512283.jpg"
                    },

                    //STUDIO
                    new Item
                    {
                        Name = "KRK RP5 RoKit Classic",
                        Price = 111M,
                        Description = "Drivers: 5\" glass aramid woofer and 1\" textile tweeter<br>Power: 50 W<br>Class-AB amplifier: 30 W woofer, 20 W tweeter<br>Frequency response: 46 - 34.500 Hz (+3 / -10 dB)<br>Max. SPL: 101 dB<br>Connectors: RCA, XLR and 6.3 mm jack<br>Auto standby<br>Dimensions (W x H x D): 188 x 284 x 246 mm<br>Weight: 5.87 kg<br>Colour: Black",
                        Category = Categories["Studio"],
                        ImageUrl = "https://bdbo2.thomann.de/thumb/bdb3000/pics/bdbo/14633206.jpg",
                        InStock = true,
                        IsItemOfTheWeek = false,
                        ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/322608.jpg"
                    },
                    new Item
                    {
                        Name = "Neumann KH 120 II",
                        Price = 711M,
                        Description = "Drivers: 5.25\" woofer and 1\" tweeter<br>Frequency range: 44 - 21,000 Hz (+/- 3 dB)<br>Max. SPL 116.8 dB<br>Output power: 145 W woofer, 100 W tweeter (THD+N with limiter deactivated: 10%)<br>DSP-controlled electronics<br>Room-adaptive calibration via optional Neumann Automatic Monitor Alignment MA 1 (not included)<br>4-Position acoustic control for bass, low-mid and treble<br>Independent soft-clip, peak and thermal limiters for woofer and tweeter<br>Excursion limiter for woofer<br>Temperature monitoring for electronics and power amplifier<br>Connections: 1 line input XLR, S/PDIF coax, Ethernet<br>Dimensions (H x W x D): 287 x 182 x 227 mm<br>Weight: 5.4 kg",
                        Category = Categories["Studio"],
                        ImageUrl = "https://bdbo1.thomann.de/thumb/bdb2500/pics/bdbo/18367428.jpg",
                        InStock = true,
                        IsItemOfTheWeek = false,
                        ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/562481.webp"
                    },
                    new Item
                    {
                        Name = "beyerdynamic DT-770 Pro 80 Ohm",
                        Price = 122M,
                        Description = "Closed-back<br>Circumaural design<br>Dynamic<br>Diffuse-field equalised<br>Impedance: 80 Ohm<br>Sensitivity SPL (sound pressure level): 96 dB<br>Frequency response: 5 - 35,000 Hz<br>3 m straight single-sided cable with 3.5 mm connector<br>Screw-on adapter to 6.3 mm stereo jack<br>Weight with cable: 346 g<br>Weight without cable: 284 g",
                        Category = Categories["Studio"],
                        ImageUrl = "https://bdbo2.thomann.de/thumb/bdb3000/pics/bdbo/18443592.jpg",
                        InStock = true,
                        IsItemOfTheWeek = false,
                        ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/174334.jpg"
                    },
                    new Item
                    {
                        Name = "KRK KNS 8402",
                        Price = 85M,
                        Description = "Closed headphones<br>Circumaural<br>Dynamic<br>Memory latex foam ear padding<br>Impedance: 36 Ohm<br>Frequency range: 5 - 23.000 Hz<br>Sensitivity: 97 dB (1 W / 1 m)<br>Power rating: 500 mW<br>Detachable cable<br>Cable length: 2.6 m<br>0.75 m Extension cable with volume control<br>Connector: Mini jack stereo including adapter to 6.3 mm stereo jack<br>Dimensions: 245 x 268 x 94 mm<br>Weight without cable: 247 g<br>Includes bag and cleaning cloth",
                        Category = Categories["Studio"],
                        ImageUrl = "https://bdbo1.thomann.de/thumb/bdb3000/pics/bdbo/16729434.jpg",
                        InStock = true,
                        IsItemOfTheWeek = false,
                        ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/529337.jpg"
                    },

                     //MICROPHONES
                     new Item
                     {
                         Name = "Shure SM58 LC",
                         Price = 95M,
                         Description = "Optimised frequency response with brightened mids and bass cuts<br>Integrated, effective wind and pop filter<br>Shock absorber system<br>Robust construction, sturdy steel mesh grille<br>Directivity: Cardioid<br>Frequency range: 50 - 15,000 Hz<br>Output impedance: 300 Ohm<br>Sensitivity: -56 dBV / Pa (1.85 mV)<br>Dimensions: 23 x 162 x 51 mm<br>Weight: 298 g<br>Includes microphone bag, microphone clamp and 3/8\" reducing thread",
                         Category = Categories["Microphones"],
                         ImageUrl = "https://bdbo2.thomann.de/thumb/bdb2500/pics/bdbo/8805536.jpg",
                         InStock = true,
                         IsItemOfTheWeek = false,
                         ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/105767.jpg"
                     },
                     new Item
                     {
                         Name = "Sennheiser E835",
                         Price = 79M,
                         Description = "Suitable for e.g. vocals and percussion<br>Polar pattern: cardioid<br>Frequency range: 40 - 16,000 Hz<br>Impedance: 350 Ohm<br>Without switch<br>DImensions: Ø 48 x 180 mm<br>Weight: 330 g<br>Incl. clamp and bag",
                         Category = Categories["Microphones"],
                         ImageUrl = "https://bdbo2.thomann.de/thumb/bdb2500/pics/bdbo/14614248.jpg",
                         InStock = true,
                         IsItemOfTheWeek = false,
                         ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/363450.jpg"
                     },
                     new Item
                     {
                         Name = "Rode NT1-A Complete Vocal Recording",
                         Price = 155M,
                         Description = "1\" Large diaphragm microphone<br>Polar pattern: Cardioid<br>Frequency response: 20 - 20,000 Hz<br>Max. sound pressure level: 137 dB<br>Output impedance: 100 Ohm<br>Gold-plated output contacts<br>Dimensions (H x W x D): 190 x 50 x 50 mm<br>Weight: 326 g",
                         Category = Categories["Microphones"],
                         ImageUrl = "https://bdbo2.thomann.de/thumb/bdb2500/pics/bdbo/18519185.jpg",
                         InStock = true,
                         IsItemOfTheWeek = false,
                         ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/235937.jpg"
                     },
                     new Item
                     {
                         Name = "Shure SM 7 B",
                         Price = 335M,
                         Description = "Polar pattern: Cardioid<br>Frequency range: 50 - 20,000 Hz<br>Sensitivity -59.0 dB (1.12 mV)<br>Bass roll-off switch<br>Mid-boost switch<br>Impedance: 150 ohms<br>Shielding against electromagnetic interference<br>Swivel mount<br>XLR connector<br>Dimensions: 190 x 64 x 96 mm<br>Weight: 766 g<br>Includes switch cover plate and windscreen",
                         Category = Categories["Microphones"],
                         ImageUrl = "https://bdbo2.thomann.de/thumb/bdb2500/pics/bdbo/18086262.jpg",
                         InStock = true,
                         IsItemOfTheWeek = false,
                         ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/129929.jpg"
                     },
                     new Item
                     {
                         Name = "Neumann TLM 103 Studio Set",
                         Price = 999M,
                         Description = "Capsule design modelled on the legendary U 87 Ai<br>Acoustic mode of operation: Pressure gradient receiver<br>Polar pattern: Cardioid<br>Frequency response: 20 - 20,000 Hz<br>Max. SPL (sound pressure level) for k < 0.5% 3: 138 dB<br>Equivalent noise level , A-weighted (rel. 94 dB SPL): 87 dB<br>Requires +48 V phantom power<br>Dimensions (diameter x length): 60 x 132 mm<br>Weight: approx. 450 g<br>Colour: Nickel<br>Incl. EA1 elastic mount",
                         Category = Categories["Microphones"],
                         ImageUrl = "https://bdbo1.thomann.de/thumb/bdb2500/pics/bdbo/6985971.jpg",
                         InStock = true,
                         IsItemOfTheWeek = false,
                         ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/174067.jpg"
                     },
                     new Item
                     {
                         Name = "the t.bone SC 400",
                         Price = 44M,
                         Description = "1\" Gold membrane<br>Polar pattern: Supercardioid<br>Frequency range: 20 - 20,000 kHz<br>Sensitivity: 23.3 mV/Pa<br>Equivalent noise level: 18 dB (A)<br>Output impedance: 120 ohms<br>Maximum sound pressure level: 132 dB SPL<br>Internal low cut switch at 100 Hz with 6 dB<br>Requires 48V phantom power<br>Weight of the microphone: 351 g<br>Colour: Black<br>Shock mount and bag included",
                         Category = Categories["Microphones"],
                         ImageUrl = "https://bdbo2.thomann.de/thumb/bdb2500/pics/bdbo/7454609.jpg",
                         InStock = true,
                         IsItemOfTheWeek = true,
                         Discount = 0.25F,
                         ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/156266.jpg"
                     },
                     //SOFTWARE
                     new Item
                     {
                         Name = "Ableton Live 11 Intro",
                         Price = 55M,
                         Description = "Software for composition, intuitive producing and live mixing<br>Session view with clips and clip automation and classic track view<br>Comping function for audio and MIDI recordings to create an overall take from several recording passes<br>Dynamic tempo adjustment automatically to incoming audio signal<br>Adjustable probability for notes and velocity values for random changes<br>MPE (MIDI Polyphonic Expression) support<br>Real-time warping and time-stretching<br>Browser with preview function at project tempo<br>Capture allows ideas to be captured on MIDI tracks afterwards<br>Group tracks with multiple layers<br>Audio resolution up to 32 bit/192 kHz<br>16 audio and MIDI tracks with 16 scenes<br>2 send and return tracks<br>Up to 8 audio inputs and outputs<br>Included instruments: Drum Rack, Impulse, Simpler and Instrument Racks<br>21 audio effects<br>11 MIDI effects<br>More than 1500 sounds and 5 GB samples<br>Supports MP3, FLAC and WAVPACK export",
                         Category = Categories["Software"],
                         ImageUrl = "https://fast-images.static-thomann.de/pics/bdb/_51/514567/16000724_800.jpg",
                         InStock = true,
                         IsItemOfTheWeek = false,
                         ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/514567.jpg"
                     },
                     new Item
                     {
                         Name = "Ableton Live 11 Suite",
                         Price = 415M,
                         Description = "Software for composition, intuitive production and live mixing<br>Session view with clips and clip automation and classic track view<br>Comping function for audio and MIDI recordings to create an overall take from several recording passes<br>Parallel editing of linked tracks<br>Dynamic tempo adjustment in real time and automatically based on incoming audio signals<br>Adjustable note probability and velocity values for random changes<br>MPE (MIDI Polyphonic Expression) support<br>Includes Max for Live, warping and time-stretching in real time<br>Complex warp modes<br>Audio slicing for Drum Rack or Sampler<br>Audio-to-MIDI function<br>Capture allows you to capture ideas to MIDI tracks afterwards<br>Group tracks with multiple layers<br>Support for Serato Scratch Live<br>Browser with project tempo preview function<br>Audio resolution up to 32 bit/192 kHz<br>Unlimited number of audio and MIDI tracks<br>12 send and return tracks<br>Up to 256 audio inputs and outputs<br>Integration of external instruments<br>Included instruments: Wavetable, Operator, Analogue, Sampler, Simpler, Electric, Tension, Collision, Bass, Poli, Drum Rack, Drum Synths, Impulse, CV Instrument and CV Triggers and Instrument Racks.<br>59 audio effects<br>15 MIDI effects<br>More than 5000 sounds and 70 GB samples<br>Supports MP3, FLAC and WAVPACK export",
                         Category = Categories["Software"],
                         ImageUrl = "https://fast-images.static-thomann.de/pics/bdb/_51/514571/16000974_800.jpg",
                         InStock = true,
                         IsItemOfTheWeek = true,
                         Discount = 0.30F,
                         ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/514571.jpg"
                     },
                     new Item
                     {
                         Name = "Avid Pro Tools Studio Perpetual",
                         Price = 579M,
                         Description = "Latest Pro Tools Studio version<br>Up to 64 inputs and outputs simultaneously<br>512 Audio, 128 auxiliary, 128 VCA and 64 master tracks<br>1024 MIDI and 512 instrument tracks<br>Unlimited number of buses and one video track<br>Enables mixing in surround, atmos and ambisonics formats<br>Pro Tools Sketch enables non-linear, clip-based work in Pro Tools, independent of the timeline<br>Advanced automation options with Punch, Capture, Write on stop, Write to all enabled, Automatch, Preview etc.<br>Editable clip FX and multi-stem bounce in one file<br>Numerous features such as Offline Bounce, automatic delay compensation, Multitrack beat detective, Elastic time and pitch, Clip gain, Real-Time fades, advanced metering with gain reduction display etc.<br>Includes Complete Bundle with over 115 virtual instruments and effects, Groove Cell and Synth Cell, HEAT and Inner Circle when Updates & Support Plan is active.<br>Avid Cloud collaboration with 1 GB of memory<br>Integration of hardware controllers via EUCON and Mackie HUI protocol<br>ASIO and Core audio support for the integration of third-party audio hardware<br>Delivery contents: Licence card",
                         Category = Categories["Software"],
                         ImageUrl = "https://bdbo1.thomann.de/thumb/bdb2500/pics/bdbo/18565338.jpg",
                         InStock = true,
                         IsItemOfTheWeek = false,
                         ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/542234.jpg"
                     },
                     new Item
                     {
                         Name = "iZotope RX 10 Elements",
                         Price = 18M,
                         Description = "Basic audio restoration and repair tools for content creators and home studios<br>RX Repair Assistant and five other plug-ins with the algorithms of the RX 10 software<br>Includes Voice De-noise, De-clip, De-click, De-hum, De-reverb and Repair Assistant<br>RX 10 Repair Assistant provides a straightforward solution to the most common restoration needs within a DAW.<br>Repair Assistant automatically detects problems using machine learning and suggests a suitable treatment that can be customised by the user<br>De-Hum plug-in with Static and Dynamic Mode removes background hum including harmonics with narrow band filters<br>Dynamic Mode automatically cleans up the entire audio spectrum with up to 1024 dynamic notch filters by learning the noise type",
                         Category = Categories["Software"],
                         ImageUrl = "https://bdbo2.thomann.de/thumb/bdb2500/pics/bdbo/17565408.jpg",
                         InStock = true,
                         IsItemOfTheWeek = false,
                         ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/551189.jpg"
                     },
                     new Item
                     {
                         Name = "iZotope Ozone 11 Elements",
                         Price = 18M,
                         Description = "Easy-to-use mastering tool for fast results<br>Configures the mastering chain by matching it to a reference from Ozone's presets of chart hits, an audio file loaded as reference or iZotope Audiolens generated user targets<br>Master Assistant with AI-supported matching technology for sound, dynamics and stereo width as well as Vocal Checker for matching vocals in the mix<br>Assistant View allows the exact setting of the matching proportion<br>Provides the matching technology of the Ozone 11 standard version, but without access to module parameters<br>Scalable user interface",
                         Category = Categories["Software"],
                         ImageUrl = "https://bdbo2.thomann.de/thumb/bdb2500/pics/bdbo/18530003.jpg",
                         InStock = true,
                         IsItemOfTheWeek = false,
                         ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/574926.jpg"
                     },

                     //ACCESSORIES
                     new Item
                     {
                         Name = "Millenium BS-2222 Pro Set",
                         Price = 77M,
                         Description = "Material: Steel<br>Can hold up to 45 kg centric load<br>Max. height: 40 kg<br>Length: Approx. 1.30 m - 2.00 m<br>Pole diametre: 35 mm<br>Weight per tripod: 3.6 kg<br>Colour: Black<br>Includes carry bag<br>Set of 2 stands",
                         Category = Categories["Accessories"],
                         ImageUrl = "https://bdbo1.thomann.de/thumb/bdb2500/pics/bdbo/4444185.jpg",
                         InStock = true,
                         IsItemOfTheWeek = false,
                         ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/267641.jpg"
                     },
                     new Item
                     {
                         Name = "Roadworx BLS-2700",
                         Price = 105M,
                         Description = "Material: Steel<br>Tube diameter: 35 mm at the top with M10 internal thread<br>Extendable from 1.94 to 3.10 m<br>Transport length when folded: 176 cm<br>Max. Load capacity 50 kg<br>Weight: 11.6 kg<br>Colour: Black",
                         Category = Categories["Accessories"],
                         ImageUrl = "https://bdbo2.thomann.de/thumb/bdb2500/pics/bdbo/18759171.jpg",
                         InStock = true,
                         IsItemOfTheWeek = false,
                         ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/568330.jpg"
                     },
                     new Item
                     {
                         Name = "K&M 210/9 Black",
                         Price = 45M,
                         Description = "Similar to K&M 210/2 but with telescopic boom arm<br>Diecast base<br>Foldable legs<br>Wide base<br>Height is adjustable from 900 to 1600 mm<br>Colour: Black<br>Boom arm length: 460 - 770 mm<br>Weight: 3.2 kg",
                         Category = Categories["Accessories"],
                         ImageUrl = "https://bdbo2.thomann.de/thumb/bdb2500/pics/bdbo/3564815.jpg",
                         InStock = true,
                         IsItemOfTheWeek = false,
                         ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/104942.jpg"
                     },
                     new Item
                     {
                         Name = "Millenium MS 2003",
                         Price = 15M,
                         Description = "Cast base with foldable feet<br>Metal tommy screw on the boom joint<br>3/8\" Threads for microphone clamp<br>Includes 3/8\" to 5/8\" thread adapter<br>Height adjustable from 105 - 170 cm<br>Adjustable arm: 75 cm<br>Colour: Black",
                         Category = Categories["Accessories"],
                         ImageUrl = "https://bdbo2.thomann.de/thumb/bdb2500/pics/bdbo/13413261.jpg",
                         InStock = true,
                         IsItemOfTheWeek = false,
                         ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/133136.jpg"
                     },
                     new Item
                     {
                         Name = "K&M 260/1",
                         Price = 18M,
                         Description = "With impact noise dampening cast base<br>Base diameter: 250 mm<br>Height-adjustable tube construction<br>Height: 87 - 157 cm<br>Weight: 2.8 kg<br>Colour: Black",
                         Category = Categories["Accessories"],
                         ImageUrl = "https://thumbs.static-thomann.de/thumb/padthumb600x600/pics/bdb/_10/107200/11718903_800.jpg",
                         InStock = true,
                         IsItemOfTheWeek = false,
                         ImageThumbnailUrl = "https://thumbs.static-thomann.de/thumb/thumb220x220/pics/prod/107200.jpg"
                     }
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
                        new Category 
                        { 
                            CategoryName = "Guitars",
                            ImageUrl = "https://wallpaperboat.com/wp-content/uploads/2019/04/electric-guitar-001.jpg",
                        },
                        new Category 
                        { 
                            CategoryName = "Keys",
                            ImageUrl = "https://www.soundtech.co.uk/img/general/organ.jpg",

                        },
                        new Category 
                        { 
                            CategoryName = "Drums" ,
                            ImageUrl = "https://wallpapercosmos.com/w/middle-retina/4/b/2/1169043-2560x1600-desktop-hd-drums-background-image.jpg",
                        },
                        new Category 
                        { 
                            CategoryName = "Studio" ,
                            ImageUrl = "https://images.alphacoders.com/115/115641.jpg",
                        },
                        new Category 
                        { 
                            CategoryName = "Microphones",
                            ImageUrl = "https://wallpapercave.com/wp/wp2130021.jpg",
                        },
                        new Category { 
                            CategoryName = "Software" ,
                            ImageUrl = "https://store.native-instruments.com/media/catalog/product/cache/93de93835928c4668a602c7b4a5731c7/2/0/2023-pps7-pdp_1.jpg",
                        },
                        new Category { 
                            CategoryName = "Accessories",
                            ImageUrl = "https://thumbs.static-thomann.de/thumb//convert/pics/images/category/fx/cat_zu.jpg",
                        },
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

        public static void InitializeVisitCounter(AppDbContext context)
        {
            if (!context.VisitCounters.Any())
            {
                context.VisitCounters.Add(new VisitCounter { Count = 0 });
                context.SaveChanges();
            }
        }
    }
}
