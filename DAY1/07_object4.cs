using static System.Console;

string s = "abcd";

// 메소드 (멤버 함수) : 객체(변수)이름.메소드이름()
// 속성(Property) : 객체이름.속성이름 으로 사용. ()없음.
//                  멤버 데이터 아닙니다. (3일차에 property문법에서 자세히 설명) =

bool b = s.Contains('b');
int  n = s.Length;       

WriteLine($"{b} {n}");

//스패너 : property / 큐브 : method / 큐브+화살표 : 확장 method