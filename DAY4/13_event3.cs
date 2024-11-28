using static System.Console;

delegate void ClickHandler();

class Button
{
    // �Ʒ� ó������� ����Ҷ� +=, -=, = �� ��� ��밡��
    //  public ClickHandler? Click = null;


    // �Ʒ� ó�� event ��� ���̸� +=, -= �� ��밡��    
    public event ClickHandler? Click = null;


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

        //      btn.Click = Foo;    // error. ó�� ��ϵ� += ���ؾ� �մϴ�.
        btn.Click += Foo;
        btn.Click += Goo;
        btn.Click += Hoo;
        //      btn.Click = Hoo; // �Ǽ��� += ��� = �� �ߴ�.
        // event ���ٸ� error.


        btn.UserPressButton();
    }
}