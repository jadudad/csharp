using static System.Console;

// null conditional operator ( ?, ?[]) - 62 page

string s1 = "hello";
string s2 = null;

var ret1 = s1.ToString(); // ok. ��ü�� ����.
var ret2 = s2.ToString(); // ��Ÿ�ӿ���(���� �߻�)

if (ret2 != null)
{
    var ret2 = s2.ToString();
}
// �� �ڵ带 �Ʒ� ó���ص� �˴ϴ�.
var ret3 = s2?.ToString(); // s2 != null ? s2.ToString() : null;

// 
int[] arr = null;
int n = arr[0]; // �迭�� ���� �����Ƿ� ���� �߻�

var n2 = arr?[0]; // arr != null ? arr[0] : null

// n2 �� ����Ÿ Ÿ���� ������ ������
// => int�� �ƴ� int? Ÿ���̾�� �մϴ�.