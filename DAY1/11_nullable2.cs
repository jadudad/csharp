using static System.Console;

// 58 page

// int : ���� �Ѱ� ����
// int? : ���� �Ѱ� ����(value) + bool ����(hasValue)

int  n = 0;

// int? <= int : �׻� ����
int? n1 = n; // n1.value = n
             // n1.hasValue = True;

// int <= int?
//int n2 = n1; // error. n1�� null(���� ����) ������ �� ����.

int n2 = (int)n1; // ok. (ĳ�����ϸ� ����)
                  // ��, n1 == null �̸� ��Ÿ�Կ��� (���� �߻�)

int n3 = n1.Value; // ok.
                   // ��, n1 == null �̸� ��Ÿ�Կ��� (���� �߻�)

//if (n1 != null)
if ( n1.HasValue ) // ���� ���� �ǹ�
{
    int n4 = n1.Value; // �׻� ����
}

int n5 = n1.GetValueOrDefault(); // null�̸� ����Ʈ��(0) ��ȯ
int n6 = n1.GetValueOrDefault(3); // null�̸� 3 ��ȯ

int n7 = default; // n5�� �̷� ��� (��, int�� ����Ʈ�� 0)

System.Console.WriteLine(n5);
System.Console.WriteLine(n6);


