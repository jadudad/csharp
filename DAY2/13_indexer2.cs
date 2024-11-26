class Example
{
    // #1. property �Դϴ� 
    public int Data1
    {
        get => 0;
    }

    // #2. indexer(�ε���) �Դϴ�. e[0] �� ���� [] ������ ���
    public int this[int idx]
    {
        get => 0;
    }
    // #3. �ε����� int �� �ƴ� �ٸ� Ÿ�Ե� ����. �Ʒ� �ڵ�� string
    public int this[string idx] { get => 0; }

    // #4. �ε����� ������
    public int this[int idx, int idx2] { get => 0; }

    // #5
    public int this[int idx, string idx2] { get => 0; }
}
class Program
{
    public static void Main()
    {
        Example e = new Example();

        int n0 = e.Data1; // property ���

        int n1 = e[0];      // #2. ���� ������ ����

        int n2 = e["A"];    // #3. 

        int n3 = e[0, 1];   // #4. 

        int n4 = e[0, "A"]; // #5
    }
}