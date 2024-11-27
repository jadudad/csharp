// 참고.cs

void f1(int n) { }
void f2(int? n) { }

f1(10);    // ok
f1(null);  // error

f2(10);    // ok
f2(null);  // error

//------------------------------
int n1 = 10;
int n2 = 10;

f1(n1);
f1(n2); // error

f2(n1); // ok
f2(n2); // ok

// 모든 정수형 변수를 인자로 받고 싶다!!
// => int와 int? 중 어떤 것이 좋을까요?

// f(int) : int만 가능 int? 안됨
// f(int?) : int, int? 모두 가능

// string같은 참조 타입은 string?를 C# 9.0부터 지원

// C# 9.0까지 대부분 메소드는
// int CompareTo(object) 형태 있지만 C# 9.0부터
// int CompareTo(object?) 형태로 변경. 많이 헷갈려하는 부분


