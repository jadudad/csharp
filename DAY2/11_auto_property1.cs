using System.Security.Cryptography;

class Example
{
    // #1. �Ϲ����� property
    // => �ʵ带 ���� �����
    // => get/set �� ���� ���� ���
    private int data1 = 0;

    public int Data1
    {
        set => data1 = value;
        get => data1;
    }

    // �Ʒ� ������ �� �ڵ�� ������ �����մϴ�.
    // => auto implemented property
    // => �����Ϸ��� �ڵ����� �ʵ� ���� ����
    // => set/get ������ ���� ����
    public int Data2 { get; set; } = 0;
}



class Program
{
    public static void Main()
    {
        Example e = new Example();
        e.Data1 = 10;

    }
}

// ���� ��ȿ���� üũ���� �ʴ´ٸ� ????

// public field �� �ϸ� �Ǵµ�.. ��??? auto-implemnted property �� ����ϳ���

//p.data2 = 10; // public �ʵ��
// p.Data2 = 10; // property

// �̷��� ���� ��ȿ�� �ڵ带 �߰��ߴٰ� �ϸ�
// => property �� ���, property �� �����ϸ� �˴ϴ�.
//    ����ϴ� �ڵ尡 ����� �ʿ� �����ϴ�.

// => public field ���ٸ� ����ϴ� �ڵ尡 ��� �����Ǿ�� �մϴ�.
