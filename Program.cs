using System;

class Program
{
    static void Main()
    {
        var arrayItem = new ArrayItem(false);

        var massiv_int = new Array<int>[2];
        massiv_int[0] = new OneDimensionalArray<int>(arrayItem.GetInt);
        massiv_int[1] = new TwoDimensionalArray<int>(arrayItem.GetInt);
        
        var mass_double = new Array<double>[2];
        mass_double[0] = new OneDimensionalArray<double>(arrayItem.GetDouble);
        mass_double[1] = new TwoDimensionalArray<double>(arrayItem.GetDouble);
        
        var massiv_bool = new Array<bool>[2];
        massiv_bool[0] = new OneDimensionalArray<bool>(arrayItem.GetBool);
        massiv_bool[1] = new TwoDimensionalArray<bool>(arrayItem.GetBool);

        var massiv_str = new Array<string>[2];
        massiv_str[0] = new OneDimensionalArray<string>(arrayItem.GetString);
        massiv_str[1] = new TwoDimensionalArray<string>(arrayItem.GetString);

        Week masss = new Week();

        IPrint[] print = new IPrint [] {massiv_int[0],massiv_int[1], mass_double[0], mass_double[1], massiv_bool[0], massiv_bool[1], massiv_str[0],massiv_str[1], masss};

        for (int i=0; i<print.Length; i++)
        {
            print[i].Print();
            Console.WriteLine(" ");
        }
    }
}