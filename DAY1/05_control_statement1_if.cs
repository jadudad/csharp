// 67 page
using static System.Console;

// if ��
// 1. C���� ���� ����
// 2. ������ ������ �����̸� {} ���� ���� - ������ {}�� ����ϴ� ���� ����
// 3. () �ȿ��� bool�� ���Ǵ� �͸� ����. ������ ���� ��� �ȵ� (C������ 0�̸� False, �ƴϸ� True)

int score = 75;

if ( score > 70 ) 
//{
	WriteLine("pass");
//}
else if ( score == 70 )
{
	WriteLine("reexam");
}
else 
{
	WriteLine("fail");
}

if ( score ) { } // error
				 // C/C++�� ����