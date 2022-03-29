using System.Collections;

namespace DesignPatterns.Behavioral.Iterator;

class StationList : IEnumerable<RadioStation>
{

    List<RadioStation> mStations = new List<RadioStation>();

    public RadioStation this[int index]
    {
        get { return mStations[index]; }
        set { mStations.Insert(index, value); }
    }

    public void Add(RadioStation station)
    {
        mStations.Add(station);
    }

    public void Remove(RadioStation station)
    {
        mStations.Remove(station);
    }

    public IEnumerator<RadioStation> GetEnumerator()
    {
        return this.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        foreach(var x in mStations)
        {
            yield return x;
        }
    }
}