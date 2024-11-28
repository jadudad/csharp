using static System.Console;




class Program
{

    // �ᱹ "MyFindIndex" �� ���ڷ� bool(T) ������ �޼ҵ带 �ް� �˴ϴ�.
    // => Func<T, bool> �� �ص� �ƹ� ���� ������, 
    // => Predicate<T> �� �� �������� �����ϴ�.

    // �׷���, Action, Func �� ��� �޼ҵ忡 ���� delegate�� 
    // ���������..
    // �ǹ̰� �ִ� ������ ��쿡�� ������ ������� delegate �� ����
    // => Predicate<T>, Comparision<T>
    // => Ixx : ��� �������̽�
    // => delegate�� I�� �����ϴ�.


    //    public static int MyFindIndex<T>(T[] arr, Func<T, bool> match) // �̷��� �ص� �˴ϴ�.
    // �ƹ� ���� �����ϴ�.
    public static int MyFindIndex<T>(T[] arr, Predicate<T> match)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (match(arr[i]) == true)
                return i;
        }

        return -1;
    }



    public static void Main()
    {
        double[] x = { 1, 8, 6, 4, 3 };

        int ret1 = Array.FindIndex(x, Foo);

        int ret2 = MyFindIndex(x, Foo);

        WriteLine($"{ret2}"); // 2
    }

    public static bool Foo(double a)
    {
        return a % 3 == 0;
    }

}