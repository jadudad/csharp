using static System.Console;

// System.Object
// => C#�� ��κ� Ÿ���� System.Object�κ��� ��� �ް� �ȴ�.
// => 7���� �޼ҵ带 ���� Ŭ����
// => ref struct��� ������ ���� Ÿ���� ��ȸ (C# 9.0 ~)

//����� �ڵ�    //�����Ϸ��� ������ �ڵ�
class Car        //class Car : System.Object
{	
}

class Program
{
	public static void Main()
	{
		Car c = new Car();

		WriteLine( c.ToString() ); // ok

		object o = c;
	}
}
