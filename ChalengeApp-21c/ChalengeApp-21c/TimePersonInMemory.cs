namespace ChalengeApp_21c
{
    public class TimePersonInMemory : TimePersonBase
    {
        public override event GradeAddedDelegate GradeAdded;

        public List<float> grades = new List<float>();

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
                throw new Exception($"Invalid argument: {nameof(grade)}. Only grades from 1 to 1000 are allowed!");

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
    }
}
