namespace DesignPatterns.Behavioral.Memento;

class MementoMain
{
    public static void Run()
    {
        var editor = new Editor();

        editor.Type("This is the first sentence.");
        editor.Type("This is second.");

        editor.Save();

        editor.Type("This is third.");

        Console.WriteLine(editor.Content);

        editor.Restore();

        Console.WriteLine(editor.Content);
    }
}