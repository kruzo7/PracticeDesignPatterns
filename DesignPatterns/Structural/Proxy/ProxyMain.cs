namespace DesignPatterns.Structural.Proxy;

class ProxyMain
{
    public static void Run()
    {
        var door = new SecuredDoor(new LabDoobr());
        door.Open("invalid");

        door.Open("Secr@t");
        door.Close();
    }
}