using static System.Console;

class Button
{
    public void UserPressButton()
    {
        WriteLine("To Do Something");

        // ���⼭ � �۾��� �ϰ� �Ǹ�
        // ��� ��ư�� ���� ���� �ϰ� �˴ϴ�.

        // �Ϲ����� ���
        // �޼ҵ带 ����ߴٰ�
        // ���⼭ �ٽ� ��ϵ� �޼ҵ带 ȣ���ؾ� �մϴ�.
    }
}

class Program
{
    public static void Main()
    {
        Button btn1 = new Button(); // �̼��� GUI ��ư�� ����� ����
        Button btn2 = new Button();

        btn1.UserPressButton(); // ����ڰ� ��ư�� ������
        btn2.UserPressButton(); // �� �޼ҵ尡 ȣ��ȴٰ� ����. 		
    }
}