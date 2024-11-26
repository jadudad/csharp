// property�� C# ���� �����Դϴ�. VB.net, C++/CLI���� �����ϴ�.
// ��, IL �ڵ忡�� �̷� ������ �����ϴ�.
// => �����Ϸ��� "set_Age(), get_Age()" ��� �޼ҵ�� �����ϰ� �˴ϴ�.
// => #1. �Ʒ� �ڵ� ������ ��������
// => #2. ILDASM �����ؼ� "Day2.dll" ���� ������.
//    (������ ���� ��ư => "developer ..." �˻��ؼ� �����ϰ� ILDASM ����
//    (DAY2/bin/debug/net8.0/day2.dll...)
//

class Person
{
    public int age;

    public int Age
    {
        get { return age; }
        set { if (value > 0 && value < 150) age = value; }
    }

    // �� �ڵ忡 ���ؼ� set_Age, get_Age �޼ҵ尡 �����˴ϴ�.
    // => ����ڰ� �Ʒ�ó�� ����� �浹 �߻�. �����Դϴ�.
    // public void set_Age(int a) { age = a; }
    


}


class Program
{
    public static void Main()
    {
        Person p = new Person();

        p.Age = 10;
        int n = p.Age;

        // p.set_Age(3); // C# 1.0���� �� �ڵ嵵 �����߽��ϴ�. �׷���, ������ ����
        
        Console.WriteLine(n);

        // ����
        int if = 0; // error. if�� Ű����, Ű���带 ���� �̸����� ����� �� �����ϴ�.
                    // (if, switch, int, double, for, foreach)
        int value = 0; // ok.

        // ������ Ű���� (context keyword)
        // => Ư�� ����(�ڵ�) �ȿ����� ���Ǵ� Ű����
        // => value�� property�� set������ ���˴ϴ�.
        //    �ٸ� �������� ��� �ȵ˴ϴ�.
        // => ���� �̸����� ��밡��
    }
}


