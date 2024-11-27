using static System.Console;

// 120 page ~ 

// ToString()
// => object가 제공하는 메소드이므로 대부분의 타입이 가지고 있다.
// => 객체의 상태를 문자열로 얻고 싶을때 사용
// => object 클래스의 기본 구현은 "타입이름" 반환

// 핵심 : virtual method이므로
//        파생 클래스 설계자가 override해서
//        객체의 상태를 문자열로 반환할 수 있도록 만들면 된다!

class Point 
{
	private int x = 0;
	private int y = 0;

	public Point(int a, int b) => (x, y) = (a, b);

    public override string ToString()
    {
//      return base.ToString();
        return $"{x}, {y}";
    }
}

class Program 
{
	public static void Main()
	{
		Point p = new Point(1, 2);
		
		string? s = p.ToString();

		WriteLine( s );

		WriteLine(p);  // 이 순간 p.ToString()의 결과를 화면 출력

		int[] x = { 1, 2, 3 };
		List<int> y = new List<int>();

		WriteLine(x);  // 요소가 나오면 좋을거 같지만. 타입의 이름 출력
		WriteLine(y);  // 즉, object의 기본 구현 출력

	}
}
