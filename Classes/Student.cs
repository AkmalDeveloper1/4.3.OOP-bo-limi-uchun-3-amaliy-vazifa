using System.Linq.Expressions;

namespace OOP_Student
{
    class MainStudent
    {
        public MainStudent()
        {
            MainStudentMethod();
        }
        public void MainStudentMethod()
        {
            int count = 1;
            Console.Write("Baho kiriting: ");
            byte.TryParse(Console.ReadLine(), out byte baho);

            List<Student> studentList = new List<Student>
                {
                    new Student(ism:"Akmal",familya:"Rakhmonov",sinf:10,baho:(Baholar)4),
                    new Student(ism:"Mardon",familya:"Rakhmonov",sinf:8,baho:(Baholar)3),
                    new Student(ism:"Maqsud",familya:"Niyozov",sinf:11,baho:(Baholar)2),
                    new Student(ism:"Zuhriddin",familya:"Salomov",sinf:10,baho:(Baholar)5),
                    new Student(ism:"Mahkam",familya:"To'raxojayer",sinf:10,baho:(Baholar)5),
                    new Student(ism:"Sardon",familya:"Jabbiyev",sinf:9,baho:(Baholar)1),
                    new Student(ism:"Ochil",familya:"Fozilov",sinf:9,baho:(Baholar)4),
                    new Student(ism:"Kamol",familya:"O'rinboyev",sinf:9,baho:(Baholar)3),
                    new Student(ism:"Hondamir",familya:"Komilov",sinf:7,baho:(Baholar)5),
                    new Student(ism:"Fayzulla",familya:"Karimov",sinf:11,baho:(Baholar)5),
                };
            foreach (var item in studentList)
            {
                if ((int)item.Baho == baho)
                {
                    Console.WriteLine($"{count++}. {item.Familya} {item.Ism}");
                }
            }
            Console.ReadKey();
        }
    }
    enum Baholar
    {
        Yomon = 1,
        Qoniqarsiz = 2,
        Qoniqarli = 3,
        Yaxshi = 4,
        Alo = 5
    }

    class Student
    {
        public Student() { }
        public Student(string ism, string familya, int sinf, Baholar baho)
        {
            Id = Guid.NewGuid();
            Ism = ism;
            Familya = familya;
            Sinf = sinf;
            Baho = baho;
        }
        public Guid Id { get; private set; }
        public string Ism { get; set; }
        public string Familya { get; set; }
        public int Sinf { get; set; }
        public Baholar Baho { get; set; }

    }

}