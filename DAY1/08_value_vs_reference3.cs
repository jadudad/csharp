using static System.Console;

class CPoint
{
	public int x;
	public int y;
	public CPoint(int a, int b) { x = a; y = b;}
}
struct SPoint
{
	public int x;
	public int y;
	public SPoint(int a, int b) { x = a; y = b; }	
}

class Program 
{
	public static void Main()
	{
		// 38page �׸� ����
		CPoint cp1; // ��ü �����ȵ�. ����(������) ������ ���� �� .
		SPoint sp1; // ��ü ������. Read�� �ȵȴ�. Write�� ���� �ִ�.
		SPoint sp2 = new SPoint(1, 1); // ��ü ����. Read/Write ����. ��� ����.
		
		// sp1�� ��ü�� ����.
		int a = cp1.x;	// error
		cp1.x = 2;		// error

		// sp1�� �ʱ�ȭ �ȵ� ��ü
		int b = sp1.x;	// error. Read!!!
		sp1.x = 2;		// ok. Write
		int c = sp1.x;	// ok. Write �Ŀ��� Read ����

		// sp2�� �ʱ�ȭ�� ��ü (������ ȣ���.)
		int d = sp2.x;	// ok
		sp2.x = 2;		// ok

	}
}
