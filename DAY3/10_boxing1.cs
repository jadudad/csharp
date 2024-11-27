using System.Net.Http.Headers;
using static System.Console;

// 137page ~

class CPoint
{
    public int X { set; get; } = 0;
    public int Y { set; get; } = 0;
    public CPoint(int a, int b) => (X, Y) = (a, b);
}
struct SPoint
{
    public int X { set; get; } = 0;
    public int Y { set; get; } = 0;
    public SPoint(int a, int b) => (X, Y) = (a, b);
}

class Program
{
    public static void Main()
    {
        // #1. Reference Type �� ��ü�� ���� �����
        // #2. ���� ������ ���ÿ� �����Ǽ� ���� �ִ� ��ü�� ����Ű�� �˴ϴ�
        // #3. ���� ������ �ı��ǰ� Ư�������� �����ϸ� ���� ��ü�� �ڵ��ı��˴ϴ�.
        //     (garbage collector)
        {
            CPoint p1 = new CPoint(1, 2);

            // C++ ó�� delete ���� �ʾƵ� ��.
        } // p1 �� �ı�
          // => ���� p1�� ����Ű�� ���� ������ �������� ����Դϴ�
          // => ���� �����ϰ�, ���� �ٻ����� ���ٸ� �޸𸮰� �����˴ϴ�.

        //----------------------------------------------------------


        // �Ʒ� 6�� ����� �޸� ���¸� ������ ���ô�.
        CPoint cp1 = new CPoint(1, 1);
        object co = cp1;
        CPoint cp2 = (CPoint)co;


        // object �� class �Դϴ�.(reference type)
        SPoint sp1 = new SPoint(1, 1);
        object so = sp1;
        SPoint sp2 = (SPoint)so;

        cp1.X = 10;
        sp1.X = 10;

        WriteLine($"{cp2.X}");
        WriteLine($"{sp2.X}");

    }
}
// 140page �׸��� �ݵ�� �����ϼ���





