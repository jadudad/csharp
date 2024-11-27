using static System.Console;

// method override ( 104 page ~ )
// C++ �� �����Լ� �̾߱�� ������ �̾߱�

class Animal
{
    public void Cry() { WriteLine("1. Animal Cry"); }
}
class Dog : Animal
{
    // method override : ��� Ŭ���� �޼ҵ带 �Ļ�Ŭ������ �ٽ� �����ϴ� ��
    // C++ : �Ʒ� ó���ϸ� ok.  C# : ��� �߻�(��Ȯ�� �ϱ� ���� new)�� ǥ���϶�� ��
    // public void Cry() { WriteLine("2. Dog Cry"); }

    public new void Cry() { WriteLine("2. Dog Cry"); }
}

class Program
{
    public static void Main()
    {
        Animal a = new Animal();
        Dog d = new Dog();

        a.Cry();  // 1. Animal.Cry
        d.Cry();  // 2. Dog.Cry

        // -------------------------------
        Animal ad = d; // ���� ��ü�� Dog,  ���� Ÿ���� Animal Ÿ��

        // if (����� �Է� == 1) ad = a; // <<== A

        ad.Cry(); // Animal.Cry �� ȣ��ɱ�� ? Dog.Cry �� ȣ��ɱ�� ?
                  // => �������δ� Dog.Cry�� �½��ϴ�.
                  // C++ / C# : Animal Cry ȣ��
                  // Java, Swift, Objective-C, Python, kotlin�� ��κ� : Dog Cry
    }
}

// �Ʒ� ������ 104 page ����

// ad.Cry()�� � �Լ�(�޼ҵ�)�� ������ ���ΰ�?
// => �Լ� ���ε�(function binding)�̶�� �մϴ�.

// 1. static binding : ������ �ð��� �����Ϸ��� �Լ� ȣ���� ����
//                     �����Ϸ��� ad�� ���� � ��ü�� ����Ű���� �� �� �����ϴ�.
//                     ������ "A" ���� �ڵ尡 �ִٸ� ����� ���� �����ϹǷ�
//                     �����Ϸ��� �ƴ� ������ ������ "ad" ��ü�� Animal�̶�� ��
//                     ���� �����Ϸ��� �����ϸ� Animal Cry ȣ��

// ��������, �������� �ʴ�.
// C++ �⺻ ���ε�

// 2. dynamic binding : ���� �ð��� �Լ� ȣ���� ����(� �Լ��� ��������)
//                      ������ �ð����� "ad"�� ����Ű�� ���� �����ϴ� ����(IL) ����
//                      ����ð��� ���� ��ü�� ���� �� �ش� ��ü�� Cry ȣ��
//                      ad�� Dog�� �����״ٸ� Dog Cry ȣ��

// �������� �����̴�.
// Java, Python, Swift�� ��κ� ��ü���� ����� �⺻ ��å.
// C++/C#�� virtual method(�Լ�)

