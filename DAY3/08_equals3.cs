using static System.Console;

class Point 
{
	private int x = 0;
	private int y = 0;
	public Point(int a, int b) => (x, y) = (a, b);

	public override bool Equals(object? obj)
	{
		if ( obj == null || !(obj is Point) )
		 	return false;

		Point p = (Point)obj;
		
    	return x == p.x && y == p.y;
	}	
	public override int GetHashCode() 
	{
		return x.GetHashCode() + y.GetHashCode();
	}	
}

class Program
{
	public static void Main() 
	{
		Point p1 = new Point(1,2);
		Point p2 = p1;
		Point p3 = new Point(1,2);
		Point p4 = new Point(1,2);

		// #1. ��ü�� �����Ѱ�?
		WriteLine($"{p1 == p2}"); // True
		WriteLine($"{p3 == p4}"); // False

		// #2. ���°� �����Ѱ�? (override �� ��츸)
		WriteLine($"{p1.Equals(p2)}"); // True
		WriteLine($"{p3.Equals(p4)}"); // True

		// ���°� �����Ѱ��� �����ϴ� �ּ��� �ڵ尡 �����?
		bool b = p1 == p2; // ��ü�� �������� ���� �����ϰ� (���࿡ ��Ұ� ������ �ϳ��ϳ� �� �� ���� ����)

		if (b == false)    // �ٸ� ��ü�϶��� ���¸� ��������.
		{
			b = p1.Equals(p2);
		}

		//  #3. object�� static method Equals�� �� �ڵ�� ����
		//      instance method Equals��
		//      static method Equals�� �� �����ϼ���.
		WriteLine($"{object.Equals(p1, p2)}");
		WriteLine($"{object.Equals(p3, p4)}");	

		// ���
		// "���°� �����Ѱ�?" �����
		// 1. p1.Equals(p2) ���ٴ�
		// 2. object.Equals(p1,p2)�� �� �� ȿ�����Դϴ�.
		
		// �׷���, Pointó�� ����� ���� ������
		// => p1.Equals(p2)�� ������ �ʽ��ϴ�.

	}
}

