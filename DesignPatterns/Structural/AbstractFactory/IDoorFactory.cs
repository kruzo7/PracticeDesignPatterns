namespace DesignPatterns.Structural.AbstractFactory;

interface IDoorFactory
{
    IDoor MakeDoor();
    IDoorFittingExpert MakeFittingExpert();
}