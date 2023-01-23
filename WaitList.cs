
//Author:Chloe Girdharry
//Date:1/17/2023
//A spa waitlist 
class WaitList
{
private string[] data;
    public WaitList(string[] data)
    {
        this.data = data;
    }

    public WaitList(string fileName)
    {
        this.data = readData(fileName);
    }

    private string[] readData(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        string[] data = new string[lines.Count()];

        for (int i = 0; i < lines.Count(); i++)
        {
            data[i] = lines[i];
        }
        return data;
    }

  public string CheckVip()
    {
        LinkedList<string> People = new LinkedList<string>();
        People.Append("Zoya");
        People.Append("Ryan");
        People.Append("Mac");
        People.Append("Lisa");

        string name = "Nikko";

        Console.WriteLine("People waiting:");
        Console.WriteLine(People);
     
             
        Console.WriteLine("do you have a vip card?");
        string VipCard = Console.ReadLine();
        if (VipCard.ToLower() == "yes")
        {
          
            People.Prepend(name); 
            Console.WriteLine("you will be put to the front of the line");
             Console.WriteLine(People);
            return VipCard;
        }
        else 
        {
            People.Prepend(name);
            Console.WriteLine("you will be put in the back of the line");
            Console.WriteLine(People);
            return VipCard;
        }
    }
}

  
   


