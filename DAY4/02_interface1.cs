using static System.Console;

interface IMP3
{
    void Play();
    void Record();
}

class Player : IMP3
{
    // �������̽��� �޼ҵ带 �����ϴ� �Ϲ����� ���
    // public void Play() { WriteLine("Play MP3"); }

    // �������̽� �޼ҵ��� ����� ����
    // #1. �������̽��̸�.�޼ҵ� �̸����� ����
    // #2. ���������ڸ� ǥ������ �ʴ´�.
    void IMP3.Play() { WriteLine("Play MP3"); }
}

class Program
{
    public static void Main()
    {
        Player player = new Player();

        player.Play(); // error. ����� �������� �Ǿ� ������
                       //       �������̽� Ÿ������ ĳ�����ؾ߸� ȣ�Ⱑ��

        ((IMP3)player).Play(); // ok 

    }
}