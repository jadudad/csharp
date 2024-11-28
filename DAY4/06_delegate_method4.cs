using static System.Console;

// multicast 
delegate void MyFunc(int arg);

class Test
{
    public static void SMethod(int arg) => WriteLine("Test.SMethod");
    public        void IMethod(int arg) => WriteLine("Test_Object.IMethod");
}

class Program
{
	public static void SMethod(int arg) => WriteLine("Program.SMethod");

	public static void Main()
	{	
		Test t = new Test();

		MyFunc f = Test.SMethod; // ù��° �޼ҵ� ���

		// += �� ������ �޼ҵ� ��� �����մϴ�.
		f += t.IMethod;
		f += Program.SMethod;
	
		f(10); // ��ϵ� ������ ȣ��

		f -= t.IMethod(); // ����

		f(10);

	}
}
