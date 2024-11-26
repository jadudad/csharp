using static System.Console;

class Person
{
    private int age;

    // Age �� "age�� ����ϴ� Property" ��, ����� �ʵ尡 �ֽ��ϴ�.

    // swift ���� �̷� property �� "stored property" ��� �մϴ�.
    public int Age
    {
        get => age;
        set => age = value;
    }

    // swift ���� �Ʒ����� property �� "calculation property" ��� �մϴ�.
    public bool IsAdult
    {
        get => age > 19;
    }


    private string firstName = null!;
    private string lastName = null!;

    // required : �ݵ�� �ʱ�ȭ �Ǿ�� �Ѵ�.(������ �Ǵ� new Person{����ġ})
    public required string FirstName
    {
        get => firstName;
        set => firstName = value;
    }
    public required string LastName
    {
        get => lastName;
        set => lastName = value;
    }

    // �ʵ�� firstName, lastName �� ������
    // �Ӽ��� 3���� ����
    public string FullName
    {
        get => $"{firstName} {lastName}";

    }
}


class Program
{
    public static void Main()
    {
        Person p = new Person
        {
            FirstName = "Susan",
            LastName = "Connor",
            Age = 20
        };

        //		WriteLine($"{p.FullName}, {p.IsAdult}");
    }
}