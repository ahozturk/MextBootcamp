namespace NoteApp;

public class NoteService : INoteService
{
    public string GetNote()
    {
        //Bir txt dosyasından notu okuyup geri döndüreceğiz.
        return "Notumuz burada olacak.";
    }

    public void SaveNote(string text)
    {
        //Gelen string'i bir txt dosyasına kaydedeceğiz.
    }
}
