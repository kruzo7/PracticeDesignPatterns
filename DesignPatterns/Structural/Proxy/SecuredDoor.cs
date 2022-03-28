namespace DesignPatterns.Structural.Proxy;

class SecuredDoor : IDoor
{
    private IDoor mDoor;

    public SecuredDoor(IDoor door)
    {
        mDoor = door ?? throw new ArgumentNullException("door", "door should not be null");
    }

    public void Close()
    {
        mDoor.Close();
    }

    public void Open(string password)
    {
        if(Authenticate(password))
        {
            mDoor.Open();
        }
        else
        {
            Console.WriteLine("Unauthorized.");
        }
    }

    private bool Authenticate(string password)
    {
        return password == "Secr@t";
    }
}