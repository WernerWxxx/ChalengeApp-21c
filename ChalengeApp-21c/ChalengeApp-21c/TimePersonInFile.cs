using static ChalengeApp_21c.TimePersonBase;

namespace ChalengeApp_21c
{
    public class TimePersonInFile : TimePersonBase
    {
        public override event GradeAddedDelegate GradeAdded;

        private const string fileName = "grades.txt";

        public TimePersonInFile(string name, string surname)
           : base(name, surname)
        {

        }
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 1000)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }

                if (GradeAdded != null)//
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                Console.WriteLine(" Zbyt wysoka wartość ");
            }
        }
        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                AddGrade(result);
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
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();


            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line == string.Empty)
                            continue;
                        if (float.TryParse(line, out float lineinfloat))
                        {
                            statistics.AddGrade(lineinfloat);
                        }
                        else
                        {
                            throw new Exception("file contains invalid value");
                        }
                    }
                }
            }
            return statistics;
        }

        public override void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }
    }
}
