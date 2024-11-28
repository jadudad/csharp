using static System.Console;

delegate void ClickHandler();

class Button
{
    //  public event ClickHandler? Click = null;

    // �� ������(delegate �տ� event �� ����ϸ�) �Ʒ� 3�ٷ� ����˴ϴ�.

    private ClickHandler? Click = null;

    //  Click �� private �̹Ƿ� �Ʒ� 2���� �޼ҵ�θ� ���/���� �ؾ��մϴ�.
    public void add_ClickHandler(ClickHandler handler) { Click += handler; }
    public void remove_ClickHandler(ClickHandler handler) { Click -= handler; }

    public void UserPressButton()
    {
        Click?.Invoke();
    }
}

class Program
{
    public static void Foo() => WriteLine("Foo");
    public static void Goo() => WriteLine("Goo");
    public static void Hoo() => WriteLine("Hoo");

    public static void Main()
    {
        Button btn = new Button();

        btn.Click += Foo; // btn.add_ClickHandler(Foo)
        btn.Click += Goo; // btn.add_ClickHandler(Goo)
        btn.Click += Hoo; // ���� ���� �ڵ�� ����.


        btn.UserPressButton();
    }
}

// event3 �����ؼ� ���� ���� ��Ȯ���ϰ� Day4.dll ���弼��
// ILDASM ���� ���� ������.