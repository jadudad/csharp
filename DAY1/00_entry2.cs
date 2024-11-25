// Top Level Programming
// => C# 9.0부터 지원
// => Main 메소드없이.. 소스의 첫번째 문장부터 실행
// => Python과 유사
// => 원리는 교재 6page (기본적인 틀은 내가 만들어줄게)

//class Car { } // error.
              // top level 방식에서 class는 반드시 소스 마지막 부분에서만 가능.

System.Console.WriteLine("hello, C#");

class Car { } // 에러 안난다. 아주 간단한 테스트 할때만 top level을 써라. (tip)

// 위 소스 빌드해서 DAY.dll 생성하게 하고, ILDASM에서 DAY1.dll 열어보세요.
// 주의
// C#은 함수 오버로딩을 지원하지만, top level 방식은 에러
// => 아래 2개 함수는 Main 메소드 안에 있는 local 함수가 됩니다.
// => local function은 overloading 안됩니다.
//int square(int a) { return a*a; }
//double square(double a) { return a*a; }