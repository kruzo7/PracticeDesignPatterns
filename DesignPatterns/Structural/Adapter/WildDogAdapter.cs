namespace DesignPatterns.Structural.Adapter;

class WildDogAdapter : ILion
{
    private WildDog mDog;

    public WildDogAdapter(WildDog dog)
    {
        this.mDog = dog;
    }

    public void Roar()
    {
        mDog.Bark();
    }
}