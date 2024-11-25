using System.Data;
using static System.Console;

// C#의 모든 타입은 아래 2개중 한개입니다. (39page 표)
// 1. Value Type
// 2. Reference Type

// 아래 코드를 보고
// 1. 메모리 그림을 그릴 수 있어야 하고
// 2. 출력 결과를 예측할 수 있어야 합니다.


// #1. int: value type (stack에 n1, n2가 별도로 있음)
int n1 = 10;
int n2 = n1;

n1 = 20;
WriteLine($"{n1} {n2}");	// 20  10	

// #2. 배열은 reference type
// 참고: swift의 배열은 value type입니다.
int[] x1 = {1, 2, 3};
int[] x2 = x1;

x1[0] = 20;
WriteLine($"{x1[0]} {x2[0]}");	// 20 20

// #3. string은 class로 설계. 즉, reference type입니다. reference type
string s1 = "AB";
string s2 = s1;

s1 = "XY";
WriteLine($"{s1} {s2}");  // "XY", "AB"
                          // => 어? 그럼 value type 아닌가요?
                          // => 다음 소스에서 설명 (이 예제는 위의 2개만 알아 두세요.
                          // 40 page 그림 참고


// 아래 타입은 value ? refence 중 어떤 타입일까요?
DateTime dt1 = DateTime.Now; // struct => value type