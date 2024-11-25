int dayofweek = 1;

string s1 = "";

// switch statement
// => 전통적인 switch 기술
switch(dayofweek)
{
	case 0: s1 = "sun"; break;
	case 1: s1 = "mon"; break;
	case 2: s1 = "tue"; break;
	default : s1 = "unknown"; break;
}


// switch expression - 핵심!! 아주 널리 사용 ***
// = 뒤의 부분은 반드시 하나의 값 생성
// => 단, 아래 코드에서 _ 를 생략할 수가 없다.
// => switch가 반드시 하나의 값을 만들어내야하기 때문.
string s2 = dayofweek switch 
			{
				0 => "sun",
				1 => "mon",
				2 => "tue",
				_ => "unknown"
			};


// const int c = 10; // ok.
// c = 20; // error

// RUST는 아래 코드도 가능 (C 언어의 ? : 기술)
// let ret = if (a == 1) 10 else 20;

