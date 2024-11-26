class Person
{
    // required : �ݵ�� �ʱ�ȭ �ʿ� �ϴ�.
    // init : �ʱ�ȭ ���������� ��� ����.
    public required string Name { get; init; }
    public required string Address { get; set; }
}

class Program
{
    public static void Main()
    {
        //		Person p = new Person(); // error

        Person p = new Person { Name = "kim", Address = "seoul" };

        p.Name = "lee"; // error. �ʱ�ȭ�� ����
        p.Address = "pusan"; // ok
    }
}