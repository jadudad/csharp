using static System.Console;

// is, as - 72 page

string s = "hello";

// #1. C#���� ��� ����(��ü)�� object�� ����ų �� �ֽ��ϴ�.
//     (���� �ڼ��� ����)

object obj = s;

// #2. obj�� ����ϸ� String ������ �޼ҵ�� ��� �ȵ�.
// obj.String ���� �޼ҵ�() // error


// string s1 = obj; // error
string s1 = (string)obj; // ok. ����� ĳ����
                         // ��, obj�� ����Ű�� Ÿ���� string�� �ƴϸ�
                         // ���� �߻�.
// �ᱹ, ���� �Ŀ� ĳ���� �ؾ� �մϴ�.


// #1. is �����ڷ� ������ ĳ���� 

if (obj is string){
    string s2 = (string)obj;
}

//�Ʒ� �ڵ� �� �ܿ� �μ���***
if (obj is string s3)
{
    // s3 ���
}

// #2. as ������ ���
//string s4 = (string)obj; // ���н� ����
string s4 = obj as string; // ���н� null ��ȯ***
                            // obj�� string Ÿ���̸� ĳ����
                            // �ƴϸ� null ��ȯ


