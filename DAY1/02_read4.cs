using System;

// Console.Read() : 입력 버퍼에서 한자 꺼내기
// int n = Console.Read();	// 입력 대기
							// enter 를 입력해야 
							// 입력완료

Console.Write("press any key >> ");

// Console.ReadKey(): 키보드에서 직접 입력 ( 입력버퍼는 사용하지 X )
//ConsoleKeyInfo cki = Console.ReadKey(); //에코 있음.
ConsoleKeyInfo cki = Console.ReadKey(true); //에코 없음.

Console.WriteLine(cki.KeyChar); 
