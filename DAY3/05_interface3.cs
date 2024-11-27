using static System.Console;


class Label : IComparable, ICloneable
{
    private string title;

    public Label(string s) => title = s;

    public int CompareTo(object? obj)
    {
        Label? other = obj as Label;
        return title.CompareTo(other?.title);
    }

    // object obj = new Lable() ��,  Upcasting �ǹǷ� �Ʒ� �ڵ�� ���� �ƴ�.
    public object Clone()
    {
        return new Label(title);
    }
}

class Program
{
    public static void Main()
    {
        Label d1 = new Label("GOOD");
        Label d2 = d1; // reference type �̹Ƿ� ���� ��ü�� ����Ű�� �˴ϴ�.

        // d1�� ���纻�� �����ϴ� �޼ҵ带 ������ ���ô�.

        // #1. ICloneable �������̽��� �����ϴ� ���� ��ȯ Ÿ���� object �ϼ��ۿ�
        //     �������ϴ�.
        // #2. �׷��� ������ Label Ÿ�Կ� �������� ĳ���� �ʿ� �մϴ�.
        Label d3 = (Label)d1.Clone();


        // int, double ó��, int[] �� Ÿ���Դϴ�. [] �ִٰ� �̻��ϰ�
        // �������� ������. �׳� Ÿ�� �̸��� int[] �Դϴ�.

        int[] x1 = { 1, 2, 3 };
        //      int[] x2 = x1.Clone(); // error.Clone �� ��ȯ Ÿ���� object �̹Ƿ�!!

        int[] x2 = (int[])x1.Clone();
    }


}
