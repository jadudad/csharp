using static System.Console;
// 중요!!! ***
// 79 page
class Program
{
	// 아래 메소드는 복사본 x를 생성합니다.
	// => call by value (C와 동일)
	// => 79 page 위 그림
	public static void Inc1(int x)
	{
		++x; // 복사본 증가 (79 page 위 그림)
    }

	// ref modifier
	// => 복사본이 아닌 참조로 받아달라는 의미
    public static void Inc2(ref int x)
    {
        ++x; // 복사본 아닌 원본 증가 (79 page 아래 그림)
    }

    public static void Main()
	{
		int n = 0;
		Inc1(n);
		WriteLine(n); // 0

		Inc2(ref n); // 참조로 전달해달라.
		WriteLine(n); // 1

		// C# 1.0 ~ 에서는 ref는 메소드 인자만 가능했습니다.
		// C# 7.0 부터 자역변수로도 ref 사용 가능합니다.

		ref int r = ref n; // ref local이라는 문법
		                   // C++ : int & r = n
		r = 20;

		WriteLine(n); // 20

	}
}