﻿// named argument - 74 page

class Program
{
    public static void SetRect(int x,     int y, 
							   int width, int height) {}

    public static void Main()
    {
		// positional arguments : argument를 순서대로 맞춰서 매칭
        // => 호출하는 코드만 보고는 인자의 의미를 파악하기 어려울 때가 있습니다.
        // => 아래 코드에서 3번재 인자는 width일까요? x2일까요?
        SetRect(10, 10, 30, 30);

        // #1. 인자에 이름을 사용하면 어떨까요?
        // => named argument라고 합니다.
        // => Objective-C는 이 방식만 지원.
        SetRect(x: 10, y: 10, width: 30, height: 30);

        // #2. 섞어서 사용해도 됩니다.
        SetRect(10, 10, width: 30, height: 30);
        SetRect(x: 10, 10, width: 30, 30);

        // #3. named argument 사용시, 순서 변경도 가능합니다.
        SetRect(y: 10, x: 10, height: 30, width: 30);

        // #4. 주의: 순서를 변경한 경우, named 뒤에 positional이 올 수 없습니다.
        SetRect(x: 10, y: 10, 30, 30); // ok. 순서 변경 안됨
        SetRect(y: 10, x: 10, 30, 30); // error. 순서 변경 안됨


    }
}
