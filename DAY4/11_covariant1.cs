using static System.Console;

class Base
{
    public void Method() => WriteLine("Method");
}
class Derived : Base
{
}

delegate R MyFunc<R>();

class Program
{
    public static Derived CreateDerived() => new Derived();

    public static void Main()
    {
        // f1�� "Derived �� ����� �ִ�" �޼ҵ带 ��� �ֽ��ϴ�.
        // ��, f1�� ȣ���ϸ� Derived �� �����˴ϴ�.
        MyFunc<Derived> f1 = CreateDerived;

        // f2 ���� Base �� �����(��ȯ�ϴ�) �ִ� �޼ҵ带 ��ƾ� �մϴ�.
        // => f2() �� ȣ���ϴ� ������ Base�� ������� �ϴ°�
        MyFunc<Base> f2;


        f2 = f1; // �ǵ� ���� ���� �����ϴ�.
                 // Base �� �ʿ��ѵ�, Derived �� ����� �൵ ���� �ɰ� �����ϴ�.



        Base b = f2();

        b.Method();
    }
}