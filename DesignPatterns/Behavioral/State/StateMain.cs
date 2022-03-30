namespace DesignPatterns.Behavioral.State;

class StateMain
{
    public static void Run()
    {
        var editor = new TextEditor();

        editor.Type("First line.");
        
        editor.SetState(new UpperCase());
        editor.Type("Second line.");
        editor.Type("Third line.");

        editor.SetState(new LowerCase());
        editor.Type("Fourth line.");
        editor.Type("Fifth line.");
    }
}