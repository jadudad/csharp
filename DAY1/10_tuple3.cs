using static System.Console;

// #1. construction
int a = 1, b = 2, c = 3;

// => �Ʒ� �ڵ�� int ���� 3���� tuple �� �����(����!)
// => t1�� tuple
var t1 = (a, b, c);



// #2. deconstruction
int x, y, z;

// => �Ʒ� �ڵ�� t1�̶�� tuple �� ���� ����, x, y, z �� ������
x = t1.Item1;
y = t1.Item2;
z = t1.Item3;

// �� �ڵ�� �Ʒ� ó�� �Ҽ� �ֽ��ϴ�.(deconstruction)
(x, y, z) = t1; // �� �ڵ�� ���� ����(x, y, z) �� ����Ѱ�

(int a, int b, int c) = t1; // ����� deconstruction�� �ѹ���


WriteLine($"{x} {y} {z}"); // 1, 2, 3


// #3. �Ʒ� 2���� �������� ��Ȯ�� �˾� �μ��� - 49 page �Ʒ� �κ�
(int a1, int a2, int a3) t2 = (1, 2, 3); // t2��� Ʃ�� ����, a1, a2, a3��
                                         // �� ����� �̸�.

(int b1, int b2, int b3) = (4, 5, 6); // ���� �ִ� t2��� �̸��� �����ϴ�.
                                      // tuple destruction�Դϴ�.
                                      // int b1 = 4
                                      // int b2 = 5
                                      // int b3 = 6


int a1 = 0; // ok
//int b1 = 0; // error. �� 33��° �ٿ��� �̹� ����� �̸�.

WriteLine($"{t2.a1} {t2.a2} {t2.a3}");
WriteLine($"{b1} {b2} {b3}");

// CLR via C# : �ְ��� C# �������� �˷��� å. 2000��� �ʹ� ����


// ���ɾ��� ����� _�� ǥ��
var tp2 = (1, 2, 3);

(int b1, _, int b3) = tp2;

/*
// ����: C++
int arr[3] = { 1, 2, 3 };

auto[a, b, c] = arr; // C++17 ���� ����
auto[a, _, c] = arr; // C++26 ���� _�� ����.
                     // C++17 ������ ���� �ƴ�����
                    // _�� ���� �̸��� ��
auto[a, _, c] = arr; // ���� �ѹ� �� ����ϸ� ����!!
                     // �̹� ����� ����
                    // C++26, �����̸��� _ ���
                    // ������ ����ɼ� �ִٴ� ���� ����
*/