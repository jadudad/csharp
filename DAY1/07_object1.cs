// 31 page
// ��� ���� ��ü�̴�. - C# ����� �ٽ�!!!
// "everything is object"
// C#�� ���� ����ü or Ŭ����

// C/C++/Java�� int�� => ��� ��ü�� �����ϴ� Ÿ�� (Ű����)
// C#�� int�� => struct �������� ������� Int32��� Ÿ���� ����
// => ���� int�� ������ "�޼ҵ�(��� �Լ�)"�� �ִ�.

using System;

int n1 = 10;

string s1 = n1.ToString();
string s2 = 10.ToString();

int n2 = int.Parse(s2);


// C#�� ��� Ÿ����
// => struct �Ǵ� class �������� ������� ��!!
// => ���� ��� ����(��ü)�� �޼ҵ尡 �ִ�.

// ���
// n1.ToString(); // C++�� ����Լ�, Java, C#�� �޼ҵ��� �Ѵ�.