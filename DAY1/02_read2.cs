using System;

Console.Write("input yout age >> ");

// ���� �Է�
// 1. ���� ���ڿ��� �Է� �ް�
// 2. ���ڿ��� => ����(�Ǽ�)�� ��ȯ�ؼ� ���.

string s = Console.ReadLine(); // "10"

// �Էµ� ���ڿ��� ������ �����ϴ� 2���� ���
int n1 = Convert.ToInt32(s);
int n2 = int.Parse(s); // �� ��� ����
                       // s = "hello" ������ ���� ������ �ȵǸ� -> ��Ÿ�� ����(���� �߻�)

Console.WriteLine($"{n1}, {n2}");


int n3 = 0;

// ��ȯ ���н�, ���� ��� ��ȯ������.. return������ �����ߴٰ� ����. 
bool b = int.TryParse(s, out n3); 
Console.WriteLine($"{b}, {n3}");



