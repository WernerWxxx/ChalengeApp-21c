using static ChalengeApp_21c.TimePersonBase;  //

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

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception($"Invalid argument: {nameof(grade)} Only grades from 1 to 1000 are allowed!");
            }
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
    }
}
