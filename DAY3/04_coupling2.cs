using static System.Console;


// ī�޶� ���� ������ ����
// ī�޶� ������� ī�޶� ����� ���̿� ���Ѿ��� ��Ģ�� ���� ������ ���ô�.
// ��Ģ : ��� ī�޶�� �Ʒ� �������̽��� �����ؾ� �Ѵ�.

interface ICamera
{
    void Take();    // 1. �޼ҵ� �̸��� ǥ��(��������)
                    // 2. ���� �����ڵ� ǥ������ ����. 
}
// ���� ī�޶� ������,  ��Ģ�� �ֽ��ϴ�.
// ī�޶� ����ڴ� "��Ģ(�������̽��̸�)" ��θ� ����ϸ� �˴ϴ�.

class People
{
    public void Use(ICamera camera) { camera.Take(); }
}

// ���� ��� ī�޶� ������� ��Ģ�� ���Ѿ� �մϴ�.
// ICamera �� ���� ��ӹް�, Take() ������ �����ؾ� �մϴ�.
class Camera : ICamera
{
    public void Take() => WriteLine("Take a picture");
}

class HDCamera : ICamera
{
    public void Take() => WriteLine("Take a HD picture");
}

class FHDCamera : ICamera
{
    public void Take() => WriteLine("Take a FHD picture");
}

class Program
{
    public static void Main()
    {
        People p = new People();

        Camera c = new Camera();
        p.Use(c);

        HDCamera hc = new HDCamera();
        p.Use(hc);

        FHDCamera fhc = new FHDCamera();
        p.Use(fhc);

    }
}

// ���� ����(tightly coupling)
// => �ϳ��� Ŭ������ �ٸ� Ŭ���� ���� "Ŭ���� �̸�"�� ���� ����ϴ°�
// => ������ ���� ������ ������
// => OCP �� �����Ҽ� ����.


// ���� ����(loosely coupling)
// => �ϳ��� Ŭ������ �ٸ� Ŭ���� ���� ��Ģ�� ���� "�������̽� �̸�"
//    �� ���ؼ� ���� �ϴ� ��
// => ������ �ִ� ������
// => OCP �� �����Ѵ�.

// �ᱹ ��ü���� �������� "��Ģ(�������̽�)"�� ���� �����ڴ� ���� �ٽ�!!