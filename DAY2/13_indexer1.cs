using static System.Console;

// property : set/get �� �ڵ����� ����� ����
// indexer  : ��ü�� �迭 ó�� [] ������ ��밡���ϰ� �ϴ� ����

class Sentence
{
    private string[] words;  // ���ڿ�(�ܾ�)�� �迭

    public Sentence(string s)
    {
        // ���ڿ��� �ܾ�� �и�
        words = s.Split();
        // s�� ���ڿ��� �ܾ�� �и��ؼ� �迭�� ���� ��ȯ
        // new string[] { "Dog", "is", "Animal"}
    }

    public string Text
    {
        // �ܾ���� �ٽ� ���ڿ��� ����
        get { return string.Join(" ", words); }
    }

    // indexer ����� ��
    // 1. property �� ���� ����
    // 2. �̸� ��ġ�� this[int idx] ��������
    //    "Text" => "this[int idx]" �� ����
    public string this[int idx]
    {
        get { return words[idx]; }
        set { words[idx] = value; }
    }
}

class Program
{
    public static void Main()
    {
        Sentence s = new Sentence("Dog is Animal");

        WriteLine(s[2]); 	// Animal
        s[0] = "Cat";

        WriteLine(s.Text);	// Cat is Animal
    }
}