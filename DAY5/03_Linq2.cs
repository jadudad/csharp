using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[] arr = { "kim", "park", "choi", "lee", "jung" };

        // 아래 코드는 마치 SQL처럼 보입니다.
        // 그래서 이 기술의 이름이
        // "Language Intergrated Query" => "LINQ"입니다.

        //  Where, OrderBy, Select
        var names = arr.Where(s => s.Contains('i'))
                       .OrderBy(s => s.Length)
                       .Select(s => s.ToUpper());


        
        foreach (var n in names)
        {
            Console.WriteLine(n);
        }

    }
}
