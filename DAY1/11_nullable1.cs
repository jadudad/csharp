// null - 52 page ~ 


// #1. reference type의 변수는 null로 초기화될 수 있습니다.
string s1 = "hello";
string s2 = null;	// ok	나는 가리키는 곳이 없어.

// #2. value type의 변수는 null로 초기화 될 수 없습니다.
int n1 = 0;
// int n2 = null;	// error


// #3. Nullable<int>는 null이 될 수 있습니다.
// 55 page.
// 진정한 null이 아니라, bool을 통해 값이 있는지 없는지를 나타낸다.
Nullable<int> n3 = null;
//Nullable<string> n4 = null; //error.
// Generic 인자로 Value Type만 가능.

// 단축 표기법 존재
int? n4 = null; // Nullable<int> n4 = null과 완전히 동일

// 활용은 메소드 등을 만들 때, "실패"의 전달로 활용 가능
int? DoSomething()
{
    // 실패를 전달하고 싶다.
    return null;
}

// C++ : optional<T>
// Rust : Option<T>, Result<T,E> 등이 있습니다.


