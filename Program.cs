using Newtonsoft.Json;
using System;


public struct person
{
    public String Firstname;
    public String Lastname;
    public int hight;
    public String job;
}

class WorkWithFiles
{
    public static void Main(string[] args)
    {
        person p1 = new person();

        Console.WriteLine("Enter first name:\n");
        p1.Firstname = Console.ReadLine();
        Console.WriteLine("Enter last name:\n");
        p1.Lastname = Console.ReadLine();
        Console.WriteLine("Enter hight:\n");
        p1.hight = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter job:\n");
        p1.job = Console.ReadLine();


        String personDetails = JsonConvert.SerializeObject(p1);
        String path = "person.txt";
        if (File.Exists(path))
        {
            var f = File.Create(path);
            f.Close();
        }
        File.WriteAllText(path, personDetails);


        /////////////////////////////////////////////////////////////////////
        ///

        String read = File.ReadAllText(path);
        person p2 = new person();
        p2 = JsonConvert.DeserializeObject<person>(read);
        Console.WriteLine(p2.Firstname + " , " + p2.job);
        
        Thread.Sleep(10000);

        
        

    }
}