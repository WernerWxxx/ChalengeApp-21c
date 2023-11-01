using static ChalengeApp_21c.TimePersonBase;

namespace ChalengeApp_21c
{
    public class TimePersonInMemory : TimePersonBase
    {
        public override event GradeAddedDelegate GradeAdded;

        private List<float> grades = new List<float>();
        public object Statistics;
        //internal string Name;
        //internal string Surname;

        public TimePersonInMemory(string name, string surname)
           : base(name, surname)
        {
        }
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 1000)
            {
                this.grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                Console.WriteLine(" Zbyt wysoka wartość ");
            }
        }

        public override void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(long grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(int grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                AddGrade(result);
            }
        }


        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();


            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }

        public override void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }
    }
}
