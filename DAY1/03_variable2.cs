using static System.Console;

// 변수 초기화 - 23 page
// 초기화되지 않은 변수는 쓰기만 가능.

int n;
int a = 0;

a = n;			// error : 초기화되지 않은 변수 n을 Read하므로
WriteLine(n);	// error : 초기화되지 않은 변수 n을 출력하므로

n = a;	// ok : 초기화 되지 않은 변수도 쓰기는 가능.
a = n;  // ok