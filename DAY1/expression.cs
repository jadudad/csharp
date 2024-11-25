// expression.cs

// statement(문장): 세미콜론(;) 으로 끝나는 한줄의 코드. 실행단위
// expression(표현식) : 하나의 값을 만드는 코드 집합
//              하나의 값을 만들기 때문에 변수 초기값으로 사용가능

int n = 10;

n * 2 + 3; // n도 표현식, n*2도 표현식, n*2+3도 표현식.

int n2 = n * 2 + 3;

// 요즘 언어들에서 유행하는 개념
// RUST: if, switch도 표현식이다.
// C#  : switch도 표현식이다. (if는 안됨)

// C/C++ 은 if, switch는 statement이고 expression이 아님

