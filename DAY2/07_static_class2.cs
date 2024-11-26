﻿using System;

// 날짜 개념 : 상태(데이터, 필드) + 동작(메소드, 함수)이 있습니다
//            => 클래스로 설계

// 사인값 구하기, 제곱 구하기 :
//                           => 데이터가 필요 없습니다.
//                           => 클래스가 아닌 일반 함수로 해도 충분합니다.
//                           => C#, Java는 일반함수를 만들 수 없습니다.
//                           => 오직 클래스만 가능

// C#에 아래와 같은 클래스가 이미 있습니다.
/*
static class Math
{
    public static int Square(int x) => x * x;
    public static int Add(int a, int b) => a + b;
}
*/


class Program
{
    public static void Main()
    {
        double ret = Math.Sqrt(2);

        // 대표적인 static class 가 Math, Console 입니다.

        Math m = new Math(); // error
        Console c = new Console(); // error

        // Console 클래스의 모든 메소드는 static입니다.
        // => 그래서 "Console.메소드이름"으로 사용한 것!!
        Console.WriteLine();

    }
}

// C++/Rust/Python
// => 일반 함수(멤버가 아닌)도 가능하고
// => 클래스도 가능

// C#/Java
// => 일반 함수를 만들 수 없다.
// => 모든 것은 클래스의 멤버 함수(메소드) 이어야 한다.
// => 단, 멤버 함수(메소드) 안에 함수를 만드는 local function 지원


