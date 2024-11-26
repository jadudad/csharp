class Example1
{
    private int data1 = 0;
    private int data2 = 0;
    private int data3 = 0;
    private int data4 = 0;
    private int data5 = 0;

    // ���������� ���� ����

    // 1. get/set �Ϲ����� ����
    public int Data1
    {
        get { return data1; }
        set { data1 = value; }
    }

    // 2. expression bodied �� ��� ������ ��. ������ ���� ������ ����
    public int Data2
    {
        get => data2;
        set => data2 = value;
    }

    // 3. get �� ��������. read only
    public int Data3
    {
        get => data3;   // get_Data() �� ����. �б⸸ ����. 	
    }

    // 4. set �� ����, write only
    //    Ŭ���� �ȿ��� ���������θ� ���(�޼ҵ� �ȿ���)�ϰڴٴ� ��
    public int Data4
    {
        set => data4 = value;
    }

    // 5. private set 
    public int Data5
    {
        get => data5;
        private set => data5 = value;
    }

    public Example1()
    {
        data5 = 10; // �ʵ� ���� ����
        Data5 = 10; // set_Data5(5) �� ���� �Ѱ�
                    // set_Data5() �ȿ� ���� ��ȿ�� Ȯ���� �ִٸ�
                    // => �ش� ������ �����Ѱ�
    }
}

class Program
{
    public static void Main()
    {
        //      Example1 e1 = new Example1(); // ��Ȯ �� ǥ���
        Example1 e1 = new(); //  Ÿ�� �߷�

        e1.Data5 = 10;	// error. private set
    }
}