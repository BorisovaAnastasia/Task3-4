using System;

public sealed class OneDimensionalArray<T> : Array<T>
{
    private T[] massiv;

    public OneDimensionalArray(Func<T> getItem, int n = 4):base(getItem)
    {
        massiv = new T[n];
        ReCreate();
    }

    protected override void GetArray()
    {
        for (int i = 0; i < massiv.Length; i++)
        {
            massiv[i] = GetItem();
        }
    }

    public override void Print()
    {
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine(massiv[i]);
        }
    }
}