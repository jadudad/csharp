using static System.Console;

class Animal
{

    public void Cry1() { WriteLine("1. Animal Cry1"); }

    public virtual void Cry2() { WriteLine("1. Animal Cry2"); }
    public virtual void Cry3() { WriteLine("1. Animal Cry3"); }

}

class Dog : Animal
{
    public new void Cry1() { WriteLine("2. Dog Cry1"); }
    public override void Cry2() { WriteLine("2. Dog Cry2"); }

    // virtual method�� new�� �ٽ� ������� �ֽ��ϴ�.
    // => ��� Ŭ������ override�� �ƴ϶� ���Ӱ� ����� �޼ҵ��� �ǹ�
    // =>  ���� ������ �ʴ� ����
    // => ad.Cry3() => Animal Cry3 ȣ��
    public new void Cry3() { WriteLine("2. Dog Cry3"); }
}

class Program
{
    public static void Main()
    {
        Animal ad = new Dog();

        ad.Cry1();  // 1. Animal Cry1
        ad.Cry2();  // 2. Dog Cry2
        ad.Cry3();  // 1. Animal Cry3
    }
}
