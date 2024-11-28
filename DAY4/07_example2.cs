using static System.Console;

// delegate Ȱ�� #1.
// => �޼ҵ��� ���ڷ� �޼ҵ�(��å�� ����)�� �ް� ������ �θ� ���

// Predicate(������)
// => bool�� ��ȯ�ϴ� �Լ�(�޼ҵ�)�μ�
// => Findxxx���� �޼ҵ忡 ��å �Լ��μ� ���Ǵ� ���� ��Ÿ���� ���
// => C# ���� ��κ��� ���� ����ϴ� ���

delegate bool MyPredicate(int a);

// delegate bool MyFunc(int a);  // �޼ҵ� ��� �����س���, delegate ����, ���ϴ� Ÿ�� �̸�


class Program
{
    // Array.FindIndex�� ���� ����� ���ô�.
    public static int MyFindIndex(int[] arr, MyPredicate match)
    {
        // ���⼭ match�� ����ڰ� ������ �޼ҵ�(ȣ������)�� ��� ��ü
        for ( int i = 0; i < arr.Length; i++)
        {
            if (match(arr[i]) == true)
                return i;
        }
        return -1;

    }


    public static void Main()
    {
        int[] x = { 1, 8, 6, 4, 3 };
   
        int ret1 = Array.FindIndex(x, Foo);

        int ret2 = MyFindIndex(x, Foo);

        WriteLine($"{ret2}"); // 2
    }



    public static bool Foo(int a)
    {
        return a % 3 == 0;
    }

}