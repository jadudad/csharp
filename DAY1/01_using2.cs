// 프로젝트 내의 다른 파일에서도 사용 가능한 using
// 다른 파일에서도 아래 using이 동일하게 적용 (C# 10.0)
// => 12 page

global using System;
global using static System.Console;

//using System이 없지만 아래 코드가 에러가 발생하지 않습니다.

Write("Hello, ");
WriteLine("C#");