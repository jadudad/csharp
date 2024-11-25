using System.Data;
using static System.Console;

// C#�� ��� Ÿ���� �Ʒ� 2���� �Ѱ��Դϴ�. (39page ǥ)
// 1. Value Type
// 2. Reference Type

// �Ʒ� �ڵ带 ����
// 1. �޸� �׸��� �׸� �� �־�� �ϰ�
// 2. ��� ����� ������ �� �־�� �մϴ�.


// #1. int: value type (stack�� n1, n2�� ������ ����)
int n1 = 10;
int n2 = n1;

n1 = 20;
WriteLine($"{n1} {n2}");	// 20  10	

// #2. �迭�� reference type
// ����: swift�� �迭�� value type�Դϴ�.
int[] x1 = {1, 2, 3};
int[] x2 = x1;

x1[0] = 20;
WriteLine($"{x1[0]} {x2[0]}");	// 20 20

// #3. string�� class�� ����. ��, reference type�Դϴ�. reference type
string s1 = "AB";
string s2 = s1;

s1 = "XY";
WriteLine($"{s1} {s2}");  // "XY", "AB"
                          // => ��? �׷� value type �ƴѰ���?
                          // => ���� �ҽ����� ���� (�� ������ ���� 2���� �˾� �μ���.
                          // 40 page �׸� ����


// �Ʒ� Ÿ���� value ? refence �� � Ÿ���ϱ��?
DateTime dt1 = DateTime.Now; // struct => value type