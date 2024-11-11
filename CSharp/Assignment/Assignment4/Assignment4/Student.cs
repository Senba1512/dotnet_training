using System;

public interface IStudent
{
    
    int StudentId { get; set; }
    string Name { get; set; }

    
    void ShowDetails();
}

public class Dayscholar : IStudent
{
  
    public int StudentId { get; set; }
    public string Name { get; set; }

    
    public Dayscholar(int studentId, string name)
    {
        StudentId = studentId;
        Name = name;
    }

    
    public void ShowDetails()
    {
        Console.WriteLine("Dayscholar Student Details:");
        Console.WriteLine($"Student ID: {StudentId}");
        Console.WriteLine($"Name: {Name}");
    }
}


public class Resident : IStudent
{
    
    public int StudentId { get; set; }
    public string Name { get; set; }

    
    public Resident(int studentId, string name)
    {
        StudentId = studentId;
        Name = name;
    }

    
    public void ShowDetails()
    {
        Console.WriteLine("Resident Student Details:");
        Console.WriteLine($"Student ID: {StudentId}");
        Console.WriteLine($"Name: {Name}");
    }
}


public class  StudProgram
{
    public static void Main()
    {
        
        IStudent dayscholar = new Dayscholar(101, "Alice");
        dayscholar.ShowDetails();

        Console.WriteLine();

        
        IStudent resident = new Resident(102, "Bob");
        resident.ShowDetails();
        Console.Read();
    }
}

