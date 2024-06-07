namespace NoteApp;

public interface INoteService
{
    void SaveNote(string text);

    string GetNote();
}
