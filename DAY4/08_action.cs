// non-generic Ŭ������ generic Ŭ������ �̸��� ���Ƶ� �浹 �ƴմϴ�.(��������)
// generic Ŭ���� ������ Ÿ�� ���ڰ����� �ٸ��� ���� �̸� �����մϴ�.

/*
 * �Ʒ� Action �� �̹� C# ǥ�ؿ� �ֽ��ϴ�.
 * ���ڰ� 16������ ���� �˴ϴ�.
delegate void Action();
delegate void Action<T>(T arg);
delegate void Action<T1, T2>(T1 arg1, T2 arg2);
*/

class Program
{
    public static void M1() { }
    public static void M2(int arg) { }
    public static void M3(double arg) { }
    public static void M4(int arg1, double arg2) { }

    public static void Main()
    {
        Action f1 = M1;
        Action<int> f2 = M2;
        Action<double> f3 = M3;
        Action<int, double> f4 = M4;

    }
}