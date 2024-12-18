class List<T> where T : struct    // T는 value type을 받아야 한다.
{
}

class Program
{
    public static void Main()
    {
        List<int> c1 = new List<int>();     // ok
        List<string> c2 = new List<string>();   // error

        Nullable<int> n = null;
    }
}









/*
class C1<T> where T : struct           {}  // value
class C2<T> where T : class            {}  // reference
class C3<T> where T : class?           {}  // null 가능
class C4<T> where T : notnull          {}  // null 불가능 타입
class C5<T> where T : unmanaged        {}
class C6<T> where T : new()    		  {}   // 디폴트 생성자
// class C7<T> where T : base_class_name  {}
// class C8<T> where T : base_class_name? {}
// class C9<T> where T : interface_name   {}
// class C10<T> where T : interface_name?  {}


class C11<T> where T : class, IComparable<T>
{ 
}

class C12<T, U> where T : struct  
			    where U : class
{ 
}
*/