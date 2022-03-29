namespace DesignPatterns.Behavioral.Memento;

class Editor
{
    private string mContent = string.Empty;
    private EditorMemento memento;

    public string Content
    {
        get { return mContent; }
    }

    public Editor()
    {
        memento = new EditorMemento(string.Empty);
    }

    public void Type(string words)
    {
        mContent = String.Concat(mContent, " ", words);
    }

    public void Save()
    {
        memento = new EditorMemento(mContent);
    }

    public void Restore()
    {
        mContent = memento.Content;
    }
}