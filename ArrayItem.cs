using System;

public class ArrayItem
{
    protected bool UserInput;

    public ArrayItem(bool userInput)
    {
        UserInput = userInput;
    }

    protected int GetIntRnd()
    {
        Random random = new Random();
        return random.Next(0, 101);
    }

    protected int GetIntUser()
    {
        Console.WriteLine("Enter the number: ");
        return Convert.ToInt32(Console.ReadLine());
    }
    public int GetInt()
    {
        if (UserInput)
        {
            return GetIntUser();
        }
        else
        {
            return GetIntRnd();
        }
    }

    protected string GetStringRnd()
    {
        Random random = new Random();
        string[] mas = new string[] {"word_1", "word_2", "word_3", "word_4"};
        return  mas[random.Next(0, 4)];
    }

    protected string GetStringUser()
    {
        Console.WriteLine("Enter the string: ");
        var str =  Console.ReadLine();
        return str;
    }
    public string GetString()
    {
        if (UserInput)
        {
            return GetStringUser();
        }
        else
        {
            return GetStringRnd();
        }
    }

    protected bool GetBoolRnd()
    {
        Random random = new Random();
        return Convert.ToBoolean(random.Next(0, 2));
    }

    protected bool GetBoolUser()
    {
        Console.WriteLine("Enter true or false: ");
        return Convert.ToBoolean(Console.ReadLine());
    }
    public bool GetBool()
    {
        if (UserInput)
        {
            return GetBoolUser();
        }
        else
        {
            return GetBoolRnd();
        }
    } 

    protected double GetDoubleRnd()
    {
        Random random = new Random();
        return random.Next(-100, 101);
    }

    protected double GetDoubleUser()
    {
        Console.WriteLine("Enter the number(double): ");
        return Convert.ToDouble(Console.ReadLine());
    }
    public double GetDouble()
    {
        if (UserInput)
        {
            return GetDoubleUser();
        }
        else
        {
            return GetDoubleRnd();
        }
    } 
}