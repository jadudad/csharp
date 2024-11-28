using static System.Console;

delegate void MyFunc(int arg);

class Program
{
	public static void M1(int arg)    {}
	public static void M2(double arg) {}
	public static int  M3(int arg) => 0;
	public static void M4(int other)  {}

	public static void Main()
	{
		// ������ ã�� ������
		//  delegate void MyFunc(int arg);
		MyFunc m1 = Program.M1(); // �̰� ��Ȯ������ Program ���� ����
		MyFunc m1 = M1; // ok
		MyFunc m2 = M2; // error. ���� Ÿ�� �ٸ�.
		MyFunc m3 = M3; // error. ��ȯ Ÿ���� �ٸ�.
		MyFunc m4 = M4; // ok.    ������ �������� �޶� �������.
	}
}
