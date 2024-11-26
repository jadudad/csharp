using static System.Console;

class Animal
{
    public void Cry() { WriteLine("1. Animal Cry");}
}
class Dog : Animal
{
    public new void Cry() { WriteLine("2. Dog Cry");}
}

class Program
{
    public static void Main()
    {
		Animal ad = new Dog();

		ad.Cry();  // 1 ? 2
	}
}

