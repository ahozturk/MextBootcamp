// See https://aka.ms/new-console-template for more information
using NoteApp;

Console.WriteLine("Hello, World!");

NoteService noteService = new NoteService();

string input = Console.ReadLine();

noteService.SaveNote(input);

Console.WriteLine(noteService.GetNote());