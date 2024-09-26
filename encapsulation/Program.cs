namespace Encapsulation;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("For understanding the oops concept Encapsulation.");
        Student student = new();
        //Setting values in the properties
        student.Id = 1234;
        // student.Name = "Kathir";
        student.Email = "kathirvelsivaking@gmail.com";
        //Getting the values
        Console.Write($"{student.Id}-{student.Name}-{student.Email}");
    }
}