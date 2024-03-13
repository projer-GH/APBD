int Add(int a, int b)
{
    return a+b;
}


Console.WriteLine(Add(9,-1));


int Multiply(int a, int b)
{
    return a * b;
}

Console.WriteLine("Hey");;;

static int FindMax(int[] tab)
{
    int max = 0;
    for (int i = 0; i < tab.Length; i++)
    {
        if (tab[i] > max)
        {
            max = tab[i];
        }
    }

    return max;
}


int[] tab = new []{1,2,-3,-8,3,16,27,1,18};

Console.WriteLine(FindMax(tab));