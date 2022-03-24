namespace DesignPatterns.Creational.AbstractFactory;

interface IDoorFactory
{
    IDoor MakeDoor();
    IDoorFittingExpert MakeFittingExpert();
}