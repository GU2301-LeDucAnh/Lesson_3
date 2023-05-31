namespace Ex2
{
    public class Person
    {
        public int age;
        public void Greet()
        {
            Console.WriteLine("Xin Chao, toi la " + this.GetType().Name);
        }

        public void SetAge(int age)
        {
            this.age = age;
        }
    }

    public class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("Toi dang hoc");
        }

        public void ShowAge()
        {
            Console.WriteLine("Tuoi cua toi la: " + age + " tuoi");
        }
    }

    public class Teacher : Person
    {
        public void Explain()
        {
            Console.WriteLine("Toi dang giai thich");
        }
    }

    public class StudentProfessorTest
    {
        static void Main()
        {
            Person person = new Person();
            person.Greet();

            Student student = new Student();
            student.Greet();
            student.SetAge(20);
            student.ShowAge();

            Teacher teacher = new Teacher();
            teacher.SetAge(30);
            teacher.Greet();
            teacher.Explain();
        }
    }
}