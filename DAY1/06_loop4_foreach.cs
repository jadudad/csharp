using static System.Console;

int[] x = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

// python : for(e in x)
// C++ : for(int e : x)
foreach( int e in x )
{
	Write($"{e}, ");
}
WriteLine();

string s = "ABCDEFGHIJ";

// �迭�� �ƴ϶� ���ڿ�, Collection ���� ��� ���� ����.
foreach( char e in s )
{
	Write($"{e}, ");
}


int n = 0;
foreach(var e in x) // error.
{
}

// ���� ��� ���� foreach(for)�� ���� ���ִ� Ÿ����
// => iterable�� Ÿ�Ը� �����մϴ�.
// => �ݺ���(iterator, enumerator)�� ���� Ÿ��.
// => C# �ݺ��ڰ� �ִ� ��� Ÿ���� ��ü�� GetEnumerator()
//    �޼ҵ尡 �ֽ��ϴ�.

s.GetEnumerator(); // ok
//n.GetEnumerator(); // error

