namespace ControlFlow.App;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Control Flow Assignment");

        // Example usage
        Console.WriteLine("Enter a animal:");
        string animal = Console.ReadLine();

        Console.WriteLine("Is the animal a dog? " + IsDog(animal));
        Console.WriteLine("The sound of the animal is: " + GetAnimalSound(animal));
        PrintAnimalSound10Times(GetAnimalSound(animal));
    }

    // Method to check if a number is even
    public static bool IsDog(string animal)
    {
        throw new NotImplementedException();
    }

    // Method to get the animal sound for a dog, cat, cow, or sheep
    public static string GetAnimalSound(string animal)
    {
        throw new NotImplementedException();
    }

    // Method to print the animal sound 10 times
    public static void PrintAnimalSound10Times(string sound)
    {
        throw new NotImplementedException();
    }
}
