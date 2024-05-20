// See https://aka.ms/new-console-template for more information
using Spovify.Domain;

Console.WriteLine("Hello, World!");

var artist = new Person()
{
    Id = Guid.NewGuid(),
    Name = "Adele",
    Surname = "Adkins",
    Nick = "Adele"
};

var producer = new Person()
{
    Id = Guid.NewGuid(),
    Name = "Greg",
    Surname = "Kurstin",
    Nick = "Greg"
};

var song = new Song
{
    Id = Guid.NewGuid(),
    Name = "Hello",
    Artist = artist,
    Producer = producer,
    Lyricist = artist
};

var songService = new SongService();

songService.AddSong(song);

// var songsFromText = songService.GetSongs();

// foreach (var songFromText in songsFromText)
// {
//     Console.WriteLine($"{songFromText.Name} - {songFromText.Artist.Name}");
// }

// System.Console.WriteLine();