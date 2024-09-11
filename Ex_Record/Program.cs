
public record Person(string FirstName, string LastName);
public record struct Dog(string Name, int Age);

class Program
{
    static void Main(string[] args)
    {
        var person = new Person("John", "Doe");
        var person3 = new Person("John ", "Doe");
        var person2 = person;
        var (firstName, lastName) = person2;
        Console.WriteLine(person);
        Console.WriteLine(person.GetHashCode() == person3.GetHashCode());

        var dog = new Dog("dog", 10);
        var dog2 = dog;
        Console.WriteLine(dog);
        Console.WriteLine(dog == dog2);
    }
}