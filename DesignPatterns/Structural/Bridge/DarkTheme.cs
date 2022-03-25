namespace DesignPatterns.Structural.Bridge
{
    public class DarkTheme : ITheme
    {
        public string GetColor()
        {
            return "Dark Black";
        }
    }
}