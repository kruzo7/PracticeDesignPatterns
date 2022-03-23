namespace DesignPatterns.Structural.AbstractFactory;

class WoodenDoorFactory : IDoorFactory
{
    public IDoor MakeDoor()
    {
        return new WoodenDoor();

    }

    public IDoorFittingExpert MakeFittingExpert()
    {
        return new Carpenter();
    }
}