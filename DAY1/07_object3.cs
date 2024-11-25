// 모든것은 object 로 가르킬수 있다.
int    n = 0;
double d = 0;
string s = "A";

object o1 = n;   // 복사하는게 아니고 이걸 가리키는 것. (C언어 포인터 개념)
object o2 = d;
object o3 = s;

// object의 실제 이름은 System.Object
System.Object o4 = n;
System.Object o5 = d;
System.Object o6 = s;