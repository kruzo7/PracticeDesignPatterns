namespace DesignPatterns.Behavioral.Iterator;

class RadioStation
{
    private float mFrequency;

    public RadioStation(float frequency)
    {
        mFrequency = frequency;
    }

    public float GetFrequency()
    {
        return mFrequency;
    }

}