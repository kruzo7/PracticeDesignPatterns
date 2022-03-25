namespace DesignPatterns.Structural.Bridge;

class About : IWebPage
{
    private ITheme theme;

    public About(ITheme theme)    
    {
        this.theme = theme;
    }

    public string GetContent()
    {
        return $"About page in {theme.GetColor()}";
    }
}