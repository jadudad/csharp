//#nullable enable

// C# 8.0 ���� : �Ʒ� �ڵ� s1�� ���� �ƴ�. ��� ����
// C# 8.0 ���� : s1�� ���. null �Ұ����� Ÿ������ ������ڴ� �ǵ�

// C# 8.0 ���Ķ�
// => nullable reference ����� disable�ϸ� ��� �ƴ�.
// #1. ������Ʈ ���Ͽ��� "<Nullable>disable</Nullable>"�� ����
// #2. �ҽ� ���� #nullable disable �Ǵ� enable �߰�
string s1 = null;
string? s2 = null;

Console.WriteLine(s1);
Console.WriteLine(s2);
