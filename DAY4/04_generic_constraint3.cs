class List<T> where T : struct    // T�� value type�� �޾ƾ� �Ѵ�.
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
class C3<T> where T : class?           {}  // null ����
class C4<T> where T : notnull          {}  // null �Ұ��� Ÿ��
class C5<T> where T : unmanaged        {}
class C6<T> where T : new()    		  {}   // ����Ʈ ������
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