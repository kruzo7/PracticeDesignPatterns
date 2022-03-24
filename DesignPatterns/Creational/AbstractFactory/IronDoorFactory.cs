namespace DesignPatterns.Creational.AbstractFactory;

class IronDoorFactory : IDoorFactory
{
    public IDoor MakeDoor()
    {
        return new IronDoor();
    }

    public IDoorFittingExpert MakeFittingExpert()
    {
        return new Welder();
    }
}