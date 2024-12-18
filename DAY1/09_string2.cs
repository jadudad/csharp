using System;
using static System.Console;


// 1. C#의 모든 변수(객체)는 new로 만드는 것이 원칙입니다.
// 2. 단, 표준 타입에 한해서 단축 표기법을 제공합니다.
//    표준 타입이 아닌 경우 반드시 "new" 사용해야 합니다.

// int, double은 아래 2줄이 완전히 동일합니다.
int n1 = new int();
int n2 = 0;

// 하지만 string은 다릅니다. (다음 소스 참고)
string s1 = new string("ABCD");
string s2 = "ABCD";
