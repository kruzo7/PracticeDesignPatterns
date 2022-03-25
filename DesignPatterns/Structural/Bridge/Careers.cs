namespace DesignPatterns.Structural.Bridge;

class Careers : IWebPage
{
    private ITheme theme;

    public Careers(ITheme theme)    
    {
        this.theme = theme;
    }

    public string GetContent()
    {
        return $"Careers page in {theme.GetColor()}";
    }
}