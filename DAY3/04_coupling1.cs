using static System.Console;

// 109 page ~ 
// coupling
// => C# �� �ƴ϶� ��� ��ü���� ����� ����

class Camera
{
    public void Take() => WriteLine("Take a picture");
}

// �̷��� ���ο� ī�޶� ���Դ�.
class HDCamera
{
    public void Take() => WriteLine("Take a HD picture");
}


class People
{
    public void Use(Camera c) => c.Take();
    public void Use(HDCamera c) => c.Take();
}

class Program
{
    public static void Main()
    {
        People p = new People();

        Camera c = new Camera();
        p.Use(c);

        HDCamera hc = new HDCamera();
        p.Use(hc); // ??

    }
}

// �� �ڵ�� 
// => HDCamera �� �߰� �Ǿ�����
// => ������ �ִ� People Ŭ������ �����Ǿ����ϴ�.
// => "OCP"�� �������� ���� Ȯ�强 ���� �������� ���� ������ �Դϴ�.