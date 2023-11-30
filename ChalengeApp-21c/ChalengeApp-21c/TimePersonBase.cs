namespace ChalengeApp_21c
{
    public abstract class TimePersonBase : ITimePerson
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public abstract event GradeAddedDelegate GradeAdded;
        public TimePersonBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public virtual void Calculation()
        {
            Statistics statistics = GetStatistics();

            Console.WriteLine(" Minimalny czas Wykonywanej Pracy lub Czynności w czasie dnia - Czas podany w minutach");
            Console.WriteLine(statistics.Min);
            Console.WriteLine(" Maksymalny czas Wykonywanej Pracy lub Czynności w czasie dnia - Czas podany w minutach");
            Console.WriteLine(statistics.Max);
            Console.WriteLine(" Średni czas Wykonywania Prac lub Czynności w czasie dnia - Czas podany w minutach");
            Console.WriteLine(statistics.Average);
            Console.WriteLine(" Symboliczny Średni czas Wykonywania Prac lub Czynności w czasie dnia - Czas podany w postaci litery");
            Console.WriteLine(statistics.AverageLetter);
        }

        public abstract void AddGrade(float grade);

        public virtual void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public virtual void AddGrade(long grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }
        public virtual void AddGrade(int grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public virtual void AddGrade(char grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public virtual void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                AddGrade(result);
            }
        }

        public abstract Statistics GetStatistics();
    }
}
