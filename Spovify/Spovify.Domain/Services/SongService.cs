namespace Spovify.Domain;

public class SongService
{
    public void AddSong(Song song)
    {
        var data = $"{song.Id},{song.Name},{song.Artist.Name},{song.Artist.Surname},{song.Artist.Nick},{song.Producer.Name},{song.Producer.Surname},{song.Producer.Nick},{song.Lyricist.Name},{song.Lyricist.Surname},{song.Lyricist.Nick}";
    }
}
