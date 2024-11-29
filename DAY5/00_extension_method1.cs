// github.com/codenuri/dscs ���� DAY5.zip

using static System.Console;

// extension method( 115p ~ )



// ������ �����ϴ� Ŭ������ �޼ҵ带 �߰��ϰ� �ʹ�.
// #1. ��� ���� ��� 
// => �߰��� �޼ҵ带 ����Ϸ��� "�Ļ� Ŭ�����̸�" �� ����ؾ� �Ѵ�.

// #2. Extension method ���� ���
// => ���� Ŭ���� �̸��� ��� ��밡��

class Example
{
    public void Foo() => WriteLine("Example Foo");
}

// �Ʒ� �ڵ尡 Example Ŭ������ �޼ҵ带 �߰��� �ڵ�
// ��Ģ 
// #1. static Ŭ������ static method �� ������ �մϴ�.
// #2. static method �� 1��° ���ڷ� "this �޼ҵ带 �߰��� Ŭ�����̸�"
// #3. �Ʒ� �ڵ忡�� "MyExtension" �̸��� �ƹ��̸��̳� ����ص� �˴ϴ�.

// Example �� �׳� Goo �߰��ϸ� �ȵǳ��� ?
// => Example �� �ٸ� ����� ���� Ŭ�����̰�,
// => �ҽ��� ���� �̹� �����ϵ� ���̺귯�� ���¶�� �޼ҵ带 �߰��Ҽ� �����ϴ�.
// => extension �޼ҵ�δ� �߰� ����.

static class MyExtension
{
    public static void Goo(this Example e, int n)
    {
        Console.WriteLine("Example Goo");
    }
}


class Program
{
    public static void Main()
    {
        Example e = new();
        e.Foo();
        e.Goo(3);// 1. Example �� Goo �� �ִ��� �˻�

        // 2. ���ٸ� ��� static Ŭ������ �����ؼ� 
        //    1��° ���ڷ� "this Example" �� ���� static �޼ҵ带 ã�´�

        // 3. �׸��� �����Ϸ��� "MyExtension.Goo(e, 3)" ���� �����Ѱ�
    }
}
