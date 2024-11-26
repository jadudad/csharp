class Example
{
    private int data1 = 0;
    private int data2 = 0; // �ʵ带 ��������� ����

    // set only, get only ��� ����
    // => ���� ��ҵ忡���� �ʵ������ ���ٰ����ϹǷ�(R/W����)
    public int Data1 { set => data1 = value; }	// set_Data1(value)
    public int Data2 { get => data2; }          // get_Data2()


    // auto implmented �� ���� ����ڰ� ���� �ʵ�� ���� �����Ϸ��� ����
    // => ����ڴ� �ʵ���� �˼� ����. 
    ///	public int Data3 { set; } = 0; // error. set_Data3(3) ó�� �����
    // ����� ����Ÿ�� ������(Read)����� ����.
    // �޼ҵ� �ȿ�����!! �ʵ��̸� ��. 

    public int Data4 { get; } = 0;  // ok. �����⸸ �����ϰ� ����ȵ�.
                                    // ��, �����ڿ����� set ����


    public Example(int a, int b)
    {
        Data4 = a; // get only ���� �����ڿ����� �� �ڵ尡 ����.
    }
}

class Program
{
    public static void Main()
    {
        Example e1 = new Example(1, 1);

        e.Data2 = 10;   // error
        e.Data4 = 10;	// error. 

    }
}