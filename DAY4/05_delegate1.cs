using System;
using static System.Console;

// delegate ( 156 ~ )
// �ٽ� #1. delegate ����� �� ��Ȯ�� �˾� �μ���
// => 1. �޼ҵ� ���� ����� �����
// => 2. ��ȯŸ�� �տ� "delegate" �߰�
// => 3. �޼ҵ� �̸��� ���ϴ� Ÿ������ ����

delegate void MyFunc(int arg);


class Program
{
	public static void Main()
	{
		// ? ��ġ�� �� Ÿ���� ������ ������
		? n = 10;
		? d = 3.4;
		? s = "abc";

		? f = Foo;  // ? �� �޼ҵ带 ��� Ÿ��
					// ��Ȯ���� "�޼ҵ��� ȣ�� ����"�� ��� Ÿ��
	}

	public static void Foo(int arg) 
		=> WriteLine($"Foo : {arg}");
}
