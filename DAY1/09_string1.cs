using System;
using static System.Console;

// mutable, immutable, string

// mutable : 객체의 상태를 변경할 수 있는 것
// immutable : 객체의 상태를 변경할 수 없는 것

// int는 mutable 타입입니다.
int n = 0;
n = 10; // ok. 변경가능.

// string은 immutable 타입입니다.
string s1 = "AB";

char c = s1[0]; // ok : 읽는 건 가능
//s1[0] = 'X';    // error : 쓰려고 하면 에러 (immutable) 

// 아래 코드가 중요합니다.
string s2 = "A";
       //new string("AB")
s2 = "XY"; // 어?? 변경한 거 아닌가요?
           //s2 = new string("XY"); // 위 한줄은 이 의미입니다.


// 이제 아래 코드의 결과를 정확히 이해해 봅시다.
// 42 page 그림.
string s3 = "AB";
string s4 = s3;

WriteLine($"{object.ReferenceEquals(s3,s4)}");

s4 = "XY";
       // new string("XY") 즉, 새로운 객체를 만든 것
WriteLine($"{s3} {s4}");
WriteLine($"{object.ReferenceEquals(s3, s4)}");





