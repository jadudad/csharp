using static System.Console;

static class StringExtension
{
	public static int WordCount(this string s)
	{
		// string[] arr = s.Split(); // ���ڿ��� �ܾ��� �迭��
		// return arr.Length;   // �迭 ����

		return s.Split().Length;

	}
}


class Program
{
	public static void Main()
	{
		string s = "to be or not to be";

		// C# ǥ�� string���� WordCount() �޼ҵ� �����ϴ�.
		// => �߰��غ�����. �ϴ� 0 ��ȯ�غ�����.
		int wc = s.WordCount(); 

		WriteLine(wc);
	}
}
