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

static double FindAvg(int[] tab)
{
    double avg = 0;

    for (int i = 0; i < tab.Length; i++)
    {
        avg += tab[i];
    }

    return avg / tab.Length;

}

int[] arr = new []{5,6,7,9};

Console.WriteLine(FindAvg(arr));

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