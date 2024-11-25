using System;
using static System.Console;

// mutable, immutable, string

// mutable : ��ü�� ���¸� ������ �� �ִ� ��
// immutable : ��ü�� ���¸� ������ �� ���� ��

// int�� mutable Ÿ���Դϴ�.
int n = 0;
n = 10; // ok. ���氡��.

// string�� immutable Ÿ���Դϴ�.
string s1 = "AB";

char c = s1[0]; // ok : �д� �� ����
//s1[0] = 'X';    // error : ������ �ϸ� ���� (immutable) 

// �Ʒ� �ڵ尡 �߿��մϴ�.
string s2 = "A";
       //new string("AB")
s2 = "XY"; // ��?? ������ �� �ƴѰ���?
           //s2 = new string("XY"); // �� ������ �� �ǹ��Դϴ�.


// ���� �Ʒ� �ڵ��� ����� ��Ȯ�� ������ ���ô�.
// 42 page �׸�.
string s3 = "AB";
string s4 = s3;

WriteLine($"{object.ReferenceEquals(s3,s4)}");

s4 = "XY";
       // new string("XY") ��, ���ο� ��ü�� ���� ��
WriteLine($"{s3} {s4}");
WriteLine($"{object.ReferenceEquals(s3, s4)}");





