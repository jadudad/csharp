// init, required
class Example2
{
    private int data1 = 0;
    private int data2 = 0;

    public int Data1
    {
        get => data1;
        set => data1 = value;
    }

    // set ��� init property( C# 9.0)
    // => ��ü�� ���鶧�� ��밡��
    // => new Example{ ����ġ}
    // => �����ھ�.. 
    public int Data2
    {
        get => data2;
        //		set => data2 = value;
        init => data2 = value;
    }

    public Example2()
    {
        Data1 = 0;  // ok
        Data2 = 0;	// ok
    }
}

class Program
{
    public static void Main()
    {
        // property �� set �ϱ�

        // #1. ��ü�� ���鶧 set
        //      Example2 e1 = new Example2(1, 2); // ������ ���ڷ� ����
        Example2 e1 = new Example2 { Data1 = 1, Data2 = 2 };

        // #2. ��ü �����Ŀ� �ʵ� ó�� ����
        e1.Data1 = 0;   // ok
        e1.Data2 = 0;	// ok
    }
}