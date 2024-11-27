using static System.Console;

class Animal
{
    // non-virtual : static binding �ش޶�� �ǹ�. �����Ϸ��� ����
    //               ���������� Ÿ�Կ� ���� ȣ��
    public void Cry1() { WriteLine("1. Animal Cry1"); }

    // virtual method : dynamic binding �ش޶�� �ǹ�.
    //                  ����ð��� ���������� ����Ű�°�ü�� ���� �����ؼ�
    //                  ��ü�� �´� �޼ҵ带 ȣ���� �޶�.
    public virtual void Cry2() { WriteLine("1. Animal Cry2"); }
}

class Dog : Animal
{
    public new void Cry1() { WriteLine("2. Dog Cry1"); }
    public override void Cry2() { WriteLine("2. Dog Cry2"); }
}

class Program
{
    public static void Main()
    {
        Animal ad = new Dog();

        ad.Cry1();  // 1. Animal Cry1
        ad.Cry2();  // 2. Dog Cry2
    }
}
