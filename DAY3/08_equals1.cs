using static System.Console;

// 124 page ~
 class Point 
 {
	private int x = 0;
	private int y = 0;
	public Point(int a, int b) => (x, y) = (a, b);
}

class Program
{
	public static void Main() 
	{	
		// ��ü�� ���ϼ����� 2���� ������ �ֽ��ϴ�.
		// 1. ��ü ��ü�� �����Ѱ�?
		// 2. ��ü�� �ٸ����� ���°� �����Ѱ�?

		Point p1 = new Point(1,2);
		Point p2 = p1;

		Point p3 = new Point(1,2);
		Point p4 = new Point(1,2);
	}
}
