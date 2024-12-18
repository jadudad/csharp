using static System.Console;

class Point 
{
	private int x = 0;
	private int y = 0;
	public Point(int a, int b) => (x, y) = (a, b);

	public override bool Equals(object? obj)
	{
		if ( obj == null || !(obj is Point) )
		 	return false;

		Point p = (Point)obj;
		
    	return x == p.x && y == p.y;
	}	
	public override int GetHashCode() 
	{
		return x.GetHashCode() + y.GetHashCode();
	}	
}

class Program
{
	public static void Main() 
	{
		Point p1 = new Point(1,2);
		Point p2 = p1;
		Point p3 = new Point(1,2);
		Point p4 = new Point(1,2);

		// #1. 객체가 동일한가?
		WriteLine($"{p1 == p2}"); // True
		WriteLine($"{p3 == p4}"); // False

		// #2. 상태가 동일한가? (override 한 경우만)
		WriteLine($"{p1.Equals(p2)}"); // True
		WriteLine($"{p3.Equals(p4)}"); // True

		// 상태가 동일한가를 조사하는 최선의 코드가 뭘까요?
		bool b = p1 == p2; // 객체가 같은지를 먼저 조사하고 (만약에 요소가 많으면 하나하나 다 비교 언제 다해)

		if (b == false)    // 다른 객체일때만 상태를 조사하자.
		{
			b = p1.Equals(p2);
		}

		//  #3. object의 static method Equals의 위 코드와 유사
		//      instance method Equals와
		//      static method Equals를 잘 구별하세요.
		WriteLine($"{object.Equals(p1, p2)}");
		WriteLine($"{object.Equals(p3, p4)}");	

		// 결론
		// "상태가 동일한가?" 조사는
		// 1. p1.Equals(p2) 보다는
		// 2. object.Equals(p1,p2)가 좀 더 효율적입니다.
		
		// 그런데, Point처럼 멤버가 많지 않으면
		// => p1.Equals(p2)도 나쁘지 않습니다.

	}
}

