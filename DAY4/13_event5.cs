// delegate �� ��ǥ�� Ȱ�� 3���� ***

// #1. FindIndex, Sort ���� �޼ҵ�(�˰���) ���鶧 ��å �Լ��� �ޱ����� ���
// => �̰��� event ����ϴ� �� �ƴմϴ�.
int FindIndex(int[] arr, Predicate<int> match)
{
}

FindIndex(x, IsEven);


// #2. Button ���� Ŭ���� ���鶧 ���������� � ���� �߻�(Click)�Ҷ�
//     �ܺο� �˸��� ���ؼ� �Լ� ����ϱ� ���� ���
class Button
{
    //  public ClickHandler Click = null;   // �� �ڵ� ����
    public event ClickHandler Click = null; // �� �ڵ尡 ����
}

Button btn = new Button();
btn.Click += Foo;
btn.Click = Foo; // error

// #3. ���� ǥ������ ��Ƽ� �Լ� ó�� ����ϱ� ���ؼ� ���
Func<int, int, int> add = (a, b) => a + b;