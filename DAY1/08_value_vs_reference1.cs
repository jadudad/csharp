using System.Drawing;
using static System.Console;

// Value Type vs Reference Type - 31page ~ 
// => C# ����� �ٽ�
// 

// C#�� ��� Ÿ���� "struct" �Ǵ� "class" �������� ������� Ÿ���̴�.
// struct : value type
// class : reference type

class CPoint
{
	private int x;
	private int y;
	public CPoint(int a, int b) { x = a; y = b;}
}
struct SPoint
{
	private int x;
	private int y;
	public SPoint(int a, int b) { x = a; y = b;}	
}
class Program 
{
	public static void Main()
	{
		// �Ʒ� �ڵ� ���� �� �޸� �׸��� 36page�Դϴ�.
		CPoint cp = new CPoint(0, 0);
		SPoint sp = new SPoint(0, 0);	
	}
}


// C/C++
// => �޸� ��ġ�� Ÿ�� ����ڰ� ����.
// Point pt; // pt�� ���ÿ� ���̰� �˴ϴ�.
// Point* p = new Point(); // ���� ����

// C#, Java, Swift
// => �޸� ��ġ�� "Ÿ�� ������"�� ����
// => Ÿ���� ũ�� ���� ������ �����ڰ� �� �� �ִ�.

// struct : stack�� ����, value type
// class : heap�� ����, stack���� ����(������)�� ����Ű�� ��. reference type