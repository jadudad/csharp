using System;
using static System.Console;



delegate void MyFunc(int arg);

// delegate ����
// => ��ó�� ��Ģ(����)�� �°� �ڵ带 �ۼ��ϸ�
// => �����Ϸ��� �Ʒ� Ŭ������ �����մϴ�.
// => ����, "MulticastDelegate" �� ���� ��ӹ޴� Ŭ������
//          ����ڰ� ���� ������� �����ϴ�.
// => �� �ڵ带 �����ϼ���. ILASM ���� DAY4.dll �������

/*
class MyFunc : MulticastDelegate
{
    // ��ȯ���� void �̰� ���ڰ� int �Ѱ��� 
    // �޼ҵ� �ּҸ� ������ �� �ʿ��� �ڵ� �߰�

    public void Invoke(int arg) { ����� �ּ��� �޼ҵ� ȣ��}

    // operator() �����ڵ� ����
}
*/


class Program
{
    public static void Main()
    {
        // �ᱹ MyFunc�� �����Ϸ��� ���� "class"�� �̸��Դϴ�.
        // => C#�� ��� ��ü�� new�� �����ؾ� �մϴ�.
        // => ��, ǥ��Ÿ���� ���� ǥ��� �ؼ� new ���� ����
        // => delegate�� ���� ǥ��� ����

        MyFunc f1 = new MyFunc(Foo);
        MyFunc f2 = Foo; // �� ǥ����� ���
                         // �� ǥ��� ����(pool���� ������)
                         // string�� intern pool�� ����

        f(10);          // Foo(10)
        f.Invoke(10);   // Foo(10)
    }

    public static void Foo(int arg)
        => WriteLine($"Foo : {arg}");
}