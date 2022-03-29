namespace DesignPatterns.Behavioral.Memento;

class EditorMemento
{
    private string mContent;

    public string Content
    {
        get { return mContent; }
    }

    public EditorMemento(string content)
    {
        mContent = content;
    }

}