using static System.Console;

delegate void MyFunc(int arg);

class Test
{
    public static void SMethod(int arg) => WriteLine("Test.SMethod");
    public void IMethod(int arg) => WriteLine("Test_Object.IMethod");
}

class Program
{
    public static void Main()
    {
        Test t = new Test();

        Test.SMethod(1); // static �޼ҵ�� Ŭ���� �̸����� ȣ��
        t.IMethod(1);    // instance �޼ҵ�� ��ü�̸����� ȣ��

        MyFunc f1 = ?;
        MyFunc f2 = ?;

        f1(10); // Test.SMethod(10)
        f2(10); // t.IMethod(10)


    }
}