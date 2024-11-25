using System;
// switch도 C언어와 유사!!
int num = 1;

switch(num)
{
case 0: 
	Console.WriteLine("0"); 
	break;
case 1: 
	Console.WriteLine("1"); 
	break;
default:				   // 여기서 디폴트는 생략 가능.
	Console.WriteLine("other"); 
	break;
}

object obj = 3.4;
// 그런데, C보다 훨씬 많은 기능이 존재.
switch(obj)
{
case int: 	 Console.WriteLine("int");    break;
case double: Console.WriteLine("double"); break;
case "ABCD": Console.WriteLine("3.2");    break;
default:	 Console.WriteLine("unknown type"); break;
}


// 그 외에도 switch는 "패턴 매칭"으로 많은 기능이 있습니다.