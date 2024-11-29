﻿using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

// Set 의 집합 연산

class Program
{
    public static void Main()
    {
        HashSet<char> hs = new HashSet<char>("I am a Student");
        HashSet<char> vowel = new HashSet<char>("aeiou");

        // 수학의 집합연상
        hs.IntersectWith(vowel); // 교집합

        foreach( var n in hs )
        {
            WriteLine(n);
        }

        //--------------------------------------
        SortedSet<char> ss = new SortedSet<char>("Hello, World");

        // 교집합, 합집합등 모두 가능.
        var s2 = ss.GetViewBetween('A', 'Z');

        foreach( var n in s2)
        {
            WriteLine(n); // 대문자만..
        }
    }
}