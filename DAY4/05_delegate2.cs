using System;
using static System.Console;

// �ٽ� #1. delegate ����� �� ��Ȯ�� �˾� �μ���
// => 1. �޼ҵ� ���� ����� �����
// => 2. ��ȯŸ�� �տ� "delegate" �߰�
// => 3. �޼ҵ� �̸��� ���ϴ� "Ÿ���̸�" ���� ����

delegate void MyFunc(int arg);

class Program
{
    public static void Main()
    {
        MyFunc f = Foo;  // f�� Foo �� ȣ�� ����(�޼ҵ� �ּ� �� ��ü����)
                         // �� ��� �˴ϴ�.

        f(10);          // Foo(10)
        f.Invoke(10);   // Foo(10)
    }

    public static void Foo(int arg)
        => WriteLine($"Foo : {arg}");
}