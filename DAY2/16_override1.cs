using static System.Console;

class Animal
{
    public void Cry() { WriteLine("1. Animal Cry");}
}
class Dog : Animal
{
}

class Program
{
    public static void Main()
    {
		Animal a = new Animal();
        Dog d = new Dog();

        a.Cry();	
		d.Cry();	
	}
}

