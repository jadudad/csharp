using static System.Console;

// C# �� �������̽��� �޼ҵ� �̸��� ����մϴ�.
// IComparable �� ���鶧�� ������ ���ô�.
interface IComparable
{
    // �׷���, �޼ҵ� ���ڴ� �پ��� Ÿ���� �ɼ� �ֱ� ������
    // object �� ����ɼ� �ۿ� �������ϴ�.
    //	int CompareTo(object obj);  // ~ C#8.0

    // ���� C# 9.0 ���� nullable reference �� ��������
    // �Ʒ� ó�� �����Ǿ����ϴ�.
    int CompareTo(object? obj);
}

/*
class Label : IComparable
{
    private string title;

    public Label(string s) => title = s;

    //  public int CompareTo(Label obj)  // �̷��� �ϸ� ��������...�������̽��� ���� �����ϴٺ���
    public int CompareTo(object? obj) // �̷��� ����� �ۿ� ������.
    {                                 // ��, �Ʒ� �ڵ尡 ������ ��������.
                                      // �������ϴ� ���� �ʴ�.(������ ���� �ϻ�.. )
                                      // �׷���, value type �� ���� ���� ũ��(Boxing����)

        // #1. ���ڷ� Label ��ü�� ������ ������ object Ÿ������ �޾����Ƿ�
        //     �ٽ� Label Ÿ������ ĳ�����ؼ� ����ؾ� title ���� �����մϴ�.

        // #2. 
        Label? other = obj as Label;

        //		if (other == null) { } // �̷��� �ϰų� �Ʒ�ó�� ? �� �ذ�

        return title.CompareTo(other?.title);
    }
	public int CompareTo(Label other)
	{
		return title.CompareTo(other.title);
	}
	
}
*/

class Program
{
    public static void Main()
    {
        Label d1 = new Label("GOOD");
        Label d2 = new Label("BAD");

        // ����� ���� Ÿ���� Label �� ũ�� �񱳰� �ǵ��� �غ��ô�.
        // #1. C#�� �ٸ� Ÿ�԰� ������ �̸��� ����ϴ� ���� �����ϴ�.
        int ret = d1.CompareTo(d2);

        M1(d1); // #2. �̷��Ե� �ǰ� �Ϸ��� "IComparable" �������̽���
                //    �����ϰڴٰ� ǥ���ؾ� �մϴ�.
    }

    public static void M1(IComparable c) { }

}
