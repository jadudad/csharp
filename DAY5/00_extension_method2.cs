class Example { public void M1() { } }

static class MyExtension
{
    // �Ʒ� 2�� �޼ҵ�� �׳�, static Ŭ������ static �޼ҵ� �Դϴ�.
    public static void M2(this Example obj) { }
    public static void M3(Example obj) { }
}

class Program
{
    public static void Main()
    {
        Example e = new();
        e.M1();

        // M2, M3 �� static Ŭ������ static �޼ҵ��̹Ƿ� �Ʒ� ó�� ȣ�� ����
        MyExtension.M2(e); // ok
        MyExtension.M3(e); // ok

        e.M2(); // ok      �̷��� ����ϱ� ���ؼ� this �� �ʿ�!!
        e.M3(); // error.  this �� ����.

    }
}