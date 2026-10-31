using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class StudentStorage
    {
        private readonly List<Student> _students = [];

        private int sljedeciId = 1;

        public StudentStorage() 
        {
            Dodaj(new Student()
            {
                Ime = "Narcis",
                Prezime = "Nurkovic",
                BrojIndeksa = "IB240221",
                DatumRodjenja = new DateOnly(2005, 5, 10)
            });

            Dodaj(new Student()
            {
                Ime = "Adis",
                Prezime = "Nurkovic",
                BrojIndeksa = "IB240222",
                DatumRodjenja = new DateOnly(1974, 8, 3)
            });
        }

        public Student Dodaj(Student student)
        {
            student.Id= sljedeciId++;
            student.DatumKreiranja= DateTime.UtcNow;
            _students.Add(student);

            return student;
        }

        public List<Student> GetAll()
        {
            return _students;
        }
    }
}
