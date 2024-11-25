// 31 page
// 모든 것은 객체이다. - C# 언어의 핵심!!!
// "everything is object"
// C#의 모든건 구조체 or 클래스

// C/C++/Java의 int는 => 언어 자체가 제공하는 타입 (키워드)
// C#의 int는 => struct 문법으로 만들어진 Int32라는 타입의 별명
// => 따라서 int형 변수도 "메소드(멤버 함수)"가 있다.

using System;

int n1 = 10;

string s1 = n1.ToString();
string s2 = 10.ToString();

int n2 = int.Parse(s2);


// C#의 모든 타입은
// => struct 또는 class 문법으로 만들어진 것!!
// => 따라서 모든 변수(객체)는 메소드가 있다.

// 용어
// n1.ToString(); // C++은 멤버함수, Java, C#은 메소드라고 한다.