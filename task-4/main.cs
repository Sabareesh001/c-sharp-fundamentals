var s1 = new Student("Ram", 9.2f, 20);
var s2 = new Student("Kumar", 2.2f, 18);
var s3 = new Student("Ramesh", 4.2f, 20);
var s4 = new Student("Alex", 7.2f, 17);
var s5 = new Student("George", 3.2f, 20);

List<Student> studentList = [s1, s2, s3, s4, s5,];

IEnumerable<Student> sortedList =
    from s in studentList 
    where s.Grade > 0
    orderby s.Grade descending
    select s;


Console.WriteLine($"[{string.Join(", ",sortedList)}]");

class Student(string name, float grade, int age)
{
    public string Name { get; } = name;
    public float Grade { get; } = grade;
    public int Age { get; } = age;

    public override string ToString()
    {
        return $"name:{Name} and grade:{Grade}";
    }

}