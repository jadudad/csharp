using static System.Console;

// 58 page

// int : 정수 한개 보관
// int? : 정수 한개 보관(value) + bool 보관(hasValue)

int  n = 0;

// int? <= int : 항상 성공
int? n1 = n; // n1.value = n
             // n1.hasValue = True;

// int <= int?
//int n2 = n1; // error. n1이 null(값이 없음) 상태일 수 있음.

int n2 = (int)n1; // ok. (캐스팅하면 가능)
                  // 단, n1 == null 이면 런타입에러 (예외 발생)

int n3 = n1.Value; // ok.
                   // 단, n1 == null 이면 런타입에러 (예외 발생)

//if (n1 != null)
if ( n1.HasValue ) // 위와 같은 의미
{
    int n4 = n1.Value; // 항상 성공
}

int n5 = n1.GetValueOrDefault(); // null이면 디폴트값(0) 반환
int n6 = n1.GetValueOrDefault(3); // null이면 3 반환

int n7 = default; // n5가 이런 방식 (즉, int의 디폴트값 0)

System.Console.WriteLine(n5);
System.Console.WriteLine(n6);


