using System;
// switch�� C���� ����!!
int num = 1;

switch(num)
{
case 0: 
	Console.WriteLine("0"); 
	break;
case 1: 
	Console.WriteLine("1"); 
	break;
default:				   // ���⼭ ����Ʈ�� ���� ����.
	Console.WriteLine("other"); 
	break;
}

object obj = 3.4;
// �׷���, C���� �ξ� ���� ����� ����.
switch(obj)
{
case int: 	 Console.WriteLine("int");    break;
case double: Console.WriteLine("double"); break;
case "ABCD": Console.WriteLine("3.2");    break;
default:	 Console.WriteLine("unknown type"); break;
}


// �� �ܿ��� switch�� "���� ��Ī"���� ���� ����� �ֽ��ϴ�.