using static System.Console;

class Program 
{
	public static void Check(string a, string b)
	{
		WriteLine($"a == b      : {a == b}");
		WriteLine($"a.Equals(b) : {a.Equals(b)}");
		WriteLine($"object.ReferenceEquals(a, b) : {object.ReferenceEquals(a, b)}");
	}
	public static void Main()
	{
		string s1 = "ABCD"; // string intern pool ���� ��ü
		string s2 = "ABCD"; // string intern pool ���� ��ü
							// s1, s2�� ������ ��ü
		string s3 = new string("ABCD"); // pool ��ü �ƴ�.
		string s4 = new string("ABCD"); // s3, s4�� �ٸ� ��ü

		// string�� refernce type�Դϴ�.
		// �Ʒ� �ڵ� ��� ������ ������
		WriteLine($"{s1 == s2}"); // True
		WriteLine($"{s3 == s4}"); // True
								  // string�� == �����ڸ� �������߽��ϴ�.
								  // �׷��� ������ ���ϼ� ����

		WriteLine($"{object.ReferenceEquals(s1, s2)}"); // True
		WriteLine($"{object.ReferenceEquals(s3, s4)}"); // False

//      Check(s1, s2); 
//		Check(s2, s3); 
//		Check(s3, s4); 
	}
}