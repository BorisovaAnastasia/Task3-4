using System;
public sealed class TwoDimensionalArray<T> : Array<T>
{
    private T[,] massiv;
    public TwoDimensionalArray(Func<T> getItem, int N = 4, int M = 3):base(getItem)
    {
        massiv = new T[N, M];
        ReCreate();
;
    }

    protected override void GetArray()
    {
        for (int i = 0; i < massiv.GetLength(0); i++)
        {
            for (int j = 0; j < massiv.GetLength(1); j++)
            {
                massiv[i, j] =  GetItem();
            }
        }
    }

    public override void Print()
    {
        for (int i=0; i < massiv.GetLength(0); i+=1)
        {
            for (int j = 0; j < massiv.GetLength(1); j++)
            {
                if(j == massiv.GetLength(1)-1)
                {
                    Console.WriteLine(massiv[i,j]);
                }
                else
                {
                    Console.Write(massiv[i,j]);
                    Console.Write(" ");
                }
            }
        }
    }
}