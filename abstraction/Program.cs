namespace Abstraction;
public class Program
{
    abstract class Animal
    {
        public abstract void eat();
        public void sound()
        {
            Console.WriteLine("Dog can sound");
        }
    }

    class Dog : Animal{
        public override void eat(){
            Console.WriteLine("It eats bones");
        }
    }

    public static void Main(string[] args){
        Console.WriteLine("Abstraction using the abstract class in c#");
        Dog dog = new();
        Animal animal = dog;
        dog.eat();
        animal.sound();
    }
}