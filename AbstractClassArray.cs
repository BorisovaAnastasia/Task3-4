using System;
public abstract class Array <T>: IPrint
{
    protected Func<T> GetItem;

    protected Array(Func<T> getItem)
    {
        GetItem = getItem;
    }

    protected abstract void GetArray();
    public abstract void Print();
    
    public void ReCreate()
    {
        GetArray();
    }
}