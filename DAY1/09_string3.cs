using System;
using static System.Console;

// 43 page �̾߱�
// �Ʒ� �ڵ�� �׻� ���ο� string ��ü ����
string s1 = new string("AAA");
string s2 = new string("AAA");

// �Ʒ� �ڵ�� string intern pool��
// string ��ü�� �����, s3, s4�� ����. ���� ǥ������� ���!!!
string s3 = "BBB";
string s4 = "BBB";

WriteLine($"{object.ReferenceEquals(s1, s2)}"); // False
WriteLine($"{object.ReferenceEquals(s3, s4)}"); // True

// ���
// string�� �ǵ��� ���� ǥ���(����ǥ���)�� ����ϼ���!!