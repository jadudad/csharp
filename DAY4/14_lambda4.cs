using System;

// int Square(int n) { return n * n; }

// ���� ǥ������ ��Ȯ�� ���
// #1. �޼ҵ� ��翡�� ����Ÿ�԰� �޼ҵ� �̸� ����
// #2. �Ķ���� ����Ʈ�� () �� {} ���̿� => 
// #3. ��ȯ Ÿ���� �����Ϸ��� return ���� ������ �߷�
Func<int, int> f1 = (int n) => { return n * n; };


Func<int, int> f2 = (int n) => n * n; // expression bodied ���


Func<int, int> f3 = (n) => n * n;   // �º��� ���� Ÿ���� �����Ƿ� 
                                    // (int n) ���� int ��������

var f4 = (int n) => n * n; // �̰��� int ��������


Func<int, int> f5 = n => n * n;     // ���ڰ� �Ѱ���� ()�� ��������
                                    // ���� ������ ǥ���,
                                    // ���̻� ���ϼ� ����.

// var f6 = (bool b) => b ? 1 : "one"; // error. 
                                    // ��Ȳ�� ���� �ٸ� Ÿ�� ��ȯ
                                    // �ذ�å�� �Ʒ�ó�� ��ȯŸ�� ǥ��

var f7 = object (bool b) => b ? 1 : "one"; // ��ȯ Ÿ�� ǥ���ϴ¹�
                                           // ��ȯŸ��(����) => ����
