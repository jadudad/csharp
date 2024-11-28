using static System.Console;

class Base
{
    public void Method() => WriteLine("Method");
}
class Derived : Base { }

// ��ȯ Ÿ�� �̾߱Ⱑ �ƴ϶�..
// ���� �̾߱� �Դϴ�. 
//delegate void MyAction<T>(T obj); // �̷��� �ϸ� ��Ȯ�� Ÿ�Ը� ����
delegate void MyAction<T>(in T obj); // ȣȯ ������Ÿ���� ok. 

class Program
{
    public static void UseBase(Base b) { b.Method(); }

    public static void Main()
    {
        // f1���� ���ڷ� Base ��ü�� �޴� �޼ҵ带 ������ �ֽ��ϴ�.
        // => f1���� Base ��ü�� �����ڴٴ� �ǵ�
        MyAction<Base> f1 = UseBase;

        // f2���� ���ڷ� Derived ��ü�� �޴� �޼ҵ带 ������ �ֽ��ϴ�.
        // => ��, ���ڷ� Derived �� ���� �ڴٴ� �ǵ�.. 
        MyAction<Derived> f2;

        f2 = f1;  // �ᱹ f2 �� UseBase �� ��� �˴ϴ�.
                  // ��, UseBase() �� Base ��ü�� �ʿ� �մϴ�.

        f2(new Derived()); // Base ��ü�� �ʿ��ѵ�.
                           // DErived �� ����..
                           // ������ �������� �ʽ��ϴ�.

    }
}