delegate void MyFunc(int arg);

class Program
{
    public static void M1(int arg) { }

    public static void Main()
    {
        MyFunc f = M1;

        // f �� ����ؼ� �޼ҵ带 ȣ���Ҷ� �Ʒ��� 2���� ����� �����մϴ�.
        f(10);          // #1. () ������
        f.Invoke(10);   // #2. Invoke() �޼ҵ�

        // delegate �� reference type(class) �̹Ƿ� null �ɼ� �ֽ��ϴ�.
        f = null;

        //      f(10); // runtime error

        if (f != null)  // �� �ڵ尡 ������ �ڵ�
            f(10);

        // �� 2���� �����ϰ� �ϴ� �����ڴ� ?
        f ? (10);        // error ������
        f?.Invoke(10); // �� ǥ����� ������ �ƴϴ�.
                       // �׷���, Invoke() �� ����ϴ� ��찡 �����ϴ�.

        f?.Invoke(10); // f �� null �̸� �ƹ��ϵ� ����
                       //      null �� �ƴϸ� ��ϵ� �޼ҵ� ȣ��	
    }
}