class Program
{


    public static void Main()
    {
        WaitList WL = new WaitList("Waiting.txt");
        string result = WL.CheckVip();
        Console.WriteLine(result);
    }
}




