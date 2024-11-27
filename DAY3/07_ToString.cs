using static System.Console;

// 120 page ~ 

// ToString()
// => object�� �����ϴ� �޼ҵ��̹Ƿ� ��κ��� Ÿ���� ������ �ִ�.
// => ��ü�� ���¸� ���ڿ��� ��� ������ ���
// => object Ŭ������ �⺻ ������ "Ÿ���̸�" ��ȯ

// �ٽ� : virtual method�̹Ƿ�
//        �Ļ� Ŭ���� �����ڰ� override�ؼ�
//        ��ü�� ���¸� ���ڿ��� ��ȯ�� �� �ֵ��� ����� �ȴ�!

class Point 
{
	private int x = 0;
	private int y = 0;

	public Point(int a, int b) => (x, y) = (a, b);

    public override string ToString()
    {
//      return base.ToString();
        return $"{x}, {y}";
    }
}

class Program 
{
	public static void Main()
	{
		Point p = new Point(1, 2);
		
		string? s = p.ToString();

		WriteLine( s );

		WriteLine(p);  // �� ���� p.ToString()�� ����� ȭ�� ���

		int[] x = { 1, 2, 3 };
		List<int> y = new List<int>();

		WriteLine(x);  // ��Ұ� ������ ������ ������. Ÿ���� �̸� ���
		WriteLine(y);  // ��, object�� �⺻ ���� ���

	}
}
