// See https://aka.ms/new-console-template for more information
using Spovify.Domain;

Console.WriteLine("Hello, World!");

var artist = new Person()
{
    Name = "Adele",
    Surname = "Adkins",
    Nick = "Adele"
};

var producer = new Person()
{
    Name = "Greg",
    Surname = "Kurstin",
    Nick = "Greg"
};

var song = new Song();

song.Name = "Set Fire to the Rain";
song.Artist = artist;
song.Producer = producer;
song.Lyricist = artist;
