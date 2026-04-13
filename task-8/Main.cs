var list = new StudentList();

// CREATE - Add students
var stu1 = new Student("Ramesh", 21);
var stu2 = new Student("Priya", 20);
list.Add(stu1);
list.Add(stu2);
Console.WriteLine("After Add: " + $"[{string.Join(",", list.Get)}]");

// READ - Get all students
Console.WriteLine("Read All: " + $"[{string.Join(",", list.Get)}]");

// UPDATE - Update student at index 0
list.Update(0, "Rahul", 22);
Console.WriteLine("After Update: " + $"[{string.Join(",", list.Get)}]");

// DELETE - Delete student at index 1
list.Delete(1);
Console.WriteLine("After Delete: " + $"[{string.Join(",", list.Get)}]");
interface IRepository<T> where T : class
{
    public void Add(T item);
    public List<T> Get { get; }
    public void Update(int index, string Name, int age);
    public void Delete(int index);
}

class StudentList(List<Student> list = null) : IRepository<Student>
{
    public List<Student> Get { get; } = list ?? [];
    public void Add(Student stu)
    {
        Get.Add(stu);
    }
    public void Update(int index, string Name, int Age)
    {
        Student stu = Get[index];
        stu.Age = Age;
        stu.Name = Name;
    }
    public void Delete(int index)
    {
        Get.RemoveAt(index);
    }
}

class Student(string Name, int Age)
{
    public string Name { get; set; } = Name;
    public int Age { get; set; } = Age;

    public override string ToString()
    {
        return $"Name: {Name} and Age: {Age}";
    }
}