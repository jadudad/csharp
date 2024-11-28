using static System.Console;

// delegate 활용 #1.
// => 메소드의 인자로 메소드(정책을 담은)를 받고 싶을때 널리 사용

// Predicate(조건자)
// => bool을 반환하는 함수(메소드)로서
// => Findxxx등의 메소드에 정책 함수로서 사용되는 것을 나타내는 용어
// => C# 외의 대부분의 언어에도 사용하는 용어

delegate bool MyPredicate(int a);

// delegate bool MyFunc(int a);  // 메소드 모양 복사해놓고, delegate 쓰고, 원하는 타입 이름


class Program
{
    // Array.FindIndex를 직접 만들어 봅시다.
    public static int MyFindIndex(int[] arr, MyPredicate match)
    {
        // 여기서 match는 사용자가 전달한 메소드(호출정보)를 담는 객체
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