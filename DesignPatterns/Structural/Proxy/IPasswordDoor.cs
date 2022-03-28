namespace DesignPatterns.Structural.Proxy;

interface IPasswordDoor
{
    void Open(string password);

    void Close();
}