using static System.Console;

delegate void MyFunc(int arg);

class Program
{
    public static void SMethod(int arg) => WriteLine("SMethod");
    public void IMethod(int arg) => WriteLine("IMethod");

    public static void Main()
    {
        // �ڽ��� static method ȣ��
        Program.SMethod(1); // Ŭ�����̸�.�޼ҵ��̸�() �� ��Ģ
        SMethod(1);         // ������ �ڽŰ� ���� Ŭ���� ����̹Ƿ�
                            // Ŭ���� �̸� ��������.

        // delegate �� �ٸ� Ŭ���� �޼ҵ尡 �ƴ�  �ڽ��� �޼ҵ� ����ϱ�
        // #1. �ڽ��� static method
        MyFunc f1 = Program.SMethod; // ��Ȯ�� ǥ���
        MyFunc f2 = SMethod;         // �ڽ��� ��� �̹Ƿ� Ŭ�����̸� ��������

        // #2. �ڽ��� instance method
        // => ����� Main �޼ҵ� ������ �ڵ��ε�, 
        // => Main �޼ҵ�� static Method �̹Ƿ�
        // => ��ü�� ���� ȣ��Ǿ������̹Ƿ�... �Ʒ� �ڵ尡 ����

        //      MyFunc f3 = IMethod;    // error. Program ��ü�� �������� ����

        Program pg = new Program();
        MyFunc f3 = pg.IMethod; // ok 

        pg.InstanceMethod();
    }

    public void InstanceMethod()
    {
        MyFunc f4 = IMethod;      // ok. �� ǥ���� �Ʒ��� ����
        MyFunc f5 = this.IMethod; // this : �ڽ��� ����Ű�� Ű����

        // static method �� �Ʒ� ó�� ����
        MyFunc f6 = Program.SMethod;
        MyFunc f7 = SMethod

    }
}
// ��� �ڽ��� �޼ҵ带 delegate �� ����Ҷ�
// static Method �ȿ��� �۾��Ҷ� (��ü�� ���� ����)
// => ��ü�� �����߸� �ν��Ͻ� �޼ҵ� ��ϰ���

// instance Method �ȿ��� �۾��Ҷ� (��ü�� �̹� �ִ� ����)
// => �ν��Ͻ� �޼ҵ� �ٷ� ��ϰ���