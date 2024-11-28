using System;
using static System.Console;

// delegate ( 156 ~ )
// 핵심 #1. delegate 만드는 법 정확히 알아 두세요
// => 1. 메소드 선언 모양을 만들고
// => 2. 반환타입 앞에 "delegate" 추가
// => 3. 메소드 이름을 원하는 타입으로 변경

delegate void MyFunc(int arg);


class Program
{
	public static void Main()
	{
		// ? 위치에 들어갈 타입을 생각해 보세요
		? n = 10;
		? d = 3.4;
		? s = "abc";

		? f = Foo;  // ? 는 메소드를 담는 타입
					// 정확히는 "메소드의 호출 정보"를 담는 타입
	}

	public static void Foo(int arg) 
		=> WriteLine($"Foo : {arg}");
}
