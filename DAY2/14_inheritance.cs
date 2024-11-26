﻿// inheritance (상속)

// "Person 타입"을 먼저 설계하고

class Person
{
    private string name;
    private int age;
}

// Person을 확장해서 새로운 타입을 설계합니다.
class Professor  : Person
{
    private string major;
}

class Student : Person
{
    private string id;
} 

class Program
{
    public static void Main()
    {
        Student student = new Student();
    }
}

// C#:      class Student : Person
// C++:     class Student : public Person
// Python:  class Student(Person)
// Java:    class Student extends Person
// Rust:    상속 문법 없음.

// 용어
// Person : Base(기반) class, Super class, Parent class

// Student: Derived(파생) class, Sub class, Child class


