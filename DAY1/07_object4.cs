using static System.Console;

string s = "abcd";

// �޼ҵ� (��� �Լ�) : ��ü(����)�̸�.�޼ҵ��̸�()
// �Ӽ�(Property) : ��ü�̸�.�Ӽ��̸� ���� ���. ()����.
//                  ��� ������ �ƴմϴ�. (3������ property�������� �ڼ��� ����) =

bool b = s.Contains('b');
int  n = s.Length;       

WriteLine($"{b} {n}");

//���г� : property / ť�� : method / ť��+ȭ��ǥ : Ȯ�� method