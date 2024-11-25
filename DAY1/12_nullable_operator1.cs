using static System.Console;

// null-coalescing operator (?? ������)


int? n1 = null;
string s1 = null;

// 
//int n2 = n1; // error
int n3 = n1.GetValueOrDefault(); // ok
int n4 = n1 ?? 0; // ���� ����

string s2 = s1; // ok. reference type �� null �� �����ϹǷ�

string s3 = s1.GetValueOrDefault("ABC"); // error
                                         // �� �޼ҵ�� Nullable<T> �� ����

string s3 = s1 ?? "ABC"; // ok (��� ����)

